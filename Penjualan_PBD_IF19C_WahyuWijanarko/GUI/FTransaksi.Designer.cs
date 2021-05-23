namespace Penjualan_PBD_IF19C_WahyuWijanarko.GUI
{
    partial class FTransaksi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtpTanggalKwitansi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNoKwitansi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBrowsePelanggan = new System.Windows.Forms.Button();
            this.TxtNamaPelanggan = new System.Windows.Forms.TextBox();
            this.TxtKodePelanggan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnKurang = new System.Windows.Forms.Button();
            this.BtnTambah = new System.Windows.Forms.Button();
            this.BtnBrowseBarang = new System.Windows.Forms.Button();
            this.TxtJumlahJual = new System.Windows.Forms.TextBox();
            this.TxtHargaBarang = new System.Windows.Forms.TextBox();
            this.TxtNamaBarang = new System.Windows.Forms.TextBox();
            this.TxtKodeBarang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblTotalBayar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnKeluar = new System.Windows.Forms.Button();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnBaru = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DataGridPenjualan = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPenjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtpTanggalKwitansi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNoKwitansi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ":: Data Penjualan ::";
            // 
            // DtpTanggalKwitansi
            // 
            this.DtpTanggalKwitansi.CustomFormat = "MM/dd/yyyy";
            this.DtpTanggalKwitansi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpTanggalKwitansi.Location = new System.Drawing.Point(335, 28);
            this.DtpTanggalKwitansi.Name = "DtpTanggalKwitansi";
            this.DtpTanggalKwitansi.Size = new System.Drawing.Size(200, 29);
            this.DtpTanggalKwitansi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal";
            // 
            // TxtNoKwitansi
            // 
            this.TxtNoKwitansi.Location = new System.Drawing.Point(146, 28);
            this.TxtNoKwitansi.Name = "TxtNoKwitansi";
            this.TxtNoKwitansi.Size = new System.Drawing.Size(100, 29);
            this.TxtNoKwitansi.TabIndex = 1;
            this.TxtNoKwitansi.Text = "abcde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Kwitansi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnBrowsePelanggan);
            this.groupBox2.Controls.Add(this.TxtNamaPelanggan);
            this.groupBox2.Controls.Add(this.TxtKodePelanggan);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 116);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ":: Data Pelanggan ::";
            // 
            // BtnBrowsePelanggan
            // 
            this.BtnBrowsePelanggan.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.search16;
            this.BtnBrowsePelanggan.Location = new System.Drawing.Point(254, 32);
            this.BtnBrowsePelanggan.Name = "BtnBrowsePelanggan";
            this.BtnBrowsePelanggan.Size = new System.Drawing.Size(46, 29);
            this.BtnBrowsePelanggan.TabIndex = 4;
            this.BtnBrowsePelanggan.UseVisualStyleBackColor = true;
            this.BtnBrowsePelanggan.Click += new System.EventHandler(this.BtnBrowsePelanggan_Click);
            // 
            // TxtNamaPelanggan
            // 
            this.TxtNamaPelanggan.Location = new System.Drawing.Point(146, 67);
            this.TxtNamaPelanggan.Name = "TxtNamaPelanggan";
            this.TxtNamaPelanggan.Size = new System.Drawing.Size(279, 29);
            this.TxtNamaPelanggan.TabIndex = 3;
            this.TxtNamaPelanggan.Text = "nama";
            // 
            // TxtKodePelanggan
            // 
            this.TxtKodePelanggan.Location = new System.Drawing.Point(146, 32);
            this.TxtKodePelanggan.Name = "TxtKodePelanggan";
            this.TxtKodePelanggan.Size = new System.Drawing.Size(100, 29);
            this.TxtKodePelanggan.TabIndex = 2;
            this.TxtKodePelanggan.Text = "kode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nama Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kode Pelanggan";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnKurang);
            this.groupBox3.Controls.Add(this.BtnTambah);
            this.groupBox3.Controls.Add(this.BtnBrowseBarang);
            this.groupBox3.Controls.Add(this.TxtJumlahJual);
            this.groupBox3.Controls.Add(this.TxtHargaBarang);
            this.groupBox3.Controls.Add(this.TxtNamaBarang);
            this.groupBox3.Controls.Add(this.TxtKodeBarang);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(555, 185);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = ":: Data Barang ::";
            // 
            // BtnKurang
            // 
            this.BtnKurang.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.cancel32;
            this.BtnKurang.Location = new System.Drawing.Point(491, 123);
            this.BtnKurang.Name = "BtnKurang";
            this.BtnKurang.Size = new System.Drawing.Size(58, 42);
            this.BtnKurang.TabIndex = 10;
            this.BtnKurang.UseVisualStyleBackColor = true;
            this.BtnKurang.Click += new System.EventHandler(this.BtnKurang_Click);
            // 
            // BtnTambah
            // 
            this.BtnTambah.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.add32;
            this.BtnTambah.Location = new System.Drawing.Point(427, 123);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(58, 42);
            this.BtnTambah.TabIndex = 9;
            this.BtnTambah.UseVisualStyleBackColor = true;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // BtnBrowseBarang
            // 
            this.BtnBrowseBarang.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.search16;
            this.BtnBrowseBarang.Location = new System.Drawing.Point(254, 31);
            this.BtnBrowseBarang.Name = "BtnBrowseBarang";
            this.BtnBrowseBarang.Size = new System.Drawing.Size(46, 29);
            this.BtnBrowseBarang.TabIndex = 8;
            this.BtnBrowseBarang.UseVisualStyleBackColor = true;
            this.BtnBrowseBarang.Click += new System.EventHandler(this.BtnBrowseBarang_Click);
            // 
            // TxtJumlahJual
            // 
            this.TxtJumlahJual.Location = new System.Drawing.Point(146, 136);
            this.TxtJumlahJual.Name = "TxtJumlahJual";
            this.TxtJumlahJual.Size = new System.Drawing.Size(100, 29);
            this.TxtJumlahJual.TabIndex = 7;
            // 
            // TxtHargaBarang
            // 
            this.TxtHargaBarang.Location = new System.Drawing.Point(146, 101);
            this.TxtHargaBarang.Name = "TxtHargaBarang";
            this.TxtHargaBarang.Size = new System.Drawing.Size(154, 29);
            this.TxtHargaBarang.TabIndex = 6;
            // 
            // TxtNamaBarang
            // 
            this.TxtNamaBarang.Location = new System.Drawing.Point(146, 66);
            this.TxtNamaBarang.Name = "TxtNamaBarang";
            this.TxtNamaBarang.Size = new System.Drawing.Size(279, 29);
            this.TxtNamaBarang.TabIndex = 5;
            // 
            // TxtKodeBarang
            // 
            this.TxtKodeBarang.Location = new System.Drawing.Point(146, 31);
            this.TxtKodeBarang.Name = "TxtKodeBarang";
            this.TxtKodeBarang.Size = new System.Drawing.Size(100, 29);
            this.TxtKodeBarang.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Jumlah Jual";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Harga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nama Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kode Barang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Total Bayar";
            // 
            // LblTotalBayar
            // 
            this.LblTotalBayar.AutoSize = true;
            this.LblTotalBayar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalBayar.Location = new System.Drawing.Point(152, 405);
            this.LblTotalBayar.Name = "LblTotalBayar";
            this.LblTotalBayar.Size = new System.Drawing.Size(171, 32);
            this.LblTotalBayar.TabIndex = 4;
            this.LblTotalBayar.Text = "Rp. Total Bayar";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnKeluar);
            this.panel1.Controls.Add(this.BtnSimpan);
            this.panel1.Controls.Add(this.BtnBaru);
            this.panel1.Location = new System.Drawing.Point(12, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 69);
            this.panel1.TabIndex = 5;
            // 
            // BtnKeluar
            // 
            this.BtnKeluar.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.exit32;
            this.BtnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKeluar.Location = new System.Drawing.Point(400, 9);
            this.BtnKeluar.Name = "BtnKeluar";
            this.BtnKeluar.Size = new System.Drawing.Size(144, 49);
            this.BtnKeluar.TabIndex = 2;
            this.BtnKeluar.Text = "&Keluar";
            this.BtnKeluar.UseVisualStyleBackColor = true;
            this.BtnKeluar.Click += new System.EventHandler(this.BtnKeluar_Click);
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.save32;
            this.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSimpan.Location = new System.Drawing.Point(162, 9);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(144, 49);
            this.BtnSimpan.TabIndex = 1;
            this.BtnSimpan.Text = "&Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnBaru
            // 
            this.BtnBaru.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.edit32;
            this.BtnBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBaru.Location = new System.Drawing.Point(9, 9);
            this.BtnBaru.Name = "BtnBaru";
            this.BtnBaru.Size = new System.Drawing.Size(144, 49);
            this.BtnBaru.TabIndex = 0;
            this.BtnBaru.Text = "&Baru";
            this.BtnBaru.UseVisualStyleBackColor = true;
            this.BtnBaru.Click += new System.EventHandler(this.BtnBaru_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DataGridPenjualan);
            this.groupBox4.Location = new System.Drawing.Point(573, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(423, 504);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = ":: Detail Penjualan ::";
            // 
            // DataGridPenjualan
            // 
            this.DataGridPenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPenjualan.Location = new System.Drawing.Point(6, 31);
            this.DataGridPenjualan.Name = "DataGridPenjualan";
            this.DataGridPenjualan.Size = new System.Drawing.Size(411, 467);
            this.DataGridPenjualan.TabIndex = 0;
            this.DataGridPenjualan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridPenjualan_CellClick);
            // 
            // FTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 528);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblTotalBayar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Form Transaksi ::";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPenjualan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DtpTanggalKwitansi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNoKwitansi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBrowsePelanggan;
        private System.Windows.Forms.TextBox TxtNamaPelanggan;
        private System.Windows.Forms.TextBox TxtKodePelanggan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnKurang;
        private System.Windows.Forms.Button BtnTambah;
        private System.Windows.Forms.Button BtnBrowseBarang;
        private System.Windows.Forms.TextBox TxtJumlahJual;
        private System.Windows.Forms.TextBox TxtHargaBarang;
        private System.Windows.Forms.TextBox TxtNamaBarang;
        private System.Windows.Forms.TextBox TxtKodeBarang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblTotalBayar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBaru;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Button BtnKeluar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DataGridPenjualan;
    }
}