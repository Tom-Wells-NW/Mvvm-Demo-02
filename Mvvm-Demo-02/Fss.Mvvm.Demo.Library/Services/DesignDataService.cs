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
    public class DesignDataService : IDesignDataService
    {
        private DesignDataHelper _designDataHelper;
        private ITreeNodeFactory _treeNodeFactory;

        public DesignDataService(DesignDataHelper designDataHelper, ITreeNodeFactory treeNodeFactory)
        {
            _designDataHelper = designDataHelper;
            _treeNodeFactory = treeNodeFactory;
        }

        public ITreeNode GetDefaultTreeNodeHierarchy()
        {
            var result = _treeNodeFactory.Create(-1, _designDataHelper.GetRootNodeName(), TreeNodeType.LogicalNetwork);

            var rootDeviceNames = _designDataHelper.GetDefaultDeviceNames(100);

            return result;
        }
    }
}
