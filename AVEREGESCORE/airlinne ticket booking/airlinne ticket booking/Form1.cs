using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airlinne_ticket_booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
       
        {
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            int tickets = int.Parse(txtTickets.Text);
            double baggage = double.Parse(txtBaggage.Text);

            double ticketPrice = 0;

            // Travel Class
            if (rdoFirstClass.Checked)
                ticketPrice = 200;
            else if (rdoBusinessClass.Checked)
                ticketPrice = 150;
            else if (rdoNormalClass.Checked)
                ticketPrice = 100;

            double total = ticketPrice * tickets;

            // Insurance
            if (chkInsurance.Checked)
                total += tickets * 25;

            // Extra baggage charge
            if (baggage > 20)
                total += (baggage - 20) * 5;

            listBox1.Items.Clear();
            listBox1.Items.Add("Passenger Name: " + name);
            listBox1.Items.Add("Age: " + age);
            listBox1.Items.Add("Tickets: " + tickets);
            listBox1.Items.Add("Baggage: " + baggage + " KG");
            listBox1.Items.Add("Total Cost: $" + total);
        }


        private void btnclear_Click(object sender, EventArgs e)
        {

            {
                txtName.Clear();
                txtAge.Clear();
                txtTickets.Clear();
                txtBaggage.Clear();

                rdoFirstClass.Checked = false;
                rdoBusinessClass.Checked = false;
                rdoNormalClass.Checked = false;

                chkInsurance.Checked = false;

                listBox1.Items.Clear();
            }
        }
        

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
