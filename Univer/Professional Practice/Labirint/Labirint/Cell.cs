using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labirint
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool Visited { get; set; }
        public Cell Parent { get; set; }
        public bool Start { get; set; }
        public bool Finish { get; set; }
        public int Step { get; set; }
        public bool Wall { get; set; }

    }
}
