
namespace Praktikum_Week_15
{
    partial class FormUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNamaItem = new System.Windows.Forms.Label();
            this.textBoxNamaItem = new System.Windows.Forms.TextBox();
            this.labelKategori = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMakanan = new System.Windows.Forms.RadioButton();
            this.radioButtonMinuman = new System.Windows.Forms.RadioButton();
            this.buttonInput = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.checkBoxMakanan = new System.Windows.Forms.CheckBox();
            this.checkBoxMinuman = new System.Windows.Forms.CheckBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonPindah = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNamaItem
            // 
            this.labelNamaItem.AutoSize = true;
            this.labelNamaItem.Location = new System.Drawing.Point(43, 29);
            this.labelNamaItem.Name = "labelNamaItem";
            this.labelNamaItem.Size = new System.Drawing.Size(87, 20);
            this.labelNamaItem.TabIndex = 0;
            this.labelNamaItem.Text = "Nama Item";
            // 
            // textBoxNamaItem
            // 
            this.textBoxNamaItem.Location = new System.Drawing.Point(151, 29);
            this.textBoxNamaItem.Name = "textBoxNamaItem";
            this.textBoxNamaItem.Size = new System.Drawing.Size(248, 26);
            this.textBoxNamaItem.TabIndex = 1;
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Location = new System.Drawing.Point(43, 81);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(68, 20);
            this.labelKategori.TabIndex = 2;
            this.labelKategori.Text = "Kategori";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMinuman);
            this.groupBox1.Controls.Add(this.radioButtonMakanan);
            this.groupBox1.Location = new System.Drawing.Point(151, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 43);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButtonMakanan
            // 
            this.radioButtonMakanan.AutoSize = true;
            this.radioButtonMakanan.Location = new System.Drawing.Point(0, 0);
            this.radioButtonMakanan.Name = "radioButtonMakanan";
            this.radioButtonMakanan.Size = new System.Drawing.Size(100, 24);
            this.radioButtonMakanan.TabIndex = 0;
            this.radioButtonMakanan.TabStop = true;
            this.radioButtonMakanan.Text = "Makanan";
            this.radioButtonMakanan.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinuman
            // 
            this.radioButtonMinuman.AutoSize = true;
            this.radioButtonMinuman.Location = new System.Drawing.Point(120, 0);
            this.radioButtonMinuman.Name = "radioButtonMinuman";
            this.radioButtonMinuman.Size = new System.Drawing.Size(99, 24);
            this.radioButtonMinuman.TabIndex = 1;
            this.radioButtonMinuman.TabStop = true;
            this.radioButtonMinuman.Text = "Minuman";
            this.radioButtonMinuman.UseVisualStyleBackColor = true;
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(151, 128);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(99, 32);
            this.buttonInput.TabIndex = 4;
            this.buttonInput.Text = "Input";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(47, 176);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 284);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.checkBoxMinuman);
            this.groupBoxFilter.Controls.Add(this.checkBoxMakanan);
            this.groupBoxFilter.Location = new System.Drawing.Point(271, 266);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(137, 90);
            this.groupBoxFilter.TabIndex = 8;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // checkBoxMakanan
            // 
            this.checkBoxMakanan.AutoSize = true;
            this.checkBoxMakanan.Location = new System.Drawing.Point(7, 26);
            this.checkBoxMakanan.Name = "checkBoxMakanan";
            this.checkBoxMakanan.Size = new System.Drawing.Size(101, 24);
            this.checkBoxMakanan.TabIndex = 0;
            this.checkBoxMakanan.Text = "Makanan";
            this.checkBoxMakanan.UseVisualStyleBackColor = true;
            this.checkBoxMakanan.CheckedChanged += new System.EventHandler(this.checkBoxMakanan_CheckedChanged);
            // 
            // checkBoxMinuman
            // 
            this.checkBoxMinuman.AutoSize = true;
            this.checkBoxMinuman.Location = new System.Drawing.Point(7, 56);
            this.checkBoxMinuman.Name = "checkBoxMinuman";
            this.checkBoxMinuman.Size = new System.Drawing.Size(100, 24);
            this.checkBoxMinuman.TabIndex = 1;
            this.checkBoxMinuman.Text = "Minuman";
            this.checkBoxMinuman.UseVisualStyleBackColor = true;
            this.checkBoxMinuman.CheckedChanged += new System.EventHandler(this.checkBoxMinuman_CheckedChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(460, 176);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(177, 284);
            this.listBox2.TabIndex = 9;
            // 
            // buttonPindah
            // 
            this.buttonPindah.Location = new System.Drawing.Point(292, 176);
            this.buttonPindah.Name = "buttonPindah";
            this.buttonPindah.Size = new System.Drawing.Size(99, 32);
            this.buttonPindah.TabIndex = 10;
            this.buttonPindah.Text = ">";
            this.buttonPindah.UseVisualStyleBackColor = true;
            this.buttonPindah.Click += new System.EventHandler(this.buttonPindah_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(292, 214);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(99, 32);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "X";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 495);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonPindah);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelKategori);
            this.Controls.Add(this.textBoxNamaItem);
            this.Controls.Add(this.labelNamaItem);
            this.Name = "FormUtama";
            this.Text = "Form Utama";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNamaItem;
        private System.Windows.Forms.TextBox textBoxNamaItem;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMakanan;
        private System.Windows.Forms.RadioButton radioButtonMinuman;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.CheckBox checkBoxMinuman;
        private System.Windows.Forms.CheckBox checkBoxMakanan;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonPindah;
        private System.Windows.Forms.Button buttonDelete;
    }
}

