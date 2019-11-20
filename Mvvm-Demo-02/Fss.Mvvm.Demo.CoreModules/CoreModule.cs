using Autofac;
using Fss.Mvvm.Demo.Library.Helpers;
using Fss.Mvvm.Demo.Library.Models;
using Fss.Mvvm.Demo.Library.Models.Interfaces;
using Fss.Mvvm.Demo.Library.Services;
using Fss.Mvvm.Demo.Library.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fss.Mvvm.Demo.CoreModules
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            // Models

            builder.RegisterType<TreeNode>()
                   .As<ITreeNode>()
                   .AsSelf();

            builder.RegisterType<TreeNodeCollection>()
                   .AsSelf();


            // Services

            builder.RegisterType<DesignDataHelper>()
                   .As<IDesignDataHelper>()
                   .SingleInstance();

            builder.RegisterType<DesignDataService>()
                   .As<IDataService>()
                   .SingleInstance();

            // Factories

            builder.RegisterType<TreeNodeFactory>()
                   .As<ITreeNodeFactory>()
                   .AsSelf();

            builder.RegisterType<TreeNodeCollectionFactory>()
                   .As<ITreeNodeCollectionFactory>()
                   .AsSelf();

        }
    }
}
