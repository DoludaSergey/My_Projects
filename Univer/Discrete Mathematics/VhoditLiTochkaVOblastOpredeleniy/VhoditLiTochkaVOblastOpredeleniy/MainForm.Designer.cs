namespace VhoditLiTochkaVOblastOpredeleniy
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
            this.labelZadanie = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelZadanie
            // 
            this.labelZadanie.AutoSize = true;
            this.labelZadanie.Location = new System.Drawing.Point(367, 24);
            this.labelZadanie.Name = "labelZadanie";
            this.labelZadanie.Size = new System.Drawing.Size(150, 13);
            this.labelZadanie.TabIndex = 0;
            this.labelZadanie.Text = "Введите координаты точки :";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(435, 52);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 1;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(341, 55);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(77, 13);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "Координата X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(341, 107);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(77, 13);
            this.labelY.TabIndex = 3;
            this.labelY.Text = "Координата Y";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(435, 104);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 4;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(390, 147);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(93, 23);
            this.buttonTest.TabIndex = 5;
            this.buttonTest.Text = "Определить";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VhoditLiTochkaVOblastOpredeleniy.Properties.Resources.Область_определения;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 359);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelZadanie);
            this.Name = "MainForm";
            this.Text = "Определение вхождения точки в область значений (разработал Долуда С.В.)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZadanie;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

