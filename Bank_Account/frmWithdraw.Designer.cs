namespace Bank_Account
{
    partial class frmWithdraw
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
            this.btnWithdrawClose = new System.Windows.Forms.Button();
            this.btnWithdrawOK = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboWithdraw = new System.Windows.Forms.ComboBox();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWithdrawClose
            // 
            this.btnWithdrawClose.Location = new System.Drawing.Point(12, 215);
            this.btnWithdrawClose.Name = "btnWithdrawClose";
            this.btnWithdrawClose.Size = new System.Drawing.Size(88, 27);
            this.btnWithdrawClose.TabIndex = 7;
            this.btnWithdrawClose.Text = "&Close";
            this.btnWithdrawClose.UseVisualStyleBackColor = true;
            this.btnWithdrawClose.Click += new System.EventHandler(this.btnWithdrawClose_Click);
            // 
            // btnWithdrawOK
            // 
            this.btnWithdrawOK.Location = new System.Drawing.Point(227, 215);
            this.btnWithdrawOK.Name = "btnWithdrawOK";
            this.btnWithdrawOK.Size = new System.Drawing.Size(88, 27);
            this.btnWithdrawOK.TabIndex = 6;
            this.btnWithdrawOK.Text = "&Ok";
            this.btnWithdrawOK.UseVisualStyleBackColor = true;
            this.btnWithdrawOK.Click += new System.EventHandler(this.btnWithdrawOK_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(24, 18);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(213, 13);
            this.lblMain.TabIndex = 5;
            this.lblMain.Text = "Please enter the amount to withdraw below:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboWithdraw);
            this.groupBox1.Controls.Add(this.txtWithdraw);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 110);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Withdraw";
            // 
            // cboWithdraw
            // 
            this.cboWithdraw.FormattingEnabled = true;
            this.cboWithdraw.Items.AddRange(new object[] {
            "Checking",
            "Savings"});
            this.cboWithdraw.Location = new System.Drawing.Point(15, 42);
            this.cboWithdraw.Name = "cboWithdraw";
            this.cboWithdraw.Size = new System.Drawing.Size(121, 21);
            this.cboWithdraw.TabIndex = 3;
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(157, 43);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(140, 20);
            this.txtWithdraw.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 250);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(327, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // frmWithdraw
            // 
            this.AcceptButton = this.btnWithdrawOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 272);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnWithdrawClose);
            this.Controls.Add(this.btnWithdrawOK);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWithdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.frmWithdraw_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithdrawClose;
        private System.Windows.Forms.Button btnWithdrawOK;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.ComboBox cboWithdraw;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}