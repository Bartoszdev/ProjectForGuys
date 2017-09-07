namespace ProjectForGuys
{
    partial class Form1
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
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joeGivesToBob = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.joeGivesCashBank = new System.Windows.Forms.Button();
            this.bobGivesCashBank = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.Location = new System.Drawing.Point(12, 31);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(68, 13);
            this.joesCashLabel.TabIndex = 0;
            this.joesCashLabel.Text = "Joe ma 50 zł";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.Location = new System.Drawing.Point(12, 68);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(76, 13);
            this.bobsCashLabel.TabIndex = 1;
            this.bobsCashLabel.Text = "Bob ma 100 zł";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(12, 109);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(82, 13);
            this.bankCashLabel.TabIndex = 2;
            this.bankCashLabel.Text = "Bank ma 100 zł";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Daj 10 zł Joemu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 58);
            this.button2.TabIndex = 4;
            this.button2.Text = "Weź 5 zł od Boba";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joeGivesToBob
            // 
            this.joeGivesToBob.Location = new System.Drawing.Point(12, 213);
            this.joeGivesToBob.Name = "joeGivesToBob";
            this.joeGivesToBob.Size = new System.Drawing.Size(108, 58);
            this.joeGivesToBob.TabIndex = 5;
            this.joeGivesToBob.Text = "Joe daje 10 zł Bobowi";
            this.joeGivesToBob.UseVisualStyleBackColor = true;
            this.joeGivesToBob.Click += new System.EventHandler(this.joeGivesToBob_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(146, 213);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(108, 58);
            this.bobGivesToJoe.TabIndex = 6;
            this.bobGivesToJoe.Text = "Bob daje 5 zł Joemu";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // joeGivesCashBank
            // 
            this.joeGivesCashBank.Location = new System.Drawing.Point(15, 290);
            this.joeGivesCashBank.Name = "joeGivesCashBank";
            this.joeGivesCashBank.Size = new System.Drawing.Size(108, 58);
            this.joeGivesCashBank.TabIndex = 7;
            this.joeGivesCashBank.Text = "Joe daje do banku 15 zł";
            this.joeGivesCashBank.UseVisualStyleBackColor = true;
            this.joeGivesCashBank.Click += new System.EventHandler(this.button3_Click);
            // 
            // bobGivesCashBank
            // 
            this.bobGivesCashBank.Location = new System.Drawing.Point(146, 290);
            this.bobGivesCashBank.Name = "bobGivesCashBank";
            this.bobGivesCashBank.Size = new System.Drawing.Size(108, 58);
            this.bobGivesCashBank.TabIndex = 8;
            this.bobGivesCashBank.Text = "Bob daje do banku 20 zł";
            this.bobGivesCashBank.UseVisualStyleBackColor = true;
            this.bobGivesCashBank.Click += new System.EventHandler(this.bobGivesCashBank_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 377);
            this.Controls.Add(this.bobGivesCashBank);
            this.Controls.Add(this.joeGivesCashBank);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeGivesToBob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joesCashLabel;
        private System.Windows.Forms.Label bobsCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button joeGivesToBob;
        private System.Windows.Forms.Button bobGivesToJoe;
        private System.Windows.Forms.Button joeGivesCashBank;
        private System.Windows.Forms.Button bobGivesCashBank;
    }
}

