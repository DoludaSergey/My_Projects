using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShopsWorkersProducts
{
    public partial class MainForm : Form
    {
        ManagerWorker manadger;
        List<WorkersProduktInfo> workersProduktList;
        WorkersProduktInfo curentWorkersProdukt;

        public MainForm()
        {
            InitializeComponent();

            workersProduktList = new List<WorkersProduktInfo>();
            manadger = new ManagerWorker();
        }

        private void buttonAddWorkersProduktInfo_Click(object sender, EventArgs e)
        {
            string fio, nshop;
            int a, b, c;

            fio = this.textBoxAddFIO.Text;
            nshop = this.textBoxAddNShop.Text;
            int.TryParse(this.textBoxAddProduktA.Text, out a);
            int.TryParse(this.textBoxAddProduktB.Text, out b);
            int.TryParse(this.textBoxAddProduktC.Text, out c);

            manadger.AddWorkersProduktInfo(fio,nshop,a,b,c);
            workersProduktList = manadger.WorkersProduktInfoList;

            AddToGrid();
            this.tabControl1.SelectTab(this.tabPage1);
            ClearAddTB();
        }

        private void AddToGrid()
        {
            this.dataGridView1.Rows.Clear();

            foreach (WorkersProduktInfo info in workersProduktList)
                this.dataGridView1.Rows.Add(info.FIO,
                    info.NumbOfShop,
                    info.ProduktsInfo.CountProduktA,
                    info.ProduktsInfo.CountProduktB,
                    info.ProduktsInfo.CountProduktC);
        }

        private void ClearAddTB()
        {
            this.textBoxAddFIO.Text = "";
            this.textBoxAddNShop.Text = "";
            this.textBoxAddProduktA.Text = "";
            this.textBoxAddProduktB.Text = "";
            this.textBoxAddProduktC.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 1)
            {
                TextBox[] textBoxForDelete = { this.textBoxDeleteFIO,
                                             this.textBoxDeleteNShop,
                                             this.textBoxDeleteNProduktA,
                                             this.textBoxDeleteNProduktB,
                                             this.textBoxDeleteNProduktC};

                TextBox[] textBoxForEdit = { this.textBoxEditFIO,
                                           this.textBoxEditNShop,
                                           this.textBoxEditNProduktA,
                                           this.textBoxEditProduktB,
                                           this.textBoxEditProduktC};

                int count = 0;
                List<string> param = new List<string>();

                foreach (DataGridViewCell cell in this.dataGridView1.CurrentRow.Cells)
                {
                    textBoxForDelete[count].Text = cell.Value.ToString();
                    textBoxForEdit[count].Text = cell.Value.ToString();
                    param.Add(cell.Value.ToString());
                    count++;
                }

                curentWorkersProdukt = new WorkersProduktInfo(
                    param[0], param[1], int.Parse(param[2]), int.Parse(param[3]), int.Parse(param[4]));
            }
        }

        private void buttonDeleteWorkersProduktsInfo_Click(object sender, EventArgs e)
        {
            manadger.DeleteWorkersProduktInfo(manadger.GetIndexWorkersProduktInfo(curentWorkersProdukt));
            workersProduktList = manadger.WorkersProduktInfoList;

            AddToGrid();
            this.tabControl1.SelectTab(this.tabPage1);
        }

        private void buttonEditWorkersProduktsInfo_Click(object sender, EventArgs e)
        {
            int index = manadger.GetIndexWorkersProduktInfo(curentWorkersProdukt);
            int a, b, c;

            int.TryParse(this.textBoxEditNProduktA.Text,out a);
            int.TryParse(this.textBoxEditProduktB.Text, out b);
            int.TryParse(this.textBoxEditProduktC.Text, out c);

            if(this.curentWorkersProdukt.FIO!=this.textBoxEditFIO.Text ||
                this.curentWorkersProdukt.NumbOfShop!=this.textBoxEditNShop.Text ||
                this.curentWorkersProdukt.ProduktsInfo.CountProduktA!=a ||
                this.curentWorkersProdukt.ProduktsInfo.CountProduktB!=b ||
                this.curentWorkersProdukt.ProduktsInfo.CountProduktC!=c)
            {
                WorkersProduktInfo newWP = new WorkersProduktInfo(
                    this.textBoxEditNShop.Text,this.textBoxEditNShop.Text,a,b,c);

                manadger.EditWorkersProduktInfo(newWP, index);
                workersProduktList = manadger.WorkersProduktInfoList;
                AddToGrid();
                this.tabControl1.SelectTab(this.tabPage1);
            }


        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            this.labelRezult.Text= manadger.FindMaxCountProdukts();
        }
    }
}
