using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopsWorkersProducts
{
    public class WorkersProduktInfo
    {
        public string FIO { get; set; }
        public string NumbOfShop { get; set; }
        public Produkts ProduktsInfo { get; set; }

        public WorkersProduktInfo() { }
        public WorkersProduktInfo(string fio, string numbOfShop, int a, int b, int c) 
        {
            this.FIO = fio;
            this.NumbOfShop = numbOfShop;
            this.ProduktsInfo = new Produkts(a, b, c);
        }
    

    }
}
