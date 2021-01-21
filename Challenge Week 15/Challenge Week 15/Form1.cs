using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge_Week_15
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        public int digit = 0;
        public double hasil = 0;
        private void textBoxHitung_TextChanged(object sender, EventArgs e)
        {  
            textBoxMemory.Text = textBoxHitung.Text;
      
            textBoxHitung.Text.Replace(",", "");
            digit = textBoxHitung.Text.Length;

            if (digit == 4)
            {
                textBoxHitung.Text = textBoxHitung.Text.Insert(1, ",");
                textBoxHitung.Text.Replace(",", "");
            }
            //else if (digit == 5)
            //{
            //    textBoxHitung.Text.Replace(",", "");
            //    textBoxHitung.Text = textBoxHitung.Text.Insert(2, ",");
            //    textBoxHitung.Text.Replace(",", "");
            //}
            //else if (digit == 6)
            //{
            //    textBoxHitung.Text = textBoxHitung.Text.Insert(1, ",");
            //    textBoxHitung.Text = textBoxHitung.Text.Insert(5, ",");
            //}
            //else if (digit == 7)
            //{
            //    textBoxHitung.Text = textBoxHitung.Text.Insert(1, ",");
            //}
            //else if (digit == 8)
            //{
            //    textBoxHitung.Text = textBoxHitung.Text.Insert(1, ",");
            //}
            //else if (digit == 9)
            //{
            //    textBoxHitung.Text = textBoxHitung.Text.Insert(1, ",");
            //}
            //else if (digit == 10)
            //{
            //    textBoxHitung.Text = textBoxHitung.Text.Insert(1, ",");
            //}
            //else if (digit == 11)
            //{
            //    textBoxHitung.Text = textBoxHitung.Text.Insert(1, ",");
            //}
            //else if (digit == 12)
            //{
            //    textBoxHitung.Text = textBoxHitung.Text.Insert(1, ",");
            //}
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBoxHitung.Text += "0";
            //digit++;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            textBoxHitung.Text += "1";
            //digit++;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBoxHitung.Text += "2";
            //digit++;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBoxHitung.Text += "3";
            //digit++;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBoxHitung.Text += "4";
            //digit++;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBoxHitung.Text += "5";
            //digit++;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBoxHitung.Text += "6";
            //digit++;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBoxHitung.Text += "7";
            //digit++;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBoxHitung.Text += "8";
            //digit++;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBoxHitung.Text += "9";
            //digit++;
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            if(textBoxHitung.Text == "")
            {
                textBoxHitung.Text += "-";
            }
        }

        private void bBackSpace_Click(object sender, EventArgs e)
        {
            textBoxHitung.Text = textBoxHitung.Text.Remove(textBoxHitung.Text.Length - 1, 1);
        }

        private void bTitik_Click(object sender, EventArgs e)
        {
            string lastcharacter = textBoxHitung.Text.Substring(textBoxHitung.Text.Length - 1, 1);
            if (textBoxHitung.Text == "" ||  lastcharacter != "." && !textBoxHitung.Text.Contains("."))
            {
                textBoxHitung.Text += ".";
            }
        }

        private void bC_Click(object sender, EventArgs e)
        {
            textBoxHitung.Clear();
            textBoxMemory.Clear();
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
         
            textBoxMemory.Text += "+" + textBoxHitung.Text;
            //hasil = Convert.ToDouble(textBoxMemory.Text);
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            textBoxHitung.Clear();
        }

        private void textBoxMemory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
