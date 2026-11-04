using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiptax_and_toatal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblfood_Click(object sender, EventArgs e)
        {

        }

        private void lbltotalamount_Click(object sender, EventArgs e)
        {

        }

        private void lblsales_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { }
       private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                
                double price1 = Convert.ToDouble(txtnamefood1.Text);
                double price2 = Convert.ToDouble(txtpricefood1.Text);

             
                double subtotal = price1 + price2;

               
                double taxRate = 0.05;
                double salesTax = subtotal * taxRate;

              
                double totalAmount = subtotal + salesTax;

                
                txtsales.Text = salesTax.ToString("C2");     
                texttotalamount.Text = totalAmount.ToString("C2");
            }
            { }
            
            
            

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

