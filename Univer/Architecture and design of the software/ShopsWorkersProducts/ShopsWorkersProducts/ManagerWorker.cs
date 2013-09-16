using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopsWorkersProducts
{
    public class ManagerWorker
    {
        //private List<WorkersProdukt> workersProduktInfoList;
        public List<WorkersProduktInfo> WorkersProduktInfoList { get; set; }

        public ManagerWorker() 
        {
            WorkersProduktInfoList = new List<WorkersProduktInfo>();
        }

        public void AddWorkersProduktInfo(string fio, string nshop, int a, int b, int c)
        {
            WorkersProduktInfo newWorkersProduktInfo=new WorkersProduktInfo(fio,nshop,a,b,c);
            WorkersProduktInfoList.Add(newWorkersProduktInfo);
        }

        public int GetIndexWorkersProduktInfo(WorkersProduktInfo wp)
        {
            if (wp != null)
            {
                int count = 0;
                foreach (WorkersProduktInfo item in WorkersProduktInfoList)
                {
                    if(item.FIO==wp.FIO &&
                        item.NumbOfShop==wp.NumbOfShop &&
                        item.ProduktsInfo.CountProduktA==wp.ProduktsInfo.CountProduktA &&
                        item.ProduktsInfo.CountProduktB==wp.ProduktsInfo.CountProduktB &&
                        item.ProduktsInfo.CountProduktC==wp.ProduktsInfo.CountProduktC)
                        return count;
                    count++;
                }
            }

            return -1;
        }

        public void DeleteWorkersProduktInfo(int index)
        {
            if (WorkersProduktInfoList.Count > 0)
                WorkersProduktInfoList.RemoveAt(index);
        }

        public void EditWorkersProduktInfo(WorkersProduktInfo wp,int index)
        {
            if (wp != null)
            {
                if (WorkersProduktInfoList.Count > 0)
                {
                    this.WorkersProduktInfoList.RemoveAt(index);
                    this.WorkersProduktInfoList.Insert(index,wp);
                }
            }
        }

        public string FindMaxCountProdukts()
        {
            int count = 0,index = 0;
            int max = 0;

            foreach (WorkersProduktInfo wp in WorkersProduktInfoList)
            {
                if (max < wp.ProduktsInfo.AllProdukts())
                {
                    max = wp.ProduktsInfo.AllProdukts();
                    index = count;
                }
                count++;

                return string.Format("{0} из цеха {1} изготовил {2} изделия!!!",
                    WorkersProduktInfoList[index].FIO, WorkersProduktInfoList[index].NumbOfShop,max);
            }
            return "";
        }
    }
}
