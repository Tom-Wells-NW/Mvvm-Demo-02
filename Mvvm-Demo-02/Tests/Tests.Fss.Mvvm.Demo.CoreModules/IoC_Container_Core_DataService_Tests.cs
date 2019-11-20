using Autofac;
using Fss.Mvvm.Demo.CoreModules;
using Fss.Mvvm.Demo.Library.Services.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Fss.Mvvm.Demo.CoreModules
{
    public class IoC_Container_Core_DataService_Tests
    {
        [Test]
        [Category("Integration")]
        [Description("Core.IoC.Core.Integration")]
        public void IoC_can_resolve_design_data_service_from_CoreModule()
        {
            // AAA - Arrange, Act, Assert
            // Arrange
            var builder = new ContainerBuilder();
                builder.RegisterModule<CoreModule>();
            var container = builder.Build();

            // Act
            var sut = container.Resolve<IDataService>();
            var treeNodeHierarchy = sut.GetDefaultTreeNodeHierarchy();

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(sut, Is.Not.Null);
                Assert.That(treeNodeHierarchy, Is.Not.Null);
                Assert.That(treeNodeHierarchy.ChildrenTreeNodes, Is.Not.Null);
            });
        }
    }
}
