namespace Fss.Mvvm.Demo.Library.Models.Interfaces
{
    public interface ITreeNodeFactory
    {
        ITreeNode Create(int id, string name, TreeNodeType treeNodeType);
        ITreeNode Create(int id, string name, TreeNodeType treeNodeType, TreeNodeStatus treeNodeStatus, TreeNodeCollection childrenTreeNodes);
    }
}