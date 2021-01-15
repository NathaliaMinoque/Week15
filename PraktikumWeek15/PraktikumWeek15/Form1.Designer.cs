
namespace PraktikumWeek15
{
    partial class Form1
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
            this.labelBuDewi = new System.Windows.Forms.Label();
            this.labelItems = new System.Windows.Forms.Label();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.listBoxHarga = new System.Windows.Forms.ListBox();
            this.radioButtonMakanan = new System.Windows.Forms.RadioButton();
            this.radioButtonMinuman = new System.Windows.Forms.RadioButton();
            this.labelMenu = new System.Windows.Forms.Label();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelNominal = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonJumbo = new System.Windows.Forms.RadioButton();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBuDewi
            // 
            this.labelBuDewi.AutoSize = true;
            this.labelBuDewi.Location = new System.Drawing.Point(336, 27);
            this.labelBuDewi.Name = "labelBuDewi";
            this.labelBuDewi.Size = new System.Drawing.Size(68, 20);
            this.labelBuDewi.TabIndex = 0;
            this.labelBuDewi.Text = "Bu Dewi";
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Location = new System.Drawing.Point(148, 67);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(58, 20);
            this.labelItems.TabIndex = 1;
            this.labelItems.Text = "ITEMS";
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.ItemHeight = 20;
            this.listBoxItems.Location = new System.Drawing.Point(42, 90);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(157, 284);
            this.listBoxItems.TabIndex = 2;
            this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBoxItems_SelectedIndexChanged);
            // 
            // listBoxHarga
            // 
            this.listBoxHarga.FormattingEnabled = true;
            this.listBoxHarga.ItemHeight = 20;
            this.listBoxHarga.Location = new System.Drawing.Point(205, 90);
            this.listBoxHarga.Name = "listBoxHarga";
            this.listBoxHarga.Size = new System.Drawing.Size(120, 284);
            this.listBoxHarga.TabIndex = 3;
            this.listBoxHarga.SelectedIndexChanged += new System.EventHandler(this.listBoxHarga_SelectedIndexChanged);
            // 
            // radioButtonMakanan
            // 
            this.radioButtonMakanan.AutoSize = true;
            this.radioButtonMakanan.Location = new System.Drawing.Point(6, 44);
            this.radioButtonMakanan.Name = "radioButtonMakanan";
            this.radioButtonMakanan.Size = new System.Drawing.Size(100, 24);
            this.radioButtonMakanan.TabIndex = 4;
            this.radioButtonMakanan.TabStop = true;
            this.radioButtonMakanan.Text = "Makanan";
            this.radioButtonMakanan.UseVisualStyleBackColor = true;
            this.radioButtonMakanan.CheckedChanged += new System.EventHandler(this.radioButtonMakanan_CheckedChanged);
            // 
            // radioButtonMinuman
            // 
            this.radioButtonMinuman.AutoSize = true;
            this.radioButtonMinuman.Location = new System.Drawing.Point(107, 44);
            this.radioButtonMinuman.Name = "radioButtonMinuman";
            this.radioButtonMinuman.Size = new System.Drawing.Size(99, 24);
            this.radioButtonMinuman.TabIndex = 5;
            this.radioButtonMinuman.TabStop = true;
            this.radioButtonMinuman.Text = "Minuman";
            this.radioButtonMinuman.UseVisualStyleBackColor = true;
            this.radioButtonMinuman.CheckedChanged += new System.EventHandler(this.radioButtonMinuman_CheckedChanged);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Location = new System.Drawing.Point(393, 149);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(53, 20);
            this.labelMenu.TabIndex = 6;
            this.labelMenu.Text = "Menu:";
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Location = new System.Drawing.Point(464, 132);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(166, 28);
            this.comboBoxMenu.TabIndex = 7;
            this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Location = new System.Drawing.Point(636, 132);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(57, 20);
            this.labelHarga.TabIndex = 8;
            this.labelHarga.Text = "Harga:";
            // 
            // labelNominal
            // 
            this.labelNominal.AutoSize = true;
            this.labelNominal.Location = new System.Drawing.Point(708, 132);
            this.labelNominal.Name = "labelNominal";
            this.labelNominal.Size = new System.Drawing.Size(21, 20);
            this.labelNominal.TabIndex = 9;
            this.labelNominal.Text = "   ";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(406, 212);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(40, 20);
            this.labelSize.TabIndex = 10;
            this.labelSize.Text = "Size";
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(410, 250);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(84, 24);
            this.radioButtonNormal.TabIndex = 11;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            this.radioButtonNormal.CheckedChanged += new System.EventHandler(this.radioButtonNormal_CheckedChanged);
            // 
            // radioButtonJumbo
            // 
            this.radioButtonJumbo.AutoSize = true;
            this.radioButtonJumbo.Location = new System.Drawing.Point(509, 250);
            this.radioButtonJumbo.Name = "radioButtonJumbo";
            this.radioButtonJumbo.Size = new System.Drawing.Size(82, 24);
            this.radioButtonJumbo.TabIndex = 12;
            this.radioButtonJumbo.TabStop = true;
            this.radioButtonJumbo.Text = "Jumbo";
            this.radioButtonJumbo.UseVisualStyleBackColor = true;
            this.radioButtonJumbo.CheckedChanged += new System.EventHandler(this.radioButtonJumbo_CheckedChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(249, 381);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(76, 34);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(483, 296);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(79, 37);
            this.buttonBuy.TabIndex = 14;
            this.buttonBuy.Text = "BUY";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Location = new System.Drawing.Point(588, 350);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(171, 54);
            this.buttonCheckOut.TabIndex = 15;
            this.buttonCheckOut.Text = "Check Out";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMakanan);
            this.groupBox1.Controls.Add(this.radioButtonMinuman);
            this.groupBox1.Location = new System.Drawing.Point(445, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.radioButtonJumbo);
            this.Controls.Add(this.radioButtonNormal);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelNominal);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.comboBoxMenu);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.listBoxHarga);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.labelBuDewi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBuDewi;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.ListBox listBoxHarga;
        private System.Windows.Forms.RadioButton radioButtonMakanan;
        private System.Windows.Forms.RadioButton radioButtonMinuman;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelNominal;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonJumbo;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

