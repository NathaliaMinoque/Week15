using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static int discount = 0;
        
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int diskon = Convert.ToInt32(textBox1.Text);
            label2.Text = Form1.subtotal.ToString();
            label4.Text = Form1.tax.ToString();
            discount = diskon * Form1.subtotal / 100;         
            label6.Text = discount.ToString();
            int total = Form1.subtotal + Form1.tax - discount;
            label8.Text = total.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDiscount.Checked == true)
            {
                textBox1.Visible = true;
                label9.Visible = true;
            }
        }
    }
}
