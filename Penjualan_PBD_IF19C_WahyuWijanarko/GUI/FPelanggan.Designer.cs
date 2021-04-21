namespace Penjualan_PBD_IF19C_WahyuWijanarko.GUI
{
    partial class FPelanggan
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
            this.TxtCariPelanggan = new System.Windows.Forms.TextBox();
            this.ListPelanggan = new System.Windows.Forms.DataGridView();
            this.TxtAlamatPelanggan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNamaPelanggan = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.TxtKodePelanggan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnKeluar = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnBaru = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListPelanggan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCariPelanggan
            // 
            this.TxtCariPelanggan.Location = new System.Drawing.Point(600, 325);
            this.TxtCariPelanggan.Name = "TxtCariPelanggan";
            this.TxtCariPelanggan.Size = new System.Drawing.Size(236, 29);
            this.TxtCariPelanggan.TabIndex = 11;
            this.TxtCariPelanggan.Text = "cari";
            this.TxtCariPelanggan.TextChanged += new System.EventHandler(this.TxtCariPelanggan_TextChanged);
            // 
            // ListPelanggan
            // 
            this.ListPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListPelanggan.Location = new System.Drawing.Point(6, 37);
            this.ListPelanggan.Name = "ListPelanggan";
            this.ListPelanggan.Size = new System.Drawing.Size(397, 254);
            this.ListPelanggan.TabIndex = 0;
            this.ListPelanggan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListPelanggan_CellClick);
            // 
            // TxtAlamatPelanggan
            // 
            this.TxtAlamatPelanggan.Location = new System.Drawing.Point(146, 109);
            this.TxtAlamatPelanggan.Multiline = true;
            this.TxtAlamatPelanggan.Name = "TxtAlamatPelanggan";
            this.TxtAlamatPelanggan.Size = new System.Drawing.Size(250, 121);
            this.TxtAlamatPelanggan.TabIndex = 7;
            this.TxtAlamatPelanggan.Text = "alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alamat Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Pelanggan";
            // 
            // TxtNamaPelanggan
            // 
            this.TxtNamaPelanggan.Location = new System.Drawing.Point(146, 73);
            this.TxtNamaPelanggan.Name = "TxtNamaPelanggan";
            this.TxtNamaPelanggan.Size = new System.Drawing.Size(250, 29);
            this.TxtNamaPelanggan.TabIndex = 2;
            this.TxtNamaPelanggan.Text = "nama";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListPelanggan);
            this.groupBox2.Location = new System.Drawing.Point(427, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 300);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ".:: List Data Pelanggan ::";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnSimpan);
            this.panel2.Location = new System.Drawing.Point(253, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 108);
            this.panel2.TabIndex = 8;
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSimpan.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.save32;
            this.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSimpan.Location = new System.Drawing.Point(11, 10);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(145, 88);
            this.BtnSimpan.TabIndex = 0;
            this.BtnSimpan.Text = "&Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // TxtKodePelanggan
            // 
            this.TxtKodePelanggan.Location = new System.Drawing.Point(146, 37);
            this.TxtKodePelanggan.Name = "TxtKodePelanggan";
            this.TxtKodePelanggan.Size = new System.Drawing.Size(121, 29);
            this.TxtKodePelanggan.TabIndex = 1;
            this.TxtKodePelanggan.Text = "abcde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cari Nama Pelanggan :";
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
            this.panel1.TabIndex = 7;
            // 
            // BtnKeluar
            // 
            this.BtnKeluar.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.exit16;
            this.BtnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKeluar.Location = new System.Drawing.Point(120, 58);
            this.BtnKeluar.Name = "BtnKeluar";
            this.BtnKeluar.Size = new System.Drawing.Size(104, 41);
            this.BtnKeluar.TabIndex = 3;
            this.BtnKeluar.Text = "&Keluar";
            this.BtnKeluar.UseVisualStyleBackColor = true;
            this.BtnKeluar.Click += new System.EventHandler(this.BtnKeluar_Click);
            // 
            // BtnHapus
            // 
            this.BtnHapus.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.delete16;
            this.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHapus.Location = new System.Drawing.Point(10, 58);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(104, 41);
            this.BtnHapus.TabIndex = 2;
            this.BtnHapus.Text = "&Hapus";
            this.BtnHapus.UseVisualStyleBackColor = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.edit16;
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.Location = new System.Drawing.Point(120, 11);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(104, 41);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "&Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnBaru
            // 
            this.BtnBaru.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.add16;
            this.BtnBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBaru.Location = new System.Drawing.Point(10, 11);
            this.BtnBaru.Name = "BtnBaru";
            this.BtnBaru.Size = new System.Drawing.Size(104, 41);
            this.BtnBaru.TabIndex = 0;
            this.BtnBaru.Text = "&Baru";
            this.BtnBaru.UseVisualStyleBackColor = true;
            this.BtnBaru.Click += new System.EventHandler(this.BtnBaru_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtAlamatPelanggan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNamaPelanggan);
            this.groupBox1.Controls.Add(this.TxtKodePelanggan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 243);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".:: Input Data Pelanggan ::.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Pelanggan";
            // 
            // FPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 382);
            this.Controls.Add(this.TxtCariPelanggan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Form Pelanggan ::";
            ((System.ComponentModel.ISupportInitialize)(this.ListPelanggan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCariPelanggan;
        private System.Windows.Forms.DataGridView ListPelanggan;
        private System.Windows.Forms.TextBox TxtAlamatPelanggan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNamaPelanggan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnBaru;
        private System.Windows.Forms.TextBox TxtKodePelanggan;
        private System.Windows.Forms.Button BtnKeluar;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}