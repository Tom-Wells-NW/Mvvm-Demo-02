using System.Collections.Generic;

namespace Fss.Mvvm.Demo.Library.Models.Interfaces
{
    public interface ITreeNode
    {
        int Id { get; }
        string Name { get; }
        TreeNodeType TreeNodeType { get; }
        TreeNodeCollection ChildrenTreeNodes { get; }
        int ParentId { get; set; }
    }
}