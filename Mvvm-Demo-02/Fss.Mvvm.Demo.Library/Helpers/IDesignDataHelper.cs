using System.Collections.Generic;

namespace Fss.Mvvm.Demo.Library.Helpers
{
    public interface IDesignDataHelper
    {
        void BumpSequenceRange();
        List<string> GetDefaultDeviceNames(int startSequenceCode);
        List<string> GetDefaultManagerNodeNames();
        int GetNextSequenceId();
        int GetRootNodeId();
        string GetRootNodeName();
        void SetSequenceSeed(int nextSequenceId);
    }
}