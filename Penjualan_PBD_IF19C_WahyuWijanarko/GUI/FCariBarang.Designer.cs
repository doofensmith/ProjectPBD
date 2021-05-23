namespace Penjualan_PBD_IF19C_WahyuWijanarko.GUI
{
    partial class FCariBarang
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
            this.DataGridBarang = new System.Windows.Forms.DataGridView();
            this.TxtCariBarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGridBarang);
            this.groupBox1.Controls.Add(this.TxtCariBarang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".:: Data Barang ::.";
            // 
            // DataGridBarang
            // 
            this.DataGridBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridBarang.Location = new System.Drawing.Point(9, 82);
            this.DataGridBarang.Name = "DataGridBarang";
            this.DataGridBarang.Size = new System.Drawing.Size(397, 144);
            this.DataGridBarang.TabIndex = 2;
            this.DataGridBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridBarang_CellClick);
            // 
            // TxtCariBarang
            // 
            this.TxtCariBarang.Location = new System.Drawing.Point(9, 51);
            this.TxtCariBarang.Name = "TxtCariBarang";
            this.TxtCariBarang.Size = new System.Drawing.Size(397, 25);
            this.TxtCariBarang.TabIndex = 1;
            this.TxtCariBarang.TextChanged += new System.EventHandler(this.TxtCariBarang_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Berdasarkan Kode/Nama Barang :";
            // 
            // FCariBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 258);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FCariBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Cari Barang ::";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGridBarang;
        private System.Windows.Forms.TextBox TxtCariBarang;
        private System.Windows.Forms.Label label1;
    }
}