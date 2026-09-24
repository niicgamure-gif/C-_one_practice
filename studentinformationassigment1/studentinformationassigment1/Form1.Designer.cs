namespace studentinformationassigment1
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
            this.components = new System.ComponentModel.Container();
            this.lblstudentname = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.lboutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblstudentname
            // 
            this.lblstudentname.AutoSize = true;
            this.lblstudentname.Location = new System.Drawing.Point(258, 87);
            this.lblstudentname.Name = "lblstudentname";
            this.lblstudentname.Size = new System.Drawing.Size(175, 20);
            this.lblstudentname.TabIndex = 0;
            this.lblstudentname.Text = "enter the student name";
            this.lblstudentname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.Location = new System.Drawing.Point(258, 159);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(147, 20);
            this.lblstudentid.TabIndex = 1;
            this.lblstudentid.Text = "enter the student id";
            this.lblstudentid.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(258, 219);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(159, 20);
            this.lbldepartment.TabIndex = 2;
            this.lbldepartment.Text = "enter the department";
            // 
            // lblsemester
            // 
            this.lblsemester.AutoSize = true;
            this.lblsemester.Location = new System.Drawing.Point(258, 278);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(143, 20);
            this.lblsemester.TabIndex = 3;
            this.lblsemester.Text = "enter the semester";
            this.lblsemester.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.Location = new System.Drawing.Point(147, 541);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(285, 69);
            this.btnshowinfo.TabIndex = 9;
            this.btnshowinfo.Text = "show information";
            this.btnshowinfo.UseVisualStyleBackColor = true;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(463, 541);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(170, 69);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnexit.Location = new System.Drawing.Point(673, 541);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(170, 69);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.clear_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(569, 89);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(235, 26);
            this.txtname.TabIndex = 13;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(569, 153);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(235, 26);
            this.txtstudentid.TabIndex = 14;
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(569, 213);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(235, 26);
            this.txtdepartment.TabIndex = 15;
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(569, 272);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(235, 26);
            this.txtsemester.TabIndex = 16;
            // 
            // lboutput
            // 
            this.lboutput.Location = new System.Drawing.Point(120, 379);
            this.lboutput.Name = "lboutput";
            this.lboutput.Size = new System.Drawing.Size(778, 124);
            this.lboutput.TabIndex = 17;
            this.lboutput.UseVisualStyleBackColor = true;
            this.lboutput.Click += new System.EventHandler(this.lboutput_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 642);
            this.Controls.Add(this.lboutput);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.lblstudentname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstudentname;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.Button lboutput;
    }
}

