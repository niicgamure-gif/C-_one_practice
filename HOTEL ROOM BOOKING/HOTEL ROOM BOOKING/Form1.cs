using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_ROOM_BOOKING
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

        private void button3_Click(object sender, EventArgs e)
        {
          
        {
            Application.Exit();
        }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
        {
            string guestName = txtName.Text;
            int age = int.Parse(txtAge.Text);
            int nights = int.Parse(txtNights.Text);
            int guests = int.Parse(txtGuests.Text);

            double roomPrice = 0;

            // Room Type
            if (rdoStandard.Checked)
                roomPrice = 50;
            else if (rdoNormal.Checked)
                roomPrice = 80;
            else if (rdoHigh.Checked)
                roomPrice = 120;

            double roomCost = roomPrice * nights;

            // Breakfast Option
            double breakfastCost = 0;
            if (chkBreakfast.Checked)
                breakfastCost = 10 * guests * nights;

            double totalCost = roomCost + breakfastCost;

            // Display Result
            listBox1.Items.Clear();
            listBox1.Items.Add("HOTEL BOOKING DETAILS");
            listBox1.Items.Add("----------------------");
            listBox1.Items.Add("Guest Name: " + guestName);
            listBox1.Items.Add("Age: " + age);
            listBox1.Items.Add("Number of Nights: " + nights);
            listBox1.Items.Add("Number of Guests: " + guests);

            if (rdoStandard.Checked)
                listBox1.Items.Add("Room Type: Standard");
            else if (rdoNormal.Checked)
                listBox1.Items.Add("Room Type: Normal");
            else if (rdoHigh.Checked)
                listBox1.Items.Add("Room Type: High");

            listBox1.Items.Add("Breakfast: " + (chkBreakfast.Checked ? "Yes" : "No"));
            listBox1.Items.Add("Total Cost: $" + totalCost);
        }

    }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        {
            txtName.Clear();
            txtAge.Clear();
            txtNights.Clear();
            txtGuests.Clear();

            rdoStandard.Checked = false;
            rdoNormal.Checked = false;
            rdoHigh.Checked = false;

            chkBreakfast.Checked = false;

            listBox1.Items.Clear();
        }
    }
    }
}
