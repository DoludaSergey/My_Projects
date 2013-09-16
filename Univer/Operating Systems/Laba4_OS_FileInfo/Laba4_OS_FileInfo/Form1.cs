using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Laba4_OS_FileInfo
{
    public partial class myForm : Form
    {
        string filename;
        
        public myForm()
        {
            InitializeComponent();
        }

        private void myBtDoIt_Click(object sender, EventArgs e)
        {

            // Configure open file dialog box
            
            myOpenFileDialog.FileName = "Document"; // Default file name
            myOpenFileDialog.DefaultExt = ".txt"; // Default file extension
            myOpenFileDialog.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show open file dialog box
            // Process open file dialog box results
            if (myOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = myOpenFileDialog.FileName;

                FileInfo myFI = new FileInfo(filename);

                this.myListBoxInfo.Items.Add(String.Format("Name : {0}", myFI.Name));
                this.myListBoxInfo.Items.Add(String.Format("FullName : {0}", myFI.FullName));
                this.myListBoxInfo.Items.Add(String.Format("Extension : {0}", myFI.Extension));
                this.myListBoxInfo.Items.Add(String.Format("Attributes : {0}", myFI.Attributes));
                this.myListBoxInfo.Items.Add(String.Format("Length : {0}", myFI.Length));
                this.myListBoxInfo.Items.Add(String.Format("Directory : {0}", myFI.Directory));
                this.myListBoxInfo.Items.Add(String.Format("DirectoryName : {0}", myFI.DirectoryName));
                this.myListBoxInfo.Items.Add(String.Format("CreationTime : {0}", myFI.CreationTime));
                this.myListBoxInfo.Items.Add(String.Format("LastAccessTime : {0}", myFI.LastAccessTime));
                this.myListBoxInfo.Items.Add(String.Format("LastWriteTime : {0}", myFI.LastWriteTime));
            }
            
        }
    }
}
