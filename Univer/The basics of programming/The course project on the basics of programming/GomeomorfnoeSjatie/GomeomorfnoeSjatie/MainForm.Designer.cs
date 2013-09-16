namespace GomeomorfnoeSjatie
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSjatie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(295, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSjatie
            // 
            this.buttonSjatie.Location = new System.Drawing.Point(436, 64);
            this.buttonSjatie.Name = "buttonSjatie";
            this.buttonSjatie.Size = new System.Drawing.Size(75, 23);
            this.buttonSjatie.TabIndex = 1;
            this.buttonSjatie.Text = "Сжать";
            this.buttonSjatie.UseVisualStyleBackColor = true;
            this.buttonSjatie.Click += new System.EventHandler(this.buttonSjatie_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 262);
            this.Controls.Add(this.buttonSjatie);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Тест гомеоморфного сжатия графа";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSjatie;
    }
}

