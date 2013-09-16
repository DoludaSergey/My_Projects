using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibraryOfCollection
{
    public class MyDictionary<TData> : BaseList<TData>
    {
        Dictionary<int, TData> myDictionary = new Dictionary<int, TData>();

        public override void Add(IMyEntity<TData> obj)
        {
            myDictionary.Add(obj.Key, obj.Data);

            base.Add(obj);//для увеличение счетчика
        }

        public override IMyEntity<TData> FindByKey(int key)
        {
            if (myDictionary.Count > 0)
            {
                foreach (var elem in myDictionary)
                {
                    if (elem.Key==key)
                    {
                        return new MyEntity<TData>(elem.Key, elem.Value);
                    }
                }               
            }
            return null;
        }

        public override IMyEntity<TData> GetAndDel()
        {
            if (myDictionary.Count > 0)
            {
                var firstElem = myDictionary.First();
                
                myDictionary.Remove(firstElem.Key);
                
                base.GetAndDelBase();
                
                return new MyEntity<TData>(firstElem.Key, firstElem.Value);
            }
            return null;
        }
    }
}
