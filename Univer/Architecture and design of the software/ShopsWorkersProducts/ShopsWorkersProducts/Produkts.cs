using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopsWorkersProducts
{
    public class Produkts
    {
        public int CountProduktA { get; set; }
        public int CountProduktB { get; set; }
        public int CountProduktC { get; set; }

        public int AllProdukts()
        {
            return (CountProduktA + CountProduktB + CountProduktC);
        }

        public Produkts() { }
        public Produkts(int a,int b,int c) 
        {
            this.CountProduktA = a;
            this.CountProduktB = b;
            this.CountProduktC = c;
        }

    }
}
