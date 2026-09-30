namespace hotellroombanking
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
            this.textguestname = new System.Windows.Forms.TextBox();
            this.textroomtype = new System.Windows.Forms.TextBox();
            this.txtnights = new System.Windows.Forms.TextBox();
            this.txtpricenight = new System.Windows.Forms.TextBox();
            this.btncalculatebooking = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblServiceTax = new System.Windows.Forms.Label();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter guest name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "enter room type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "enter number of nights";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "enter price per night";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textguestname
            // 
            this.textguestname.Location = new System.Drawing.Point(490, 150);
            this.textguestname.Name = "textguestname";
            this.textguestname.Size = new System.Drawing.Size(308, 26);
            this.textguestname.TabIndex = 4;
            // 
            // textroomtype
            // 
            this.textroomtype.Location = new System.Drawing.Point(490, 198);
            this.textroomtype.Name = "textroomtype";
            this.textroomtype.Size = new System.Drawing.Size(308, 26);
            this.textroomtype.TabIndex = 5;
            // 
            // txtnights
            // 
            this.txtnights.Location = new System.Drawing.Point(490, 250);
            this.txtnights.Name = "txtnights";
            this.txtnights.Size = new System.Drawing.Size(308, 26);
            this.txtnights.TabIndex = 6;
            this.txtnights.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtpricenight
            // 
            this.txtpricenight.Location = new System.Drawing.Point(490, 312);
            this.txtpricenight.Name = "txtpricenight";
            this.txtpricenight.Size = new System.Drawing.Size(308, 26);
            this.txtpricenight.TabIndex = 7;
            // 
            // btncalculatebooking
            // 
            this.btncalculatebooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculatebooking.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncalculatebooking.Location = new System.Drawing.Point(409, 365);
            this.btncalculatebooking.Name = "btncalculatebooking";
            this.btncalculatebooking.Size = new System.Drawing.Size(244, 85);
            this.btncalculatebooking.TabIndex = 8;
            this.btncalculatebooking.Text = "calculate booking";
            this.btncalculatebooking.UseVisualStyleBackColor = true;
            this.btncalculatebooking.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "SERVICE TAX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "DISCOUNT AMOUNT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(207, 565);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "TOTAL AMOUNT";
            // 
            // lblServiceTax
            // 
            this.lblServiceTax.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblServiceTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceTax.Location = new System.Drawing.Point(485, 488);
            this.lblServiceTax.Name = "lblServiceTax";
            this.lblServiceTax.Size = new System.Drawing.Size(156, 25);
            this.lblServiceTax.TabIndex = 15;
            // 
            // lbldiscount
            // 
            this.lbldiscount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbldiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscount.Location = new System.Drawing.Point(485, 536);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(156, 25);
            this.lbldiscount.TabIndex = 16;
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbltotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.Location = new System.Drawing.Point(485, 577);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(156, 25);
            this.lbltotalamount.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(353, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(363, 37);
            this.label8.TabIndex = 18;
            this.label8.Text = "Hotel booking calculator";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 635);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.lblServiceTax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncalculatebooking);
            this.Controls.Add(this.txtpricenight);
            this.Controls.Add(this.txtnights);
            this.Controls.Add(this.textroomtype);
            this.Controls.Add(this.textguestname);
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
        private System.Windows.Forms.TextBox textguestname;
        private System.Windows.Forms.TextBox textroomtype;
        private System.Windows.Forms.TextBox txtnights;
        private System.Windows.Forms.TextBox txtpricenight;
        private System.Windows.Forms.Button btncalculatebooking;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblServiceTax;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Label label8;
    }
}

