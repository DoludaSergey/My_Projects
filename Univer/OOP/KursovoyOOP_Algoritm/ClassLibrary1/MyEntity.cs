using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibraryOfCollection
{
    public class MyEntity<TData> : IMyEntity<TData>
    {
        #region IMyEntity Members

        public TData Data
        {
            get;
            private set;
        }

        public int Key
        {
            get;
            private set;
        }

        

        #endregion

        public MyEntity(int key, TData data)
        {
            Key = key;
            Data = data;
        }

        public override string ToString()
        {
            return this.Data.ToString();
        }
    }
}