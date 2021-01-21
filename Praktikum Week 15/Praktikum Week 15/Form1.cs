using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_Week_15
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        
        public static int countermakanan = 5;
        public static int counterminuman = 4;
        public string[,] menu = new string[100, 2];

        public int cek = 0;
        //0 = makanan
        //1 = minuman
        private void FormUtama_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(menu[0, 0] = "Mi Instan");
            listBox1.Items.Add(menu[1, 0] = "Telor");
            listBox1.Items.Add(menu[0, 1] = "Susu Sapi");
            listBox1.Items.Add(menu[1, 1] = "Kopi");
            listBox1.Items.Add(menu[2, 0] = "Roti");
            listBox1.Items.Add(menu[3, 0] = "Keju");
            listBox1.Items.Add(menu[4, 0] = "Daging Giling");
            listBox1.Items.Add(menu[2, 1] = "Teh");
            listBox1.Items.Add(menu[3, 1] = "Bir");
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            cek = 0;
            //ngecek makanan yang sama
            for (int i=0; i<countermakanan; i++)
            {
                if (menu[i, 0] == textBoxNamaItem.Text)
                {
                    cek++;
                }
            }
            //ngecek minuman yang sama
            for (int i = 0; i < counterminuman; i++)
            {
                if (menu[i, 1] == textBoxNamaItem.Text)
                {
                    cek++;
                }
            }
            if (cek > 0 && radioButtonMakanan.Checked == true || cek > 0 && radioButtonMinuman.Checked == true)
            {
                MessageBox.Show("Mohon input ulang! Menu sudah ada");
            }
            else if (textBoxNamaItem.Text!= "" && radioButtonMakanan.Checked == true)
            {
                listBox1.Items.Add(menu[countermakanan, 0] = textBoxNamaItem.Text);
                countermakanan++;
            }
            else if (textBoxNamaItem.Text != "" && radioButtonMinuman.Checked == true)
            {
                listBox1.Items.Add(menu[counterminuman, 0] = textBoxNamaItem.Text);
                counterminuman++;
            }
            else
            {
                MessageBox.Show("Masukkan Data dengan Benar!");           
            }
            textBoxNamaItem.Text = "";
            radioButtonMakanan.Checked = false;
            radioButtonMinuman.Checked = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {         
            listBox1.SelectionMode = SelectionMode.MultiSimple;
        }

        private void buttonPindah_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= listBox1.SelectedIndices.Count-1 ; i++)
            {
                if (listBox2.Items.Contains(listBox1.SelectedItems[i]))
                {
                    
                }
                else
                {
                    listBox2.Items.Add(listBox1.SelectedItems[i]);
                }
            }
            listBox1.ClearSelected();
            checkBoxMakanan.Checked = false;
            checkBoxMinuman.Checked = false;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 0)
            {
                listBox2.Items.Clear();
            }
            else
            {
                for (int i=listBox2.SelectedIndices.Count-1; i>=0; i--)
                {
                    listBox2.Items.Remove(listBox2.SelectedItems[i]);
                }
            }
        }

        public string[] simpan = new string[countermakanan + counterminuman];
        private void checkBoxMakanan_CheckedChanged(object sender, EventArgs e)
        {  
            if (checkBoxMakanan.Checked == true)
            {
                checkBoxMinuman.Checked = false;
                listBox1.ClearSelected();
                for (int i=0; i<countermakanan; i++)
                {
                    listBox1.SelectedItem = menu[i, 0];
                }
            }
            else
            {
                listBox1.ClearSelected();
            } 
        }

        private void checkBoxMinuman_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMinuman.Checked == true)
            {
                checkBoxMakanan.Checked = false;
                listBox1.ClearSelected();             
                for (int i = 0; i < counterminuman; i++)
                {
                    listBox1.SelectedItem = menu[i, 1];
                }
            }
            else
            {
                listBox1.ClearSelected();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            listBox2.SelectionMode = SelectionMode.MultiSimple;
        }
    }
}
