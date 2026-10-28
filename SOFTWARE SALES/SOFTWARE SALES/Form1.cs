using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SOFTWARE_SALES
{
    public partial class Form1 : Form
    {
        private readonly int discountRate;
        private object subtotal;
        private object discount;
        private object total;
        private double subTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NumberOfPackages;
            double PricePerPackage;

            if (int.TryParse(txtnumberofbackage.Text, out NumberOfPackages) && double.TryParse(txtprice.Text, out PricePerPackage))
            {
                NumberOfPackages = int.Parse(txtnumberofbackage.Text);
                PricePerPackage = double.Parse(txtprice.Text);

                //subtotal Before Discount
                double SubTotal;

                SubTotal = NumberOfPackages * PricePerPackage;

                //Discount Rate
                double discountRate = 0;

                //Discount Amount
                double discountAmount = 0;

                // calculating discount
                if (NumberOfPackages >= 10 && NumberOfPackages <= 19)
                {
                    discountAmount = SubTotal * 0.2;
                    discountRate = 20;
                }
                else if (NumberOfPackages >= 20 && NumberOfPackages <= 49)
                {
                    discountAmount = SubTotal * 0.3;
                    discountRate = 30;
                }
                else if (NumberOfPackages >= 50 && NumberOfPackages <= 99)
                {
                    discountAmount = SubTotal * 0.4;
                    discountRate = 40;
                }
                else if (NumberOfPackages >= 100)
                {
                    discountAmount = SubTotal * 0.5;
                    discountRate = 50;
                }



                double total;
                total = subTotal - discountAmount;

                listBox1.Items.Clear();

                listBox1.Items.Add("Software Sales Results");
                listBox1.Items.Add("Number of Packages: " + txtnumberofbackages);
                listBox1.Items.Add("Price per package: $" + txtprice.ToString());

                listBox1.Items.Add("Subtotal Before Discount: $" + subtotal.ToString());
                listBox1.Items.Add("Discount Rate: " + (discountRate * 100) + "%");
                listBox1.Items.Add("Discount Amount: $" + discount.ToString());
                listBox1.Items.Add("Total Amount (After Discount): $" + total.ToString());
            }
        }

       

       



      
          

       
        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void btncalculate_Click(object sender, EventArgs e)
        {
            try

            {
                int packages;
                double price;

                if (!int.TryParse(txtnumberofbackage.Text, out packages) ||
                    !double.TryParse(txtnumberofbackage.Text, out price) ||
                    packages <= 0 || price <= 0)
                {
                    MessageBox.Show("Please enter correct values");
                    return;
                }

                double subtotal = packages * price;
                double discountRate;

                if (packages >= 100)
                    discountRate = 0.50;
                else if (packages >= 50)
                    discountRate = 0.40;
                else if (packages >= 20)
                    discountRate = 0.30;
                else if (packages >= 10)
                    discountRate = 0.20;
                else
                    discountRate = 0.0;

                double discount = subtotal * discountRate;
                double total = subtotal - discount;

                listBox1.Items.Clear();
                listBox1.Items.Add("Purchase Results");
                listBox1.Items.Add("Number of Packages: " + packages);
                listBox1.Items.Add("Price per Package: " + price.ToString("C2"));
                listBox1.Items.Add("Subtotal: " + subtotal.ToString("C2"));
                listBox1.Items.Add("Discount Rate: " + (discountRate * 100) + "%");
                listBox1.Items.Add("Discount Amount: " + discount.ToString("C2"));
                listBox1.Items.Add("Total Amount: " + total.ToString("C2"));

            }
            catch (Exception ex)
            {
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtnumberofbackage.Clear();
            txtprice.Clear();
            listBox1.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
            














     
      
    

