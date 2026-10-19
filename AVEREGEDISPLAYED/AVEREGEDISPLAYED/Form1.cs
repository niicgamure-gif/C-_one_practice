using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AVEREGEDISPLAYED
{
    public partial class frmTestScoreAverage : Form
    {
        public frmTestScoreAverage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {


        }

        private void txtScore1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)


        { }





        private void label1_Click_1(object sender, EventArgs e)
        {
            double score1 = Convert.ToDouble(textBox1.Text);
            double score2 = Convert.ToDouble(textBox2.Text);
            double score3 = Convert.ToDouble(textBox3.Text);

            double average = (score1 + score2 + score3) / 3;


        }

    

        private void btnclear_Click_1(object sender, EventArgs e)
        { }
            private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();


            textBox1.Focus();
        }

  



    }
}


   