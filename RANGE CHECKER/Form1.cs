using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RANGE_CHECKER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            int number;

            if (int.TryParse(txtcheck. Text, out number))
            {
                if (number < 15)
                {
                    txtdecision.Text = "Number is less than 15";
                }
                else if (number == 15)
                {
                    txtdecision.Text = "Number is equal to 15";
                }
                else
                {
                    txtdecision.Text = "Number is greater than 15";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

            {
                txtcheck.Focus();
                txtdecision.Focus();
                txtclear.Focus();
            }
        }

        private void txtdecision_Click(object sender, EventArgs e)
        {
            int number;

            if (int.TryParse(txtcheck.Text, out number))
            {
                if (number < 15)
                {
                    txtdecision.Text = "Number is less than 15";
                }
                else if (number == 15)
                {
                    txtdecision.Text = "Number is equal to 15";
                }
                else
                {
                    txtdecision.Text = "Number is greater than 15";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }


        }
        
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
        

        

