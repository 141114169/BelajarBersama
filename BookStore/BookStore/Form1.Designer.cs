namespace BookStore
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
            this.components = new System.ComponentModel.Container();
            this.tbctrlMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotalHargaJual = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LVdaftarJual = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnLakukanPenjualan = new System.Windows.Forms.Button();
            this.bttnResetJual = new System.Windows.Forms.Button();
            this.bttnTambahJual = new System.Windows.Forms.Button();
            this.txtbKodeBukuJual = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudTahunTerbitBaru = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txtJudulBaru = new System.Windows.Forms.TextBox();
            this.bttnHapusDataDftrBk = new System.Windows.Forms.Button();
            this.bttnUpdateDataDftrBk = new System.Windows.Forms.Button();
            this.bttnTambahDataDftrBk = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbPenerbitBaru = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbPenulisBaru = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKodeBarangBaru = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbKodeBarangYgBerubah = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudHargaBaru = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudStokBaru = new System.Windows.Forms.NumericUpDown();
            this.LVdaftarBuku = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nudKuantitasJual = new System.Windows.Forms.NumericUpDown();
            this.tbctrlMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTahunTerbitBaru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHargaBaru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokBaru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKuantitasJual)).BeginInit();
            this.SuspendLayout();
            // 
            // tbctrlMenu
            // 
            this.tbctrlMenu.Controls.Add(this.tabPage1);
            this.tbctrlMenu.Controls.Add(this.tabPage2);
            this.tbctrlMenu.Location = new System.Drawing.Point(2, 28);
            this.tbctrlMenu.Name = "tbctrlMenu";
            this.tbctrlMenu.SelectedIndex = 0;
            this.tbctrlMenu.Size = new System.Drawing.Size(965, 365);
            this.tbctrlMenu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nudKuantitasJual);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.lblTotalHargaJual);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.LVdaftarJual);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.bttnLakukanPenjualan);
            this.tabPage1.Controls.Add(this.bttnResetJual);
            this.tabPage1.Controls.Add(this.bttnTambahJual);
            this.tabPage1.Controls.Add(this.txtbKodeBukuJual);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(957, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Penjualan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Kuantitas";
            // 
            // lblTotalHargaJual
            // 
            this.lblTotalHargaJual.AutoSize = true;
            this.lblTotalHargaJual.Location = new System.Drawing.Point(81, 256);
            this.lblTotalHargaJual.Name = "lblTotalHargaJual";
            this.lblTotalHargaJual.Size = new System.Drawing.Size(13, 13);
            this.lblTotalHargaJual.TabIndex = 11;
            this.lblTotalHargaJual.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // LVdaftarJual
            // 
            this.LVdaftarJual.GridLines = true;
            this.LVdaftarJual.LabelEdit = true;
            this.LVdaftarJual.Location = new System.Drawing.Point(217, 52);
            this.LVdaftarJual.Name = "LVdaftarJual";
            this.LVdaftarJual.Size = new System.Drawing.Size(734, 254);
            this.LVdaftarJual.TabIndex = 9;
            this.LVdaftarJual.UseCompatibleStateImageBehavior = false;
            this.LVdaftarJual.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kode Buku";
            // 
            // bttnLakukanPenjualan
            // 
            this.bttnLakukanPenjualan.Location = new System.Drawing.Point(81, 283);
            this.bttnLakukanPenjualan.Name = "bttnLakukanPenjualan";
            this.bttnLakukanPenjualan.Size = new System.Drawing.Size(114, 23);
            this.bttnLakukanPenjualan.TabIndex = 6;
            this.bttnLakukanPenjualan.Text = "Lakukan Penjualan";
            this.bttnLakukanPenjualan.UseVisualStyleBackColor = true;
            this.bttnLakukanPenjualan.Click += new System.EventHandler(this.bttnLakukanPenjualan_Click);
            // 
            // bttnResetJual
            // 
            this.bttnResetJual.Location = new System.Drawing.Point(81, 137);
            this.bttnResetJual.Name = "bttnResetJual";
            this.bttnResetJual.Size = new System.Drawing.Size(114, 23);
            this.bttnResetJual.TabIndex = 4;
            this.bttnResetJual.Text = "Reset";
            this.bttnResetJual.UseVisualStyleBackColor = true;
            this.bttnResetJual.Click += new System.EventHandler(this.bttnResetJual_Click);
            // 
            // bttnTambahJual
            // 
            this.bttnTambahJual.Location = new System.Drawing.Point(81, 108);
            this.bttnTambahJual.Name = "bttnTambahJual";
            this.bttnTambahJual.Size = new System.Drawing.Size(114, 23);
            this.bttnTambahJual.TabIndex = 3;
            this.bttnTambahJual.Text = "Tambah";
            this.bttnTambahJual.UseVisualStyleBackColor = true;
            this.bttnTambahJual.Click += new System.EventHandler(this.bttnTambahJual_Click);
            // 
            // txtbKodeBukuJual
            // 
            this.txtbKodeBukuJual.Location = new System.Drawing.Point(80, 52);
            this.txtbKodeBukuJual.Name = "txtbKodeBukuJual";
            this.txtbKodeBukuJual.Size = new System.Drawing.Size(114, 20);
            this.txtbKodeBukuJual.TabIndex = 2;
            this.txtbKodeBukuJual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbKodeBukuJual_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.LVdaftarBuku);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(957, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Daftar Buku";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Update Data Buku";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nudTahunTerbitBaru);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtJudulBaru);
            this.panel1.Controls.Add(this.bttnHapusDataDftrBk);
            this.panel1.Controls.Add(this.bttnUpdateDataDftrBk);
            this.panel1.Controls.Add(this.bttnTambahDataDftrBk);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtbPenerbitBaru);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtbPenulisBaru);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtKodeBarangBaru);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtbKodeBarangYgBerubah);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nudHargaBaru);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nudStokBaru);
            this.panel1.Location = new System.Drawing.Point(5, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 302);
            this.panel1.TabIndex = 4;
            // 
            // nudTahunTerbitBaru
            // 
            this.nudTahunTerbitBaru.Location = new System.Drawing.Point(88, 231);
            this.nudTahunTerbitBaru.Name = "nudTahunTerbitBaru";
            this.nudTahunTerbitBaru.Size = new System.Drawing.Size(120, 20);
            this.nudTahunTerbitBaru.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Judul Buku";
            // 
            // txtJudulBaru
            // 
            this.txtJudulBaru.Location = new System.Drawing.Point(87, 156);
            this.txtJudulBaru.Name = "txtJudulBaru";
            this.txtJudulBaru.Size = new System.Drawing.Size(119, 20);
            this.txtJudulBaru.TabIndex = 21;
            // 
            // bttnHapusDataDftrBk
            // 
            this.bttnHapusDataDftrBk.Location = new System.Drawing.Point(88, 34);
            this.bttnHapusDataDftrBk.Name = "bttnHapusDataDftrBk";
            this.bttnHapusDataDftrBk.Size = new System.Drawing.Size(118, 23);
            this.bttnHapusDataDftrBk.TabIndex = 20;
            this.bttnHapusDataDftrBk.Text = "Hapus Data";
            this.bttnHapusDataDftrBk.UseVisualStyleBackColor = true;
            this.bttnHapusDataDftrBk.Click += new System.EventHandler(this.bttnHapusDataDftrBk_Click);
            // 
            // bttnUpdateDataDftrBk
            // 
            this.bttnUpdateDataDftrBk.Location = new System.Drawing.Point(131, 260);
            this.bttnUpdateDataDftrBk.Name = "bttnUpdateDataDftrBk";
            this.bttnUpdateDataDftrBk.Size = new System.Drawing.Size(75, 35);
            this.bttnUpdateDataDftrBk.TabIndex = 19;
            this.bttnUpdateDataDftrBk.Text = "Update Buku";
            this.bttnUpdateDataDftrBk.UseVisualStyleBackColor = true;
            this.bttnUpdateDataDftrBk.Click += new System.EventHandler(this.bttnUpdateDataDftrBk_Click);
            // 
            // bttnTambahDataDftrBk
            // 
            this.bttnTambahDataDftrBk.Location = new System.Drawing.Point(7, 260);
            this.bttnTambahDataDftrBk.Name = "bttnTambahDataDftrBk";
            this.bttnTambahDataDftrBk.Size = new System.Drawing.Size(75, 35);
            this.bttnTambahDataDftrBk.TabIndex = 18;
            this.bttnTambahDataDftrBk.Text = "Tambah  Buku";
            this.bttnTambahDataDftrBk.UseVisualStyleBackColor = true;
            this.bttnTambahDataDftrBk.Click += new System.EventHandler(this.bttnTambahDataDftrBk_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Tahun Terbit";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Penerbit";
            // 
            // txtbPenerbitBaru
            // 
            this.txtbPenerbitBaru.Location = new System.Drawing.Point(87, 207);
            this.txtbPenerbitBaru.Name = "txtbPenerbitBaru";
            this.txtbPenerbitBaru.Size = new System.Drawing.Size(119, 20);
            this.txtbPenerbitBaru.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Penulis";
            // 
            // txtbPenulisBaru
            // 
            this.txtbPenulisBaru.Location = new System.Drawing.Point(87, 182);
            this.txtbPenulisBaru.Name = "txtbPenulisBaru";
            this.txtbPenulisBaru.Size = new System.Drawing.Size(119, 20);
            this.txtbPenulisBaru.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Kode Buku";
            // 
            // txtKodeBarangBaru
            // 
            this.txtKodeBarangBaru.Location = new System.Drawing.Point(87, 131);
            this.txtKodeBarangBaru.Name = "txtKodeBarangBaru";
            this.txtKodeBarangBaru.Size = new System.Drawing.Size(119, 20);
            this.txtKodeBarangBaru.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Data Buku Baru";
            // 
            // txtbKodeBarangYgBerubah
            // 
            this.txtbKodeBarangYgBerubah.Location = new System.Drawing.Point(88, 10);
            this.txtbKodeBarangYgBerubah.Name = "txtbKodeBarangYgBerubah";
            this.txtbKodeBarangYgBerubah.Size = new System.Drawing.Size(119, 20);
            this.txtbKodeBarangYgBerubah.TabIndex = 8;
            this.txtbKodeBarangYgBerubah.TextChanged += new System.EventHandler(this.txtbKodeBarangYgBerubah_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 39);
            this.label7.TabIndex = 7;
            this.label7.Text = "Kode Buku\r\n(yg mau diubah) :\r\n\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Harga";
            // 
            // nudHargaBaru
            // 
            this.nudHargaBaru.Location = new System.Drawing.Point(87, 107);
            this.nudHargaBaru.Name = "nudHargaBaru";
            this.nudHargaBaru.Size = new System.Drawing.Size(120, 20);
            this.nudHargaBaru.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stok";
            // 
            // nudStokBaru
            // 
            this.nudStokBaru.Location = new System.Drawing.Point(87, 81);
            this.nudStokBaru.Name = "nudStokBaru";
            this.nudStokBaru.Size = new System.Drawing.Size(120, 20);
            this.nudStokBaru.TabIndex = 3;
            this.nudStokBaru.ValueChanged += new System.EventHandler(this.nudStokBaru_ValueChanged);
            // 
            // LVdaftarBuku
            // 
            this.LVdaftarBuku.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.LVdaftarBuku.AllowColumnReorder = true;
            this.LVdaftarBuku.GridLines = true;
            this.LVdaftarBuku.Location = new System.Drawing.Point(223, 31);
            this.LVdaftarBuku.Name = "LVdaftarBuku";
            this.LVdaftarBuku.Size = new System.Drawing.Size(728, 302);
            this.LVdaftarBuku.TabIndex = 2;
            this.LVdaftarBuku.UseCompatibleStateImageBehavior = false;
            this.LVdaftarBuku.ItemActivate += new System.EventHandler(this.LVdaftarBuku_ItemActivate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daftar Buku";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // nudKuantitasJual
            // 
            this.nudKuantitasJual.Location = new System.Drawing.Point(80, 78);
            this.nudKuantitasJual.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudKuantitasJual.Name = "nudKuantitasJual";
            this.nudKuantitasJual.Size = new System.Drawing.Size(56, 20);
            this.nudKuantitasJual.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 395);
            this.Controls.Add(this.tbctrlMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbctrlMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTahunTerbitBaru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHargaBaru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokBaru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKuantitasJual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbctrlMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnLakukanPenjualan;
        private System.Windows.Forms.Button bttnResetJual;
        private System.Windows.Forms.Button bttnTambahJual;
        private System.Windows.Forms.TextBox txtbKodeBukuJual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView LVdaftarJual;
        private System.Windows.Forms.Label lblTotalHargaJual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudStokBaru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudHargaBaru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbPenulisBaru;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKodeBarangBaru;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbKodeBarangYgBerubah;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbPenerbitBaru;
        private System.Windows.Forms.Button bttnHapusDataDftrBk;
        private System.Windows.Forms.Button bttnUpdateDataDftrBk;
        private System.Windows.Forms.Button bttnTambahDataDftrBk;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ListView LVdaftarBuku;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtJudulBaru;
        private System.Windows.Forms.NumericUpDown nudTahunTerbitBaru;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudKuantitasJual;

    }
}

