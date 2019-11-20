using Fss.Mvvm.Demo.Library.Models.Interfaces;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fss.Mvvm.Demo.Library.Models
{
    public class TreeNode : ObservableObject, ITreeNode
    {
        public TreeNode(int id, string name, TreeNodeType treeNodeType)
            : this(id, name, treeNodeType, TreeNodeStatus.Unknown, new TreeNodeCollection())
        { }

        public TreeNode(int id, string name, TreeNodeType treeNodeType, TreeNodeStatus treeNodeStatus, TreeNodeCollection childrenTreeNodes)
        {
            Id = id;
            Name = name;
            TreeNodeType = treeNodeType;
            ChildrenTreeNodes = childrenTreeNodes;
        }

        private int _id;
        public int Id
        {
            get { return _id; }
            private set { Set(ref _id, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            private set { Set(ref _name, value); }
        }

        private TreeNodeType _treeNodeType;
        public TreeNodeType TreeNodeType
        {
            get { return _treeNodeType; }
            private set { Set(ref _treeNodeType, value); }
        }

        private TreeNodeStatus _treeNodeStatus;
        public TreeNodeStatus TreeNodeStatus
        {
            get { return _treeNodeStatus; }
            private set { Set(ref _treeNodeStatus, value); }
        }

        public virtual void CalculateTreeNodeStatus()
        {

        }

        private int _parentId;
        public int ParentId
        { 
            get { return _parentId; }
            set { Set(ref _parentId, value); }
        }

        private TreeNodeCollection _childrenTreeNodes;
        public TreeNodeCollection ChildrenTreeNodes
        {
            get { return _childrenTreeNodes; }
            private set { Set(ref _childrenTreeNodes, value); }
        }

        public void SetChildrenTreeNodes(TreeNodeCollection childrenTreeNodes)
        {
            ReparentChildrenTreeNodes(childrenTreeNodes);
            ChildrenTreeNodes = childrenTreeNodes;
        }
        private void ReparentChildrenTreeNodes(TreeNodeCollection childrenTreeNodes)
        {
            foreach(var treeNode in childrenTreeNodes)
            {
                treeNode.ParentId = Id;
            }
        }
    }
}
