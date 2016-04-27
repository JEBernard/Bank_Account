namespace Bank_Account
{
    partial class frmDirectDeposit
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDepositClose = new System.Windows.Forms.Button();
            this.btnDepositOk = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDirectChecking = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDepositChecking = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btnDepositClose
            // 
            this.btnDepositClose.Location = new System.Drawing.Point(12, 209);
            this.btnDepositClose.Name = "btnDepositClose";
            this.btnDepositClose.Size = new System.Drawing.Size(88, 27);
            this.btnDepositClose.TabIndex = 10;
            this.btnDepositClose.Text = "&Close";
            this.btnDepositClose.UseVisualStyleBackColor = true;
            this.btnDepositClose.Click += new System.EventHandler(this.btnDepositClose_Click);
            // 
            // btnDepositOk
            // 
            this.btnDepositOk.Location = new System.Drawing.Point(184, 209);
            this.btnDepositOk.Name = "btnDepositOk";
            this.btnDepositOk.Size = new System.Drawing.Size(88, 27);
            this.btnDepositOk.TabIndex = 9;
            this.btnDepositOk.Text = "&Ok";
            this.btnDepositOk.UseVisualStyleBackColor = true;
            this.btnDepositOk.Click += new System.EventHandler(this.btnDepositOk_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Please enter the amount for direct deposit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDirectChecking);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 114);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deposit";
            // 
            // txtDirectChecking
            // 
            this.txtDirectChecking.Location = new System.Drawing.Point(100, 35);
            this.txtDirectChecking.Name = "txtDirectChecking";
            this.txtDirectChecking.Size = new System.Drawing.Size(140, 20);
            this.txtDirectChecking.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Checking:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDepositChecking);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 149);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deposit";
            // 
            // txtDepositChecking
            // 
            this.txtDepositChecking.Location = new System.Drawing.Point(100, 35);
            this.txtDepositChecking.Name = "txtDepositChecking";
            this.txtDepositChecking.Size = new System.Drawing.Size(140, 20);
            this.txtDepositChecking.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Checking:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please enter the amount to deposit below: ";
            // 
            // frmDirectDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDepositClose);
            this.Controls.Add(this.btnDepositOk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDirectDeposit";
            this.Text = "Direct Deposit";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnDepositClose;
        private System.Windows.Forms.Button btnDepositOk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDirectChecking;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDepositChecking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}