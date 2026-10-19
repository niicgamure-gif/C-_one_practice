namespace vehickle_rental_management
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lbldays = new System.Windows.Forms.Label();
            this.lblyears = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rdoEconomy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoSUV = new System.Windows.Forms.RadioButton();
            this.rdoLuxury = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(101, 18);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(167, 21);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "enter customer name";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(101, 55);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(154, 21);
            this.lblage.TabIndex = 1;
            this.lblage.Text = "enter customer age";
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldays.Location = new System.Drawing.Point(77, 95);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(178, 21);
            this.lbldays.TabIndex = 2;
            this.lbldays.Text = " number rental of days";
            // 
            // lblyears
            // 
            this.lblyears.AutoSize = true;
            this.lblyears.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyears.Location = new System.Drawing.Point(77, 131);
            this.lblyears.Name = "lblyears";
            this.lblyears.Size = new System.Drawing.Size(215, 21);
            this.lblyears.TabIndex = 3;
            this.lblyears.Text = " years of driving experience";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(304, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(276, 29);
            this.txtName.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(304, 53);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(276, 29);
            this.txtAge.TabIndex = 7;
            // 
            // txtDays
            // 
            this.txtDays.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDays.Location = new System.Drawing.Point(304, 92);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(276, 29);
            this.txtDays.TabIndex = 8;
            // 
            // txtExperience
            // 
            this.txtExperience.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExperience.Location = new System.Drawing.Point(304, 128);
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.Size = new System.Drawing.Size(276, 29);
            this.txtExperience.TabIndex = 9;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnclear.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Black;
            this.btnclear.Location = new System.Drawing.Point(263, 577);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(176, 57);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnexit.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(493, 577);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(176, 57);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.ForeColor = System.Drawing.Color.Black;
            this.btncalculate.Location = new System.Drawing.Point(45, 577);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(176, 57);
            this.btncalculate.TabIndex = 12;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Controls.Add(this.txtExperience);
            this.groupBox1.Controls.Add(this.txtDays);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblyears);
            this.groupBox1.Controls.Add(this.lbldays);
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Location = new System.Drawing.Point(22, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 271);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(203, 768);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(208, 31);
            this.button7.TabIndex = 25;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(203, 807);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(208, 31);
            this.button10.TabIndex = 27;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(710, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 444);
            this.listBox1.TabIndex = 28;
            // 
            // rdoEconomy
            // 
            this.rdoEconomy.AutoSize = true;
            this.rdoEconomy.Location = new System.Drawing.Point(22, 408);
            this.rdoEconomy.Name = "rdoEconomy";
            this.rdoEconomy.Size = new System.Drawing.Size(98, 24);
            this.rdoEconomy.TabIndex = 29;
            this.rdoEconomy.TabStop = true;
            this.rdoEconomy.Text = "economy";
            this.rdoEconomy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "vehicle type";
            // 
            // rdoSUV
            // 
            this.rdoSUV.AutoSize = true;
            this.rdoSUV.Location = new System.Drawing.Point(155, 408);
            this.rdoSUV.Name = "rdoSUV";
            this.rdoSUV.Size = new System.Drawing.Size(58, 24);
            this.rdoSUV.TabIndex = 31;
            this.rdoSUV.TabStop = true;
            this.rdoSUV.Text = "suv";
            this.rdoSUV.UseVisualStyleBackColor = true;
            // 
            // rdoLuxury
            // 
            this.rdoLuxury.AutoSize = true;
            this.rdoLuxury.Location = new System.Drawing.Point(263, 408);
            this.rdoLuxury.Name = "rdoLuxury";
            this.rdoLuxury.Size = new System.Drawing.Size(74, 24);
            this.rdoLuxury.TabIndex = 32;
            this.rdoLuxury.TabStop = true;
            this.rdoLuxury.Text = "luxury";
            this.rdoLuxury.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "insurance option";
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(22, 512);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(226, 24);
            this.chkInsurance.TabIndex = 34;
            this.chkInsurance.Text = "add insurance (per day i5$)";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1050, 710);
            this.Controls.Add(this.chkInsurance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdoLuxury);
            this.Controls.Add(this.rdoSUV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoEconomy);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.Text = "vehickle rental management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.Label lblyears;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rdoEconomy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoSUV;
        private System.Windows.Forms.RadioButton rdoLuxury;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkInsurance;
    }
}

