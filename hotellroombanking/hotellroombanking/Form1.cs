using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotellroombanking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        { }
            private void btnCalculate_Click(object sender, EventArgs e)
        {


            int nights = int.Parse(txtnights.Text);
            double pricePerNight = double.Parse(txtpricenight.Text);

            double subtotal = nights * pricePerNight;

            double serviceTax = subtotal * 0.10;   // 10%
            double discount = subtotal * 0.05;     // 5%

            double totalAmount = subtotal + serviceTax - discount;

            lblServiceTax.Text = "$" + serviceTax.ToString("F2");
            lbldiscount.Text = "$" + discount.ToString("F2");
            lbltotalamount.Text = "$" + totalAmount.ToString("F2");
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    }

