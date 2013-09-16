namespace PhoneCompany
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
            this.lb_Calls = new System.Windows.Forms.ListBox();
            this.lb_HandledCalls = new System.Windows.Forms.ListBox();
            this.lb_ErrorLog = new System.Windows.Forms.ListBox();
            this.grbx_GeneratedCalls = new System.Windows.Forms.GroupBox();
            this.grbx_HandledCalls = new System.Windows.Forms.GroupBox();
            this.grbx_ErrorLog = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.callToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbx_GeneratedCalls.SuspendLayout();
            this.grbx_HandledCalls.SuspendLayout();
            this.grbx_ErrorLog.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Calls
            // 
            this.lb_Calls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Calls.FormattingEnabled = true;
            this.lb_Calls.Location = new System.Drawing.Point(6, 19);
            this.lb_Calls.Name = "lb_Calls";
            this.lb_Calls.Size = new System.Drawing.Size(752, 199);
            this.lb_Calls.TabIndex = 0;
            // 
            // lb_HandledCalls
            // 
            this.lb_HandledCalls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_HandledCalls.FormattingEnabled = true;
            this.lb_HandledCalls.Location = new System.Drawing.Point(6, 19);
            this.lb_HandledCalls.Name = "lb_HandledCalls";
            this.lb_HandledCalls.Size = new System.Drawing.Size(387, 173);
            this.lb_HandledCalls.TabIndex = 1;
            // 
            // lb_ErrorLog
            // 
            this.lb_ErrorLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ErrorLog.FormattingEnabled = true;
            this.lb_ErrorLog.Location = new System.Drawing.Point(6, 19);
            this.lb_ErrorLog.Name = "lb_ErrorLog";
            this.lb_ErrorLog.Size = new System.Drawing.Size(345, 173);
            this.lb_ErrorLog.TabIndex = 2;
            // 
            // grbx_GeneratedCalls
            // 
            this.grbx_GeneratedCalls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbx_GeneratedCalls.Controls.Add(this.lb_Calls);
            this.grbx_GeneratedCalls.Location = new System.Drawing.Point(12, 37);
            this.grbx_GeneratedCalls.Name = "grbx_GeneratedCalls";
            this.grbx_GeneratedCalls.Size = new System.Drawing.Size(764, 232);
            this.grbx_GeneratedCalls.TabIndex = 3;
            this.grbx_GeneratedCalls.TabStop = false;
            this.grbx_GeneratedCalls.Text = "Generated calls";
            // 
            // grbx_HandledCalls
            // 
            this.grbx_HandledCalls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbx_HandledCalls.Controls.Add(this.lb_HandledCalls);
            this.grbx_HandledCalls.Location = new System.Drawing.Point(12, 287);
            this.grbx_HandledCalls.Name = "grbx_HandledCalls";
            this.grbx_HandledCalls.Size = new System.Drawing.Size(401, 203);
            this.grbx_HandledCalls.TabIndex = 4;
            this.grbx_HandledCalls.TabStop = false;
            this.grbx_HandledCalls.Text = "Handled calls";
            // 
            // grbx_ErrorLog
            // 
            this.grbx_ErrorLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grbx_ErrorLog.Controls.Add(this.lb_ErrorLog);
            this.grbx_ErrorLog.Location = new System.Drawing.Point(419, 287);
            this.grbx_ErrorLog.Name = "grbx_ErrorLog";
            this.grbx_ErrorLog.Size = new System.Drawing.Size(357, 203);
            this.grbx_ErrorLog.TabIndex = 5;
            this.grbx_ErrorLog.TabStop = false;
            this.grbx_ErrorLog.Text = "Error Log";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.отчетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // callToolStripMenuItem
            // 
            this.callToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.callToolStripMenuItem.Name = "callToolStripMenuItem";
            this.callToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.callToolStripMenuItem.Text = "Call";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетToolStripMenuItem.Text = "Отчет";
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 532);
            this.Controls.Add(this.grbx_ErrorLog);
            this.Controls.Add(this.grbx_HandledCalls);
            this.Controls.Add(this.grbx_GeneratedCalls);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "PhoneCompany (developed by Doluda.S.V.)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.grbx_GeneratedCalls.ResumeLayout(false);
            this.grbx_HandledCalls.ResumeLayout(false);
            this.grbx_ErrorLog.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Calls;
        private System.Windows.Forms.ListBox lb_HandledCalls;
        private System.Windows.Forms.ListBox lb_ErrorLog;
        private System.Windows.Forms.GroupBox grbx_GeneratedCalls;
        private System.Windows.Forms.GroupBox grbx_HandledCalls;
        private System.Windows.Forms.GroupBox grbx_ErrorLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem callToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
    }
}

