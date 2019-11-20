using Fss.Mvvm.Demo.Library.Models.Interfaces;

namespace Fss.Mvvm.Demo.Library.Services.Interfaces
{
    public interface IDataService
    {
        ITreeNode GetDefaultTreeNodeHierarchy();
    }
}