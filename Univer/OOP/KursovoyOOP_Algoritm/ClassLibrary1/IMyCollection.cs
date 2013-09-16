using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibraryOfCollection
{
    public interface IMyCollection<TData>
    {
        void Add(IMyEntity<TData> obj);
        IMyEntity<TData> FindByKey(int key);
        IMyEntity<TData> GetAndDel();
        int GetSize();
    }
}
