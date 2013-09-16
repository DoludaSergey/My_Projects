using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinansManager
{
    public partial class Form1 : Form
    {

        Timer timer1 = new Timer();
        Form f2 = new Form();
        
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 5000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            timer1.Start();

            this.StartPosition = FormStartPosition.CenterScreen;

            f2.BackgroundImage = Image.FromFile(@"D:\веб.jpeg");
            f2.Size = f2.BackgroundImage.Size ;
            f2.StartPosition = FormStartPosition.CenterScreen;
            f2.ShowDialog();

        }

        void timer1_Tick(object sender, EventArgs e)
        {
            f2.Close();
            timer1.Stop();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MoneyEntry me = new MoneyEntry();
            
            double income;
            Double.TryParse(textBoxAmount.Text , out income);

            me.Amount = income;
            me.EntryDate = dateTimePickerDate.Value;
            me.Description = textBoxDescription.Text;
            me.Category = textBoxCategory.Text ;
            
            //_balance += income;
            AddEntry(me);
            UpdateBalance();
            ClearFields();
        }

        private void UpdateBalance()
        {
            double balance = 0 ;

            foreach (DataGridViewRow row in dataGridView.Rows )
            {
                double income;
                double.TryParse((row.Cells[1].Value ?? "0").ToString(),out income);

                balance += income;
            }
            textBoxBalance.Text = balance.ToString();
        }

        private void AddEntry(MoneyEntry me)
        {
            dataGridView.Rows.Add(me.IsDebit ?  "Доход ":"Расход",
                me.Amount,
                me.EntryDate.ToShortDateString (),
                me.Description,
                me.Category );
        }

        private void ClearFields()
        {
            textBoxAmount.Text = "";
            textBoxCategory.Text = "";
            textBoxDescription.Text = "";
            dateTimePickerDate.Value = DateTime.Now;
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && dataGridView.Rows.Count >0)
            {
                double income;
                double.TryParse((dataGridView[e.ColumnIndex,e.RowIndex].Value  ?? "0").ToString(), out income);

                dataGridView[0,e.RowIndex].Value= (income >0) ? "Доход":"Расход";

                UpdateBalance();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (textBoxBalance.Text!="") MessageBox.Show(string.Format("Ваш баланс равен {0}", textBoxBalance.Text));
        }
    }
}
