namespace RANGE_CHECKER
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
            this.txtcheck = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdecision = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcheck
            // 
            this.txtcheck.AutoSize = true;
            this.txtcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcheck.Location = new System.Drawing.Point(113, 33);
            this.txtcheck.Name = "txtcheck";
            this.txtcheck.Size = new System.Drawing.Size(346, 25);
            this.txtcheck.TabIndex = 0;
            this.txtcheck.Text = "RANGE CHECKER APPLICATION";
            this.txtcheck.Click += new System.EventHandler(this.txtcheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENTER AND INTEGER AND LEFT THOUGHT 15";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtdecision
            // 
            this.txtdecision.AutoSize = true;
            this.txtdecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdecision.Location = new System.Drawing.Point(236, 226);
            this.txtdecision.Name = "txtdecision";
            this.txtdecision.Size = new System.Drawing.Size(196, 25);
            this.txtdecision.TabIndex = 2;
            this.txtdecision.Text = "RANGE DECISION";
            this.txtdecision.Click += new System.EventHandler(this.txtdecision_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 26);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(54, 280);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(608, 26);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 131);
            this.button1.TabIndex = 5;
            this.button1.Text = "check qualification";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtclear
            // 
            this.txtclear.Location = new System.Drawing.Point(365, 474);
            this.txtclear.Name = "txtclear";
            this.txtclear.Size = new System.Drawing.Size(162, 83);
            this.txtclear.TabIndex = 6;
            this.txtclear.Text = "clear";
            this.txtclear.UseVisualStyleBackColor = true;
            this.txtclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(533, 476);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(151, 78);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 619);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtclear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtdecision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcheck);
            this.Name = "Form1";
            this.Text = "range checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtcheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtdecision;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtclear;
        private System.Windows.Forms.Button btnexit;
    }
}

