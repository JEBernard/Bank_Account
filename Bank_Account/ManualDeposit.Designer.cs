namespace Bank_Account
{
    partial class ManualDeposit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDepositSavings = new System.Windows.Forms.TextBox();
            this.txtDepositChecking = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDepositOk = new System.Windows.Forms.Button();
            this.btnDepositClose = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDepositSavings);
            this.groupBox1.Controls.Add(this.txtDepositChecking);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deposit";
            // 
            // txtDepositSavings
            // 
            this.txtDepositSavings.Location = new System.Drawing.Point(100, 92);
            this.txtDepositSavings.Name = "txtDepositSavings";
            this.txtDepositSavings.Size = new System.Drawing.Size(140, 20);
            this.txtDepositSavings.TabIndex = 3;
            // 
            // txtDepositChecking
            // 
            this.txtDepositChecking.Location = new System.Drawing.Point(100, 35);
            this.txtDepositChecking.Name = "txtDepositChecking";
            this.txtDepositChecking.Size = new System.Drawing.Size(140, 20);
            this.txtDepositChecking.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Savings:";
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
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter the amount to deposit below: ";
            // 
            // btnDepositOk
            // 
            this.btnDepositOk.Location = new System.Drawing.Point(184, 222);
            this.btnDepositOk.Name = "btnDepositOk";
            this.btnDepositOk.Size = new System.Drawing.Size(88, 27);
            this.btnDepositOk.TabIndex = 2;
            this.btnDepositOk.Text = "&Ok";
            this.btnDepositOk.UseVisualStyleBackColor = true;
            this.btnDepositOk.Click += new System.EventHandler(this.btnDepositOk_Click);
            // 
            // btnDepositClose
            // 
            this.btnDepositClose.Location = new System.Drawing.Point(12, 222);
            this.btnDepositClose.Name = "btnDepositClose";
            this.btnDepositClose.Size = new System.Drawing.Size(88, 27);
            this.btnDepositClose.TabIndex = 3;
            this.btnDepositClose.Text = "&Close";
            this.btnDepositClose.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 252);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // ManualDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 274);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDepositClose);
            this.Controls.Add(this.btnDepositOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ManualDeposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.ManualDeposit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDepositSavings;
        private System.Windows.Forms.TextBox txtDepositChecking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDepositOk;
        private System.Windows.Forms.Button btnDepositClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}