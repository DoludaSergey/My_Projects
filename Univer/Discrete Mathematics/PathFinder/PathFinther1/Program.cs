using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathFinther1
{
    class Program
    {
        static void Main(string[] args)
        {
            PathFinger pf = new PathFinger();
            pf.OutputLabirint ();
            pf.FindPath();
            pf.MinPath();
            pf.Output();
        }
    }
}
