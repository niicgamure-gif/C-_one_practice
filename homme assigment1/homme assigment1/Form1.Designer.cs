namespace homme_assigment1
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
            this.txtdayoftheweek = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtofnumeric = new System.Windows.Forms.TextBox();
            this.txtdayofthemonth = new System.Windows.Forms.TextBox();
            this.lbloutput = new System.Windows.Forms.Button();
            this.blshow = new System.Windows.Forms.Button();
            this.blexit = new System.Windows.Forms.Button();
            this.blclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the day the week";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the name of the month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter the numeric day of the month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ENTER THE YEAR";
            // 
            // txtdayoftheweek
            // 
            this.txtdayoftheweek.Location = new System.Drawing.Point(701, 85);
            this.txtdayoftheweek.Name = "txtdayoftheweek";
            this.txtdayoftheweek.Size = new System.Drawing.Size(288, 26);
            this.txtdayoftheweek.TabIndex = 4;
            this.txtdayoftheweek.Text = "sabti";
            this.txtdayoftheweek.TextChanged += new System.EventHandler(this.txtdayoftheweek_TextChanged);
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(701, 252);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(288, 26);
            this.txtyear.TabIndex = 5;
            this.txtyear.Text = "2026";
            this.txtyear.TextChanged += new System.EventHandler(this.txtyear_TextChanged);
            // 
            // txtofnumeric
            // 
            this.txtofnumeric.Location = new System.Drawing.Point(701, 181);
            this.txtofnumeric.Name = "txtofnumeric";
            this.txtofnumeric.Size = new System.Drawing.Size(288, 26);
            this.txtofnumeric.TabIndex = 6;
            this.txtofnumeric.Text = "6";
            // 
            // txtdayofthemonth
            // 
            this.txtdayofthemonth.Location = new System.Drawing.Point(701, 135);
            this.txtdayofthemonth.Name = "txtdayofthemonth";
            this.txtdayofthemonth.Size = new System.Drawing.Size(288, 26);
            this.txtdayofthemonth.TabIndex = 7;
            this.txtdayofthemonth.Text = "juun";
            this.txtdayofthemonth.TextChanged += new System.EventHandler(this.txtdayofthemonth_TextChanged);
            // 
            // lbloutput
            // 
            this.lbloutput.Location = new System.Drawing.Point(190, 347);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(730, 107);
            this.lbloutput.TabIndex = 8;
            this.lbloutput.UseVisualStyleBackColor = true;
            this.lbloutput.Click += new System.EventHandler(this.lbloutput_Click);
            // 
            // blshow
            // 
            this.blshow.Location = new System.Drawing.Point(255, 485);
            this.blshow.Name = "blshow";
            this.blshow.Size = new System.Drawing.Size(121, 65);
            this.blshow.TabIndex = 9;
            this.blshow.Text = "show date";
            this.blshow.UseVisualStyleBackColor = true;
            this.blshow.Click += new System.EventHandler(this.blshow_Click);
            // 
            // blexit
            // 
            this.blexit.Location = new System.Drawing.Point(701, 485);
            this.blexit.Name = "blexit";
            this.blexit.Size = new System.Drawing.Size(121, 65);
            this.blexit.TabIndex = 10;
            this.blexit.Text = "close";
            this.blexit.UseVisualStyleBackColor = true;
            this.blexit.Click += new System.EventHandler(this.blexit_Click);
            // 
            // blclear
            // 
            this.blclear.Location = new System.Drawing.Point(476, 485);
            this.blclear.Name = "blclear";
            this.blclear.Size = new System.Drawing.Size(121, 65);
            this.blclear.TabIndex = 11;
            this.blclear.Text = "clear";
            this.blclear.UseVisualStyleBackColor = true;
            this.blclear.Click += new System.EventHandler(this.blclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 584);
            this.Controls.Add(this.blclear);
            this.Controls.Add(this.blexit);
            this.Controls.Add(this.blshow);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.txtdayofthemonth);
            this.Controls.Add(this.txtofnumeric);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtdayoftheweek);
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
        private System.Windows.Forms.TextBox txtdayoftheweek;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtofnumeric;
        private System.Windows.Forms.TextBox txtdayofthemonth;
        private System.Windows.Forms.Button lbloutput;
        private System.Windows.Forms.Button blshow;
        private System.Windows.Forms.Button blexit;
        private System.Windows.Forms.Button blclear;
    }
}

