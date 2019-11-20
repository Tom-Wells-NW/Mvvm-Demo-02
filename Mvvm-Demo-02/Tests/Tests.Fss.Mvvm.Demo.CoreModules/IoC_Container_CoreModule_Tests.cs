using Autofac;
using Fss.Mvvm.Demo.CoreModules;
using Fss.Mvvm.Demo.Library.Models;
using Fss.Mvvm.Demo.Library.Models.Interfaces;
using Fss.Mvvm.Demo.Library.Services.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Fss.Mvvm.Demo.CoreModules
{
    public class IoC_Container_CoreModule_Tests
    {
        [Test]
        [Category("Integration")]
        [Description("Core.IoC.Core.Integration")]
        public void IoC_can_resolve_Core_models_and_factories_from_CoreModule()
        {
            // AAA - Arrange, Act, Assert
            // Arrange
            var builder = new ContainerBuilder();
            builder.RegisterModule<CoreModule>();
            var sut = builder.Build();

            // Act
            var treeNode = sut.Resolve<ITreeNode>();
            var treeNodeCollection = sut.Resolve<TreeNodeCollection>();

            var treeNodeFactory = sut.Resolve<ITreeNodeFactory>();
            var treeNodeCollectionFactory = sut.Resolve<ITreeNodeCollectionFactory>();


            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(treeNode, Is.Not.Null);
                Assert.That(treeNodeCollection, Is.Not.Null);
                Assert.That(treeNodeFactory, Is.Not.Null);
                Assert.That(treeNodeCollectionFactory, Is.Not.Null);
            });
        }

        [Test]
        [Category("Integration")]
        [Description("Core.IoC.Core.Integration")]
        public void IoC_can_resolve_design_data_service_from_CoreModule()
        {
            // AAA - Arrange, Act, Assert
            // Arrange
            var builder = new ContainerBuilder();
                builder.RegisterModule<CoreModule>();
            var sut = builder.Build();

            // Act
            var service = sut.Resolve<IDataService>();

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(service, Is.Not.Null);
            });
        }
    }
}
