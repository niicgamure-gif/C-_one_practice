using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homme_assigment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void blshow_Click(object sender, EventArgs e)
        {
            //creating a variable
            string dayof_week, name_of_month, numeric_day, year, full_date;
            // initial values to variable
            dayof_week = txtdayoftheweek .Text;
            name_of_month = txtdayofthemonth.Text;
            numeric_day = txtofnumeric.Text;
            year = txtyear.Text;
            //stage process-connection of full data
            full_date = dayof_week + " " + name_of_month + " " + numeric_day + "" + year;


        }

        private void blclear_Click(object sender, EventArgs e)
        {
            //clearing textbox and lebel
            //clearing textbox
            txtdayoftheweek.Clear();
            txtdayofthemonth.Clear();
            txtofnumeric.Clear();
            txtyear.Clear();


            // clearing lebel not used clear fuction
            lbloutput.Text = " ";
        }

        private void blexit_Click(object sender, EventArgs e)
        {
            // free close using this keyword and close  fuction
            this.Close();
        }

        private void txtdayofthemonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdayoftheweek_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtyear_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbloutput_Click(object sender, EventArgs e)
        {
            //create variables
            string dayofweak, nameofmonth, fulldate, numericday, year;

            // initial value of variable
            dayofweak = txtdayoftheweek.Text;
            nameofmonth = txtdayofthemonth.Text;
            numericday = txtyear.Text;
            year = txtyear.Text;
            int.Parse(txtdayofthemonth.Text);
            int.Parse(txtyear.Text);

            // storage process connection of full data
            fulldate = dayofweak + "" + nameofmonth + "" + numericday + "" + year;
            lbloutput.Text = fulldate;

        }
    }
}
