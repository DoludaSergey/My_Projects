namespace Laba4_OS_FileInfo
{
    partial class myForm
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
            this.myBtDoIt = new System.Windows.Forms.Button();
            this.myListBoxInfo = new System.Windows.Forms.ListBox();
            this.myOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // myBtDoIt
            // 
            this.myBtDoIt.Location = new System.Drawing.Point(189, 35);
            this.myBtDoIt.Name = "myBtDoIt";
            this.myBtDoIt.Size = new System.Drawing.Size(75, 23);
            this.myBtDoIt.TabIndex = 0;
            this.myBtDoIt.Text = "Начать!!!";
            this.myBtDoIt.UseVisualStyleBackColor = true;
            this.myBtDoIt.Click += new System.EventHandler(this.myBtDoIt_Click);
            // 
            // myListBoxInfo
            // 
            this.myListBoxInfo.FormattingEnabled = true;
            this.myListBoxInfo.Location = new System.Drawing.Point(12, 122);
            this.myListBoxInfo.Name = "myListBoxInfo";
            this.myListBoxInfo.Size = new System.Drawing.Size(429, 173);
            this.myListBoxInfo.TabIndex = 1;
            // 
            // myOpenFileDialog
            // 
            this.myOpenFileDialog.FileName = "openFileDialog1";
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 307);
            this.Controls.Add(this.myListBoxInfo);
            this.Controls.Add(this.myBtDoIt);
            this.Name = "myForm";
            this.Text = "Информация о файлах. Developed by Doluda S.V.";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button myBtDoIt;
        private System.Windows.Forms.ListBox myListBoxInfo;
        private System.Windows.Forms.OpenFileDialog myOpenFileDialog;
    }
}

