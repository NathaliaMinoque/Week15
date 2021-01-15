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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelSize.Visible = false;
            radioButtonNormal.Visible = false;
            radioButtonJumbo.Visible = false;
        }

        private void radioButtonMakanan_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMenu.Items.Clear();
            if (radioButtonMakanan.Checked == true)
            {
                comboBoxMenu.Items.Add("Nasi Goreng");
                comboBoxMenu.Items.Add("Nasi Goreng Spesial");
                comboBoxMenu.Items.Add("Nasi Goreng Pete");
                comboBoxMenu.Items.Add("Ayam Bakar");
                labelSize.Visible = false;
                radioButtonNormal.Visible = false;
                radioButtonJumbo.Visible = false;
                //MessageBox.Show(comboBoxMenu.SelectedItem.ToString());
            }
        }

        private void radioButtonMinuman_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMenu.Items.Clear();
            if (radioButtonMinuman.Checked == true)
            {
                comboBoxMenu.Items.Add("Es Teh");
                comboBoxMenu.Items.Add("Teh Hangat");
                comboBoxMenu.Items.Add("Nutrisari");
                comboBoxMenu.Items.Add("Aqua");
                labelSize.Visible = true;
                radioButtonNormal.Visible = true;
                radioButtonJumbo.Visible = true;
            }
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {        
            if (radioButtonMakanan.Checked == true)
            {
                //comboBoxMenu.Items.Clear();
                if (comboBoxMenu.SelectedIndex == 0)
                {
                    labelNominal.Text = "10000";
                }
                else if (comboBoxMenu.SelectedIndex == 1)
                {
                    labelNominal.Text = "12000";
                }
                else if (comboBoxMenu.SelectedIndex == 2)
                {
                    labelNominal.Text = "15000";
                }
                else if (comboBoxMenu.SelectedIndex == 3)
                {
                    labelNominal.Text = "15000";
                }
            }
        }

        private void radioButtonNormal_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonNormal.Checked == true)
            {
                //comboBoxMenu.Items.Clear();
                if (comboBoxMenu.SelectedIndex == 0)
                {
                    labelNominal.Text = "5000";
                }
                else if (comboBoxMenu.SelectedIndex == 1)
                {
                    labelNominal.Text = "3000";
                }
                else if (comboBoxMenu.SelectedIndex == 2)
                {
                    labelNominal.Text = "6000";
                }
                else if (comboBoxMenu.SelectedIndex == 3)
                {
                    labelNominal.Text = "2000";
                }
            }
        }

        private void radioButtonJumbo_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonJumbo.Checked == true)
            {
                if (comboBoxMenu.SelectedIndex == 0)
                {
                    labelNominal.Text = "7000";
                }
                else if (comboBoxMenu.SelectedIndex == 1)
                {
                    labelNominal.Text = "5000";
                }
                else if (comboBoxMenu.SelectedIndex == 2)
                {
                    labelNominal.Text = "10000";
                }
                else if (comboBoxMenu.SelectedIndex == 3)
                {
                    labelNominal.Text = "5000";
                }
            }
        }

        public static int counter = 0;
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            listBoxItems.Items.Add(comboBoxMenu.SelectedItem);
            listBoxHarga.Items.Add(labelNominal.Text);
            //subtotal += Convert.ToInt32(listBoxHarga.Items);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxItems.Items.Count == 0)
            {
                buttonDelete.Enabled = false;
            }
            else
            {
                int urutan = listBoxItems.SelectedIndex;
                listBoxItems.Items.RemoveAt(urutan);
                listBoxHarga.Items.RemoveAt(urutan);
                //subtotal -= Convert.ToInt32(listBoxHarga.SelectedItem);
            }

        }

        public static int subtotal = 0;
        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            if (listBoxItems.Items.Count == 0)
            {
                MessageBox.Show("Choose Menu");
            }
            else
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }

        private void listBoxHarga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
