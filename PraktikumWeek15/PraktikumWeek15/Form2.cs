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
            if (checkBoxDiscount.Checked == true)
            {
                discount = diskon/100 * Form1.subtotal;
            }
            label6.Text = discount.ToString();
            label8.Text = Convert.ToString(Form1.subtotal + Form1.tax - discount);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxDiscount_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
