using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fss.Mvvm.Demo.Library.Helpers
{

    //      + LogicalNetwork
    //          + Node 41st-BCT 
    //              - Router 101
    //              - Firewall 102
    //              - Router 103
    //          + Node BN 2-162 
    //              - Router 201
    //              - Firewall 202
    //              - Router 203
    //          + Node BN 1-186 
    //              - Router 301
    //              - Firewall 302
    //              - Router 303
    //              + Node 141st-BSB    (Reports to BN 1-186)
    //                  - Router 401
    //                  - Firewall 402
    //                  - Router 403

    public class DesignDataHelper : IDesignDataHelper
    {
        public List<string> GetDefaultDeviceNames(int startSequenceCode)
        {
            return new List<string>
            {
                $"Router {startSequenceCode++:000}",
                $"Firewall {startSequenceCode++:000}",
                $"Router {startSequenceCode++:000}"
            };
        }

        public List<string> GetDefaultManagerNodeNames()
        {
            return new List<string>
            {
                "41st-BCT",
                "BN 2-162",
                "BN 1-186",
                "141st-BSB"
            };
        }

        public string GetRootNodeName()
        {
            return "Logical Network";
        }



        public int GetRootNodeId()
        {
            return -1;
        }

        static int __nextSequenceId = 100;
        public void SetSequenceSeed(int nextSequenceId)
        {
            __nextSequenceId = nextSequenceId;
        }

        public void BumpSequenceRange()
        {
            __nextSequenceId = ((__nextSequenceId + 100) - (__nextSequenceId % 100));
        }

        public int GetNextSequenceId()
        {
            return __nextSequenceId++;
        }

    }
}
