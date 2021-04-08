namespace Penjualan_PBD_IF19C_WahyuWijanarko.GUI
{
    partial class FBarang
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKodeBarang = new System.Windows.Forms.TextBox();
            this.TxtNamaBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtHargaBarang = new System.Windows.Forms.TextBox();
            this.TxtStokBarang = new System.Windows.Forms.TextBox();
            this.CmbSatuan = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnKeluar = new System.Windows.Forms.Button();
            this.BtnBaru = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCariBarang = new System.Windows.Forms.TextBox();
            this.ListBarang = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbSatuan);
            this.groupBox1.Controls.Add(this.TxtStokBarang);
            this.groupBox1.Controls.Add(this.TxtHargaBarang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNamaBarang);
            this.groupBox1.Controls.Add(this.TxtKodeBarang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".:: Input Data Barang ::.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Barang";
            // 
            // TxtKodeBarang
            // 
            this.TxtKodeBarang.Location = new System.Drawing.Point(146, 40);
            this.TxtKodeBarang.Name = "TxtKodeBarang";
            this.TxtKodeBarang.Size = new System.Drawing.Size(121, 29);
            this.TxtKodeBarang.TabIndex = 1;
            this.TxtKodeBarang.Text = "abcde";
            // 
            // TxtNamaBarang
            // 
            this.TxtNamaBarang.Location = new System.Drawing.Point(146, 76);
            this.TxtNamaBarang.Name = "TxtNamaBarang";
            this.TxtNamaBarang.Size = new System.Drawing.Size(250, 29);
            this.TxtNamaBarang.TabIndex = 2;
            this.TxtNamaBarang.Text = "nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Harga Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stok Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Satuan";
            // 
            // TxtHargaBarang
            // 
            this.TxtHargaBarang.Location = new System.Drawing.Point(146, 112);
            this.TxtHargaBarang.Name = "TxtHargaBarang";
            this.TxtHargaBarang.Size = new System.Drawing.Size(145, 29);
            this.TxtHargaBarang.TabIndex = 7;
            this.TxtHargaBarang.Text = "1000000";
            // 
            // TxtStokBarang
            // 
            this.TxtStokBarang.Location = new System.Drawing.Point(146, 148);
            this.TxtStokBarang.Name = "TxtStokBarang";
            this.TxtStokBarang.Size = new System.Drawing.Size(121, 29);
            this.TxtStokBarang.TabIndex = 8;
            this.TxtStokBarang.Text = "120";
            // 
            // CmbSatuan
            // 
            this.CmbSatuan.FormattingEnabled = true;
            this.CmbSatuan.Items.AddRange(new object[] {
            "Unit",
            "Lusin",
            "Kodi",
            "Pack",
            "Dus"});
            this.CmbSatuan.Location = new System.Drawing.Point(146, 184);
            this.CmbSatuan.Name = "CmbSatuan";
            this.CmbSatuan.Size = new System.Drawing.Size(121, 29);
            this.CmbSatuan.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnKeluar);
            this.panel1.Controls.Add(this.BtnHapus);
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.BtnBaru);
            this.panel1.Location = new System.Drawing.Point(12, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 109);
            this.panel1.TabIndex = 1;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.edit16;
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.Location = new System.Drawing.Point(120, 10);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(104, 41);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "&Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnHapus
            // 
            this.BtnHapus.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.delete16;
            this.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHapus.Location = new System.Drawing.Point(10, 57);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(104, 41);
            this.BtnHapus.TabIndex = 2;
            this.BtnHapus.Text = "&Hapus";
            this.BtnHapus.UseVisualStyleBackColor = true;
            // 
            // BtnKeluar
            // 
            this.BtnKeluar.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.exit16;
            this.BtnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKeluar.Location = new System.Drawing.Point(120, 57);
            this.BtnKeluar.Name = "BtnKeluar";
            this.BtnKeluar.Size = new System.Drawing.Size(104, 41);
            this.BtnKeluar.TabIndex = 3;
            this.BtnKeluar.Text = "&Keluar";
            this.BtnKeluar.UseVisualStyleBackColor = true;
            // 
            // BtnBaru
            // 
            this.BtnBaru.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.add16;
            this.BtnBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBaru.Location = new System.Drawing.Point(10, 10);
            this.BtnBaru.Name = "BtnBaru";
            this.BtnBaru.Size = new System.Drawing.Size(104, 41);
            this.BtnBaru.TabIndex = 0;
            this.BtnBaru.Text = "&Baru";
            this.BtnBaru.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnSimpan);
            this.panel2.Location = new System.Drawing.Point(253, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 108);
            this.panel2.TabIndex = 2;
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.save32;
            this.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSimpan.Location = new System.Drawing.Point(11, 10);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(145, 88);
            this.BtnSimpan.TabIndex = 0;
            this.BtnSimpan.Text = "&Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListBarang);
            this.groupBox2.Location = new System.Drawing.Point(427, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 300);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " .:: List Data Barang ::.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cari Nama Barang :";
            // 
            // TxtCariBarang
            // 
            this.TxtCariBarang.Location = new System.Drawing.Point(577, 325);
            this.TxtCariBarang.Name = "TxtCariBarang";
            this.TxtCariBarang.Size = new System.Drawing.Size(259, 29);
            this.TxtCariBarang.TabIndex = 5;
            this.TxtCariBarang.Text = "cari";
            // 
            // ListBarang
            // 
            this.ListBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListBarang.Location = new System.Drawing.Point(6, 40);
            this.ListBarang.Name = "ListBarang";
            this.ListBarang.Size = new System.Drawing.Size(397, 254);
            this.ListBarang.TabIndex = 0;
            // 
            // FBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 381);
            this.Controls.Add(this.TxtCariBarang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Form Data Barang ::";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbSatuan;
        private System.Windows.Forms.TextBox TxtStokBarang;
        private System.Windows.Forms.TextBox TxtHargaBarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNamaBarang;
        private System.Windows.Forms.TextBox TxtKodeBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnKeluar;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnBaru;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCariBarang;
        private System.Windows.Forms.DataGridView ListBarang;
    }
}