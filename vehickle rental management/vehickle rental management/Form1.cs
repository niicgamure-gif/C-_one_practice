using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vehickle_rental_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        {
            txtName.Clear();
            txtAge.Clear();
            txtDays.Clear();
            txtExperience.Clear();

            listBox1.Items.Clear();

            rdoEconomy.Checked = false;
            rdoSUV.Checked = false;
            rdoLuxury.Checked = false;

            chkInsurance.Checked = false;
        }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            
        {
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            int days = int.Parse(txtDays.Text);
            int experience = int.Parse(txtExperience.Text);

            double rate = 0;

            if (rdoEconomy.Checked)
                rate = 30;
            else if (rdoSUV.Checked)
                rate = 50;
            else if (rdoLuxury.Checked)
                rate = 100;

            double insurance = 0;

            if (chkInsurance.Checked)
                insurance = days * 15;

            double rentalCost = days * rate;
            double totalCost = rentalCost + insurance;

            listBox1.Items.Clear();
            listBox1.Items.Add("Customer Name : " + name);
            listBox1.Items.Add("Customer Age : " + age);
            listBox1.Items.Add("Rental Days : " + days);
            listBox1.Items.Add("Driving Experience : " + experience);
            listBox1.Items.Add("Vehicle Cost : $" + rentalCost);
            listBox1.Items.Add("Insurance : $" + insurance);
            listBox1.Items.Add("Total Cost : $" + totalCost);
        }
    }

        private void btnexit_Click(object sender, EventArgs e)
        {
           
        {
            Application.Exit();
        }
    }
    }
}
