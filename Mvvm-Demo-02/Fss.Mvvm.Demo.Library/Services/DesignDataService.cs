using Fss.Mvvm.Demo.Library.Helpers;
using Fss.Mvvm.Demo.Library.Models;
using Fss.Mvvm.Demo.Library.Models.Interfaces;
using Fss.Mvvm.Demo.Library.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fss.Mvvm.Demo.Library.Services
{
    public class DesignDataService : IDataService
    {
        private IDesignDataHelper _designDataHelper;
        private ITreeNodeFactory _treeNodeFactory;
        private ITreeNodeCollectionFactory _treeNodeCollectionFactory;

        public DesignDataService(IDesignDataHelper designDataHelper, ITreeNodeFactory treeNodeFactory, ITreeNodeCollectionFactory treeNodeCollectionFactory)
        {
            _designDataHelper = designDataHelper;
            _treeNodeFactory = treeNodeFactory;
        }

        public ITreeNode GetDefaultTreeNodeHierarchy()
        {
            var result = _treeNodeFactory.Create(-1, _designDataHelper.GetRootNodeName(), TreeNodeType.LogicalNetwork);

            var deviceNames = _designDataHelper.GetDefaultDeviceNames(100);
            var localDevices = _treeNodeCollectionFactory.Create();
            foreach(var name in deviceNames)
            {
                localDevices.Add(_treeNodeFactory.Create(_designDataHelper.GetNextSequenceId(), name, TreeNodeType.NodeItem));
            }


            return result;
        }
    }
}
