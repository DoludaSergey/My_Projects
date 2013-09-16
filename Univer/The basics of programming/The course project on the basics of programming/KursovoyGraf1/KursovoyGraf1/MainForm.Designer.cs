namespace KursovoyGraf1
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
            this.groupBoxGraf1 = new System.Windows.Forms.GroupBox();
            this.checkBoxFromFile1 = new System.Windows.Forms.CheckBox();
            this.numericUpDownM1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownN1 = new System.Windows.Forms.NumericUpDown();
            this.labelM1 = new System.Windows.Forms.Label();
            this.labelN1 = new System.Windows.Forms.Label();
            this.textBoxFO1 = new System.Windows.Forms.TextBox();
            this.labelFO1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxFromFile2 = new System.Windows.Forms.CheckBox();
            this.numericUpDownM2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownN2 = new System.Windows.Forms.NumericUpDown();
            this.labelM2 = new System.Windows.Forms.Label();
            this.labelN2 = new System.Windows.Forms.Label();
            this.textBoxFO2 = new System.Windows.Forms.TextBox();
            this.labelFO2 = new System.Windows.Forms.Label();
            this.buttonRezult = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxGraf1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxGraf1
            // 
            this.groupBoxGraf1.Controls.Add(this.checkBoxFromFile1);
            this.groupBoxGraf1.Controls.Add(this.numericUpDownM1);
            this.groupBoxGraf1.Controls.Add(this.numericUpDownN1);
            this.groupBoxGraf1.Controls.Add(this.labelM1);
            this.groupBoxGraf1.Controls.Add(this.labelN1);
            this.groupBoxGraf1.Controls.Add(this.textBoxFO1);
            this.groupBoxGraf1.Controls.Add(this.labelFO1);
            this.groupBoxGraf1.Location = new System.Drawing.Point(30, 24);
            this.groupBoxGraf1.Name = "groupBoxGraf1";
            this.groupBoxGraf1.Size = new System.Drawing.Size(259, 170);
            this.groupBoxGraf1.TabIndex = 0;
            this.groupBoxGraf1.TabStop = false;
            this.groupBoxGraf1.Text = "Граф 1";
            // 
            // checkBoxFromFile1
            // 
            this.checkBoxFromFile1.AutoSize = true;
            this.checkBoxFromFile1.Location = new System.Drawing.Point(10, 147);
            this.checkBoxFromFile1.Name = "checkBoxFromFile1";
            this.checkBoxFromFile1.Size = new System.Drawing.Size(166, 17);
            this.checkBoxFromFile1.TabIndex = 7;
            this.checkBoxFromFile1.Text = "Вывод из файла 1-го графа";
            this.checkBoxFromFile1.UseVisualStyleBackColor = true;
            // 
            // numericUpDownM1
            // 
            this.numericUpDownM1.Location = new System.Drawing.Point(48, 110);
            this.numericUpDownM1.Name = "numericUpDownM1";
            this.numericUpDownM1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownM1.TabIndex = 5;
            // 
            // numericUpDownN1
            // 
            this.numericUpDownN1.Location = new System.Drawing.Point(48, 81);
            this.numericUpDownN1.Name = "numericUpDownN1";
            this.numericUpDownN1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownN1.TabIndex = 4;
            // 
            // labelM1
            // 
            this.labelM1.AutoSize = true;
            this.labelM1.Location = new System.Drawing.Point(7, 112);
            this.labelM1.Name = "labelM1";
            this.labelM1.Size = new System.Drawing.Size(21, 13);
            this.labelM1.TabIndex = 3;
            this.labelM1.Text = "m1";
            // 
            // labelN1
            // 
            this.labelN1.AutoSize = true;
            this.labelN1.Location = new System.Drawing.Point(7, 83);
            this.labelN1.Name = "labelN1";
            this.labelN1.Size = new System.Drawing.Size(19, 13);
            this.labelN1.TabIndex = 2;
            this.labelN1.Text = "n1";
            // 
            // textBoxFO1
            // 
            this.textBoxFO1.Location = new System.Drawing.Point(48, 27);
            this.textBoxFO1.Multiline = true;
            this.textBoxFO1.Name = "textBoxFO1";
            this.textBoxFO1.Size = new System.Drawing.Size(193, 20);
            this.textBoxFO1.TabIndex = 1;
            // 
            // labelFO1
            // 
            this.labelFO1.AutoSize = true;
            this.labelFO1.Location = new System.Drawing.Point(7, 30);
            this.labelFO1.Name = "labelFO1";
            this.labelFO1.Size = new System.Drawing.Size(30, 13);
            this.labelFO1.TabIndex = 0;
            this.labelFO1.Text = "FO 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxFromFile2);
            this.groupBox2.Controls.Add(this.numericUpDownM2);
            this.groupBox2.Controls.Add(this.numericUpDownN2);
            this.groupBox2.Controls.Add(this.labelM2);
            this.groupBox2.Controls.Add(this.labelN2);
            this.groupBox2.Controls.Add(this.textBoxFO2);
            this.groupBox2.Controls.Add(this.labelFO2);
            this.groupBox2.Location = new System.Drawing.Point(308, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Граф 2";
            // 
            // checkBoxFromFile2
            // 
            this.checkBoxFromFile2.AutoSize = true;
            this.checkBoxFromFile2.Location = new System.Drawing.Point(10, 147);
            this.checkBoxFromFile2.Name = "checkBoxFromFile2";
            this.checkBoxFromFile2.Size = new System.Drawing.Size(166, 17);
            this.checkBoxFromFile2.TabIndex = 7;
            this.checkBoxFromFile2.Text = "Вывод из файла 2-го графа";
            this.checkBoxFromFile2.UseVisualStyleBackColor = true;
            // 
            // numericUpDownM2
            // 
            this.numericUpDownM2.Location = new System.Drawing.Point(48, 110);
            this.numericUpDownM2.Name = "numericUpDownM2";
            this.numericUpDownM2.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownM2.TabIndex = 5;
            // 
            // numericUpDownN2
            // 
            this.numericUpDownN2.Location = new System.Drawing.Point(48, 81);
            this.numericUpDownN2.Name = "numericUpDownN2";
            this.numericUpDownN2.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownN2.TabIndex = 4;
            // 
            // labelM2
            // 
            this.labelM2.AutoSize = true;
            this.labelM2.Location = new System.Drawing.Point(7, 112);
            this.labelM2.Name = "labelM2";
            this.labelM2.Size = new System.Drawing.Size(21, 13);
            this.labelM2.TabIndex = 3;
            this.labelM2.Text = "m2";
            // 
            // labelN2
            // 
            this.labelN2.AutoSize = true;
            this.labelN2.Location = new System.Drawing.Point(7, 83);
            this.labelN2.Name = "labelN2";
            this.labelN2.Size = new System.Drawing.Size(19, 13);
            this.labelN2.TabIndex = 2;
            this.labelN2.Text = "n2";
            // 
            // textBoxFO2
            // 
            this.textBoxFO2.Location = new System.Drawing.Point(48, 27);
            this.textBoxFO2.Multiline = true;
            this.textBoxFO2.Name = "textBoxFO2";
            this.textBoxFO2.Size = new System.Drawing.Size(193, 20);
            this.textBoxFO2.TabIndex = 1;
            // 
            // labelFO2
            // 
            this.labelFO2.AutoSize = true;
            this.labelFO2.Location = new System.Drawing.Point(7, 30);
            this.labelFO2.Name = "labelFO2";
            this.labelFO2.Size = new System.Drawing.Size(30, 13);
            this.labelFO2.TabIndex = 0;
            this.labelFO2.Text = "FO 2";
            // 
            // buttonRezult
            // 
            this.buttonRezult.Location = new System.Drawing.Point(259, 231);
            this.buttonRezult.Name = "buttonRezult";
            this.buttonRezult.Size = new System.Drawing.Size(75, 23);
            this.buttonRezult.TabIndex = 2;
            this.buttonRezult.Text = "Вычислить";
            this.buttonRezult.UseVisualStyleBackColor = true;
            this.buttonRezult.Click += new System.EventHandler(this.buttonRezult_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(259, 260);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 309);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRezult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxGraf1);
            this.Name = "MainForm";
            this.Text = "Сравнение двух графов на равенство по радиусу";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxGraf1.ResumeLayout(false);
            this.groupBoxGraf1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGraf1;
        private System.Windows.Forms.Label labelM1;
        private System.Windows.Forms.Label labelN1;
        private System.Windows.Forms.TextBox textBoxFO1;
        private System.Windows.Forms.Label labelFO1;
        private System.Windows.Forms.NumericUpDown numericUpDownM1;
        private System.Windows.Forms.NumericUpDown numericUpDownN1;
        private System.Windows.Forms.CheckBox checkBoxFromFile1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxFromFile2;
        private System.Windows.Forms.NumericUpDown numericUpDownM2;
        private System.Windows.Forms.NumericUpDown numericUpDownN2;
        private System.Windows.Forms.Label labelM2;
        private System.Windows.Forms.Label labelN2;
        private System.Windows.Forms.TextBox textBoxFO2;
        private System.Windows.Forms.Label labelFO2;
        private System.Windows.Forms.Button buttonRezult;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

