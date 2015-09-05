using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class Form1 : Form
    {
     
        double interest;
        double intrst;
     
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "")
            {
                intrst = Convert.ToSingle(textBox1.Text) * Convert.ToSingle(textBox2.Text) * Convert.ToSingle(textBox3.Text);
                interest = (intrst / 100);
                this.textBox4.Text = interest.ToString();
            }
            else
            {
                MessageBox.Show("please enter the value");
            } 
             

        }
      
        private void btn_cncl_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close(); 
        } 
    
    }
}
