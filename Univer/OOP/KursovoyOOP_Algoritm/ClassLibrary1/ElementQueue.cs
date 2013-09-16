using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibraryOfCollection
{
    public class ElementQueue<TData>
    {
        public IMyEntity<TData> Entity { get; set; }
        public ElementQueue<TData> Next { get; set; }
        public ElementQueue<TData> Previous { get; set; }
    }
}
