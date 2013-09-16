using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibraryOfCollection
{
    public class MyList<TData> : BaseList<TData>
    {
        List<IMyEntity<TData>> myList = new List<IMyEntity<TData>>();

        public override void Add(IMyEntity<TData> obj)
        {
            myList.Add(obj);
            base.Add(obj);//для увеличение счетчика

        }

        public override IMyEntity<TData> FindByKey(int key)
        {
            if (myList.Count > 0)
            {
                var elem = myList.Find(e => e.Key == key);
                return elem;
            }
            return null;
        }

        public override IMyEntity<TData> GetAndDel()
        {
            if (myList.Count > 0)
            {
                var firstElem = myList.First();
                myList.Remove(firstElem);
                base.GetAndDelBase();
                return firstElem;
            }
            return null;
        }
    }
}
