using Fss.Mvvm.Demo.Library.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fss.Mvvm.Demo.Library.Models
{
    public class TreeNodeFactory : ITreeNodeFactory
    {

        public ITreeNode Create(int id, string name, TreeNodeType treeNodeType)
        {
            var result = new TreeNode(id, name, treeNodeType);
            return result;
        }

        public ITreeNode Create(int id, string name, TreeNodeType treeNodeType, TreeNodeStatus treeNodeStatus, TreeNodeCollection childrenTreeNodes)
        {
            var result = new TreeNode(id, name, treeNodeType, treeNodeStatus, childrenTreeNodes);
            return result;
        }
    }
}
