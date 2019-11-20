using Fss.Mvvm.Demo.Library.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fss.Mvvm.Demo.Library.Models
{
    public class TreeNodeCollectionFactory : ITreeNodeCollectionFactory
    {
        public TreeNodeCollection Create()
        {
            var result = new TreeNodeCollection();
            return result;
        }
    }
}
