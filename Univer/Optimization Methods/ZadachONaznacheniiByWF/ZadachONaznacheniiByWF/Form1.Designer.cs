namespace ZadachONaznacheniiByWF
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
            this.myLB = new System.Windows.Forms.ListBox();
            this.myDGW = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // myLB
            // 
            this.myLB.FormattingEnabled = true;
            this.myLB.Location = new System.Drawing.Point(12, 163);
            this.myLB.Name = "myLB";
            this.myLB.Size = new System.Drawing.Size(467, 316);
            this.myLB.TabIndex = 0;
            // 
            // myDGW
            // 
            this.myDGW.AllowUserToAddRows = false;
            this.myDGW.AllowUserToDeleteRows = false;
            this.myDGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.myDGW.Location = new System.Drawing.Point(12, 12);
            this.myDGW.Name = "myDGW";
            this.myDGW.ReadOnly = true;
            this.myDGW.RowHeadersWidth = 120;
            this.myDGW.Size = new System.Drawing.Size(467, 112);
            this.myDGW.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Работа №1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Работа №2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Работа №3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Работа №4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 491);
            this.Controls.Add(this.myDGW);
            this.Controls.Add(this.myLB);
            this.Name = "Form1";
            this.Text = "Задача о назначениях (Developed by Doluda S.V.)";
            ((System.ComponentModel.ISupportInitialize)(this.myDGW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox myLB;
        private System.Windows.Forms.DataGridView myDGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

