namespace InsertSort
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreateMas = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.labelSortInfo = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateMas
            // 
            this.buttonCreateMas.Location = new System.Drawing.Point(382, 12);
            this.buttonCreateMas.Name = "buttonCreateMas";
            this.buttonCreateMas.Size = new System.Drawing.Size(151, 23);
            this.buttonCreateMas.TabIndex = 0;
            this.buttonCreateMas.Text = "Сгенерировать элементы";
            this.buttonCreateMas.UseVisualStyleBackColor = true;
            this.buttonCreateMas.Click += new System.EventHandler(this.buttonCreateMas_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(9, 17);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(238, 13);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Введите количество сортируемых элементов";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(521, 134);
            this.listBox1.TabIndex = 2;
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(261, 14);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum.TabIndex = 3;
            // 
            // labelSortInfo
            // 
            this.labelSortInfo.AutoSize = true;
            this.labelSortInfo.Location = new System.Drawing.Point(12, 53);
            this.labelSortInfo.Name = "labelSortInfo";
            this.labelSortInfo.Size = new System.Drawing.Size(317, 13);
            this.labelSortInfo.TabIndex = 4;
            this.labelSortInfo.Text = "Для сортировки элементов нажмите кнопку Отсортировать!";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(382, 48);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(151, 23);
            this.buttonSort.TabIndex = 5;
            this.buttonSort.Text = "Отсортировать!";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 228);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.labelSortInfo);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonCreateMas);
            this.Name = "Form1";
            this.Text = "Сортировка вставками (Copyright by Doluda S.V.)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateMas;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label labelSortInfo;
        private System.Windows.Forms.Button buttonSort;
    }
}

