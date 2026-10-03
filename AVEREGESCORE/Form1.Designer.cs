namespace AVEREGESCORE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtscore3 = new System.Windows.Forms.TextBox();
            this.txtscore2 = new System.Windows.Forms.TextBox();
            this.BTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblaverege = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TEST SCORE1#";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TEST SCORE 2#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "TEST SCORE 3#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "AVERAGE";
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(309, 45);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(212, 26);
            this.txtScore1.TabIndex = 4;
            // 
            // txtscore3
            // 
            this.txtscore3.Location = new System.Drawing.Point(309, 157);
            this.txtscore3.Name = "txtscore3";
            this.txtscore3.Size = new System.Drawing.Size(212, 26);
            this.txtscore3.TabIndex = 5;
            // 
            // txtscore2
            // 
            this.txtscore2.Location = new System.Drawing.Point(309, 92);
            this.txtscore2.Name = "txtscore2";
            this.txtscore2.Size = new System.Drawing.Size(212, 26);
            this.txtscore2.TabIndex = 6;
            // 
            // BTN
            // 
            this.BTN.Location = new System.Drawing.Point(417, 412);
            this.BTN.Name = "BTN";
            this.BTN.Size = new System.Drawing.Size(166, 84);
            this.BTN.TabIndex = 7;
            this.BTN.Text = "CLEAR";
            this.BTN.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 84);
            this.button2.TabIndex = 8;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(80, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 141);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AVERAGE CALCULATE";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblaverege
            // 
            this.lblaverege.Location = new System.Drawing.Point(278, 231);
            this.lblaverege.Name = "lblaverege";
            this.lblaverege.Size = new System.Drawing.Size(220, 26);
            this.lblaverege.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 519);
            this.Controls.Add(this.lblaverege);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTN);
            this.Controls.Add(this.txtscore2);
            this.Controls.Add(this.txtscore3);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtscore3;
        private System.Windows.Forms.TextBox txtscore2;
        private System.Windows.Forms.Button BTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lblaverege;
    }
}

