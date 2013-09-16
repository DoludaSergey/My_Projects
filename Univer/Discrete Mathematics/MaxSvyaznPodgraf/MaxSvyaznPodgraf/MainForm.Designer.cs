namespace MaxSvyaznPodgraf
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelA = new System.Windows.Forms.Label();
            this.labelOtchet = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelStartV = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonStartV = new System.Windows.Forms.Button();
            this.buttonDoIt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 301);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(626, 160);
            this.listBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 201);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(12, 22);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(145, 13);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "Матрица смежности графа";
            // 
            // labelOtchet
            // 
            this.labelOtchet.AutoSize = true;
            this.labelOtchet.Location = new System.Drawing.Point(12, 269);
            this.labelOtchet.Name = "labelOtchet";
            this.labelOtchet.Size = new System.Drawing.Size(154, 13);
            this.labelOtchet.TabIndex = 4;
            this.labelOtchet.Text = "Отчет о выполненной работе";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaxSvyaznPodgraf.Properties.Resources.Витя2;
            this.pictureBox1.Location = new System.Drawing.Point(267, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labelStartV
            // 
            this.labelStartV.AutoSize = true;
            this.labelStartV.Location = new System.Drawing.Point(264, 22);
            this.labelStartV.Name = "labelStartV";
            this.labelStartV.Size = new System.Drawing.Size(169, 13);
            this.labelStartV.TabIndex = 6;
            this.labelStartV.Text = "Установить стартовую вершину";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(439, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 7;
            // 
            // buttonStartV
            // 
            this.buttonStartV.Location = new System.Drawing.Point(533, 17);
            this.buttonStartV.Name = "buttonStartV";
            this.buttonStartV.Size = new System.Drawing.Size(75, 23);
            this.buttonStartV.TabIndex = 8;
            this.buttonStartV.Text = "Установить";
            this.buttonStartV.UseVisualStyleBackColor = true;
            this.buttonStartV.Click += new System.EventHandler(this.buttonStartV_Click);
            // 
            // buttonDoIt
            // 
            this.buttonDoIt.Location = new System.Drawing.Point(409, 264);
            this.buttonDoIt.Name = "buttonDoIt";
            this.buttonDoIt.Size = new System.Drawing.Size(75, 23);
            this.buttonDoIt.TabIndex = 9;
            this.buttonDoIt.Text = "Найти";
            this.buttonDoIt.UseVisualStyleBackColor = true;
            this.buttonDoIt.Click += new System.EventHandler(this.buttonDoIt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 472);
            this.Controls.Add(this.buttonDoIt);
            this.Controls.Add(this.buttonStartV);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelStartV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelOtchet);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Name = "MainForm";
            this.Text = "Поиск максимально сильно связных подграфов (разработал Долуда С.В.)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelOtchet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelStartV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonStartV;
        private System.Windows.Forms.Button buttonDoIt;
    }
}

