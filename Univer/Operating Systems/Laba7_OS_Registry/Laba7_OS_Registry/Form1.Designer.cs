namespace Laba7_OS_Registry
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCreateSub = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDelete = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEditValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEditName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEnterValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEnterName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnterValue = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(458, 34);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Создать.";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Создание подраздела в  HKEY_CURRENT_USER\\Software.";
            // 
            // tbCreateSub
            // 
            this.tbCreateSub.Location = new System.Drawing.Point(174, 37);
            this.tbCreateSub.Name = "tbCreateSub";
            this.tbCreateSub.Size = new System.Drawing.Size(257, 20);
            this.tbCreateSub.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = " Введите имя папки.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbDelete);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbEditValue);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbEditName);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbEnterValue);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbEnterName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnEnterValue);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(13, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 262);
            this.panel1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = " Введите имя папки.";
            // 
            // tbDelete
            // 
            this.tbDelete.Location = new System.Drawing.Point(158, 233);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(257, 20);
            this.tbDelete.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Удаление значений подраздела.";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(442, 230);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Удалить.";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = " Введите имя параметра.";
            // 
            // tbEditValue
            // 
            this.tbEditValue.Location = new System.Drawing.Point(158, 165);
            this.tbEditValue.Name = "tbEditValue";
            this.tbEditValue.Size = new System.Drawing.Size(257, 20);
            this.tbEditValue.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = " Введите имя параметра.";
            // 
            // tbEditName
            // 
            this.tbEditName.Location = new System.Drawing.Point(158, 134);
            this.tbEditName.Name = "tbEditName";
            this.tbEditName.Size = new System.Drawing.Size(257, 20);
            this.tbEditName.TabIndex = 28;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(442, 141);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Изменить.";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = " Введите имя параметра.";
            // 
            // tbEnterValue
            // 
            this.tbEnterValue.Location = new System.Drawing.Point(158, 69);
            this.tbEnterValue.Name = "tbEnterValue";
            this.tbEnterValue.Size = new System.Drawing.Size(257, 20);
            this.tbEnterValue.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = " Введите имя параметра.";
            // 
            // tbEnterName
            // 
            this.tbEnterName.Location = new System.Drawing.Point(158, 38);
            this.tbEnterName.Name = "tbEnterName";
            this.tbEnterName.Size = new System.Drawing.Size(257, 20);
            this.tbEnterName.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Задание значений подраздела.";
            // 
            // btnEnterValue
            // 
            this.btnEnterValue.Location = new System.Drawing.Point(442, 45);
            this.btnEnterValue.Name = "btnEnterValue";
            this.btnEnterValue.Size = new System.Drawing.Size(75, 23);
            this.btnEnterValue.TabIndex = 21;
            this.btnEnterValue.Text = "Задать.";
            this.btnEnterValue.UseVisualStyleBackColor = true;
            this.btnEnterValue.Click += new System.EventHandler(this.btnEnterValue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Изменение значений подраздела.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 346);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCreateSub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Работа с системным реестром. Developed by Doluda S.V.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCreateSub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEditValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEditName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEnterValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEnterName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnterValue;
        private System.Windows.Forms.Label label3;
    }
}

