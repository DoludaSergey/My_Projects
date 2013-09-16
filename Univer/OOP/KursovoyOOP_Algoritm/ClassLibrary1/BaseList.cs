using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibraryOfCollection
{
    abstract public class BaseList<TData> :IMyCollection<TData>
    {
        int size = 0;
        #region IMyCollection Members

        public virtual void Add(IMyEntity<TData> obj)
        {
            size++;
        }

        abstract public IMyEntity<TData> FindByKey(int key);

        public void GetAndDelBase()
        {
            size--;
        }

        public int GetSize()
        {
            return size;
        }

        #endregion

        #region IMyCollection Members


        abstract public IMyEntity<TData> GetAndDel();

        #endregion
    }
}
