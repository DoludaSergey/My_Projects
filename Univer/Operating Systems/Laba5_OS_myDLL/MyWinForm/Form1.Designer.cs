namespace MyWinForm
{
    partial class Form1
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
            this.BtnPrintText1 = new System.Windows.Forms.Button();
            this.BtnPrintText2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(309, 95);
            this.listBox1.TabIndex = 0;
            // 
            // BtnPrintText1
            // 
            this.BtnPrintText1.Location = new System.Drawing.Point(72, 41);
            this.BtnPrintText1.Name = "BtnPrintText1";
            this.BtnPrintText1.Size = new System.Drawing.Size(182, 23);
            this.BtnPrintText1.TabIndex = 1;
            this.BtnPrintText1.Text = "Вывести текст №1";
            this.BtnPrintText1.UseVisualStyleBackColor = true;
            this.BtnPrintText1.Click += new System.EventHandler(this.BtnPrintText1_Click);
            // 
            // BtnPrintText2
            // 
            this.BtnPrintText2.Location = new System.Drawing.Point(400, 41);
            this.BtnPrintText2.Name = "BtnPrintText2";
            this.BtnPrintText2.Size = new System.Drawing.Size(182, 23);
            this.BtnPrintText2.TabIndex = 2;
            this.BtnPrintText2.Text = "Вывести текст №2";
            this.BtnPrintText2.UseVisualStyleBackColor = true;
            this.BtnPrintText2.Click += new System.EventHandler(this.BtnPrintText2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(329, 91);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(309, 95);
            this.listBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 201);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.BtnPrintText2);
            this.Controls.Add(this.BtnPrintText1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Работа с динамически подключаемыми библиотеками. Developed by Doluda S.V.";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnPrintText1;
        private System.Windows.Forms.Button BtnPrintText2;
        private System.Windows.Forms.ListBox listBox2;
    }
}

