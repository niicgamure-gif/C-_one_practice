namespace AVEREGEDISPLAYED
{
    partial class frmTestScoreAverage
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
            this.txtScore1 = new System.Windows.Forms.Label();
            this.txtScore2 = new System.Windows.Forms.Label();
            this.txtscore3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtaverage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtScore1
            // 
            this.txtScore1.AutoSize = true;
            this.txtScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore1.Location = new System.Drawing.Point(80, 64);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(239, 32);
            this.txtScore1.TabIndex = 0;
            this.txtScore1.Text = "TEST SCORE # 1";
            this.txtScore1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtScore2
            // 
            this.txtScore2.AutoSize = true;
            this.txtScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore2.Location = new System.Drawing.Point(80, 96);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(232, 32);
            this.txtScore2.TabIndex = 1;
            this.txtScore2.Text = "TEST SCORE #2";
            this.txtScore2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtscore3
            // 
            this.txtscore3.AutoSize = true;
            this.txtscore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore3.Location = new System.Drawing.Point(80, 139);
            this.txtscore3.Name = "txtscore3";
            this.txtscore3.Size = new System.Drawing.Size(232, 32);
            this.txtscore3.TabIndex = 2;
            this.txtscore3.Text = "TEST SCORE #3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 26);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(351, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(351, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(284, 26);
            this.textBox3.TabIndex = 5;
            // 
            // txtaverage
            // 
            this.txtaverage.AutoSize = true;
            this.txtaverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaverage.Location = new System.Drawing.Point(129, 240);
            this.txtaverage.Name = "txtaverage";
            this.txtaverage.Size = new System.Drawing.Size(151, 40);
            this.txtaverage.TabIndex = 6;
            this.txtaverage.Text = "Average";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(318, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "18.7";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtclear
            // 
            this.txtclear.Location = new System.Drawing.Point(521, 385);
            this.txtclear.Name = "txtclear";
            this.txtclear.Size = new System.Drawing.Size(141, 55);
            this.txtclear.TabIndex = 8;
            this.txtclear.Text = "clear";
            this.txtclear.UseVisualStyleBackColor = true;
            this.txtclear.Click += new System.EventHandler(this.btnclear_Click_1);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(521, 446);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(141, 54);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(111, 369);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(345, 149);
            this.button4.TabIndex = 10;
            this.button4.Text = "calculate average ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmTestScoreAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 530);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtclear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtaverage);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtscore3);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore1);
            this.Name = "frmTestScoreAverage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScore1;
        private System.Windows.Forms.Label txtScore2;
        private System.Windows.Forms.Label txtscore3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtaverage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button button4;
    }
}

