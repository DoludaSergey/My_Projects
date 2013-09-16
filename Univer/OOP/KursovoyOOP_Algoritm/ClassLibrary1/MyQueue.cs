using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibraryOfCollection
{
    public class MyQueue<TData> : BaseList<TData>
    {
        ElementQueue<TData> head = null;
        ElementQueue<TData> tail = null;

        public override void Add(IMyEntity<TData> obj)
        {
            var elem = new ElementQueue<TData> { Entity = obj, Next = null, Previous = null };

            if (tail == null)
            {
                head = elem;
            }
            else
            {
                elem.Previous = tail;
                tail.Next = elem;
            }
            tail = elem;
            base.Add(obj);//для увеличение счетчика
            
        }

        public override IMyEntity<TData> FindByKey(int key)
        {
            if (head == null)
                return null;
            var next = head;
            do
            {
                if (next.Entity.Key == key)
                    return next.Entity;
                next = next.Next;
            } while (next != null);
            return null;
        }

        public override IMyEntity<TData> GetAndDel()
        {
            if (head == null) return null;

            var tmp = head;

            if (head.Next == null)
                tail = null;

            head = head.Next;

            base.GetAndDelBase();

            return tmp.Entity;
        }
    }
}
