using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibraryOfCollection
{
    public interface IMyEntity<TData>
    {
        int Key { get; }
        TData Data { get; }
    }
}
