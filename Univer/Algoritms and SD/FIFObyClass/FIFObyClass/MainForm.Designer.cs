namespace FIFObyClass
{
    partial class MainForm
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonAddNode = new System.Windows.Forms.Button();
            this.buttonShowList = new System.Windows.Forms.Button();
            this.buttonDeleteList = new System.Windows.Forms.Button();
            this.buttonFirstNode = new System.Windows.Forms.Button();
            this.buttonEmpty = new System.Windows.Forms.Button();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(21, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(93, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Введите данные:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(355, 147);
            this.listBox1.TabIndex = 1;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(67, 37);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(80, 20);
            this.textBoxKey.TabIndex = 2;
            // 
            // buttonAddNode
            // 
            this.buttonAddNode.Location = new System.Drawing.Point(402, 34);
            this.buttonAddNode.Name = "buttonAddNode";
            this.buttonAddNode.Size = new System.Drawing.Size(122, 23);
            this.buttonAddNode.TabIndex = 3;
            this.buttonAddNode.Text = "Добавить в очередь";
            this.buttonAddNode.UseVisualStyleBackColor = true;
            this.buttonAddNode.Click += new System.EventHandler(this.buttonAddNode_Click);
            // 
            // buttonShowList
            // 
            this.buttonShowList.Location = new System.Drawing.Point(402, 68);
            this.buttonShowList.Name = "buttonShowList";
            this.buttonShowList.Size = new System.Drawing.Size(122, 23);
            this.buttonShowList.TabIndex = 4;
            this.buttonShowList.Text = "Показать очередь";
            this.buttonShowList.UseVisualStyleBackColor = true;
            this.buttonShowList.Click += new System.EventHandler(this.buttonShowList_Click);
            // 
            // buttonDeleteList
            // 
            this.buttonDeleteList.Location = new System.Drawing.Point(402, 102);
            this.buttonDeleteList.Name = "buttonDeleteList";
            this.buttonDeleteList.Size = new System.Drawing.Size(122, 23);
            this.buttonDeleteList.TabIndex = 5;
            this.buttonDeleteList.Text = "Удалить запись";
            this.buttonDeleteList.UseVisualStyleBackColor = true;
            this.buttonDeleteList.Click += new System.EventHandler(this.buttonDeleteList_Click);
            // 
            // buttonFirstNode
            // 
            this.buttonFirstNode.Location = new System.Drawing.Point(402, 136);
            this.buttonFirstNode.Name = "buttonFirstNode";
            this.buttonFirstNode.Size = new System.Drawing.Size(122, 23);
            this.buttonFirstNode.TabIndex = 6;
            this.buttonFirstNode.Text = "Кто первый?";
            this.buttonFirstNode.UseVisualStyleBackColor = true;
            this.buttonFirstNode.Click += new System.EventHandler(this.buttonFirstNode_Click);
            // 
            // buttonEmpty
            // 
            this.buttonEmpty.Location = new System.Drawing.Point(402, 170);
            this.buttonEmpty.Name = "buttonEmpty";
            this.buttonEmpty.Size = new System.Drawing.Size(122, 23);
            this.buttonEmpty.TabIndex = 7;
            this.buttonEmpty.Text = "Есть кто в очереди?";
            this.buttonEmpty.UseVisualStyleBackColor = true;
            this.buttonEmpty.Click += new System.EventHandler(this.buttonEmpty_Click);
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(219, 37);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(160, 20);
            this.textBoxData.TabIndex = 8;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(21, 40);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(31, 13);
            this.lblKey.TabIndex = 9;
            this.lblKey.Text = "Key :";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(172, 40);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 13);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data :";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(402, 204);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(122, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 242);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.buttonEmpty);
            this.Controls.Add(this.buttonFirstNode);
            this.Controls.Add(this.buttonDeleteList);
            this.Controls.Add(this.buttonShowList);
            this.Controls.Add(this.buttonAddNode);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblInfo);
            this.Name = "MainForm";
            this.Text = "Односвязный линейный список на классе(FIFO) Выполнил Долуда С.В.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonAddNode;
        private System.Windows.Forms.Button buttonShowList;
        private System.Windows.Forms.Button buttonDeleteList;
        private System.Windows.Forms.Button buttonFirstNode;
        private System.Windows.Forms.Button buttonEmpty;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button buttonExit;
    }
}

