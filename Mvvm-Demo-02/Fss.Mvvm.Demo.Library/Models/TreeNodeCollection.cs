using Fss.Mvvm.Demo.Library.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fss.Mvvm.Demo.Library.Models
{
    public class TreeNodeCollection : ObservableCollection<ITreeNode>, ICollection<ITreeNode>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        public TreeNodeCollection() : base() { }

        public TreeNodeCollection(List<ITreeNode> list) : base(list) { }

        public TreeNodeCollection(IEnumerable<ITreeNode> collection) : base(collection) { }
    }
    
}
