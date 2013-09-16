using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KursovoyGrafByClass
{
    public partial class MainForm : Form
    {
        KursProekt KP;
        public MainForm()
        {
            InitializeComponent();

            KP = new KursProekt(); 
        }

        private void buttonRezult_Click(object sender, EventArgs e)
        {
            KP.Sravnenie(checkBoxFromFile1.Checked, checkBoxFromFile2.Checked, openFileDialog1, numericUpDownN1, numericUpDownM1,
                            textBoxFO1, numericUpDownN2, numericUpDownM2, textBoxFO2);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
