using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibraryOfCollection
{
    public class ElementStack<TData>
    {
        public IMyEntity<TData> Entity { get; set; }
        public ElementStack<TData> Next { get; set; }
    }
}
