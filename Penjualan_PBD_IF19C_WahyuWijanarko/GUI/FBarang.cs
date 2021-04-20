using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//library sql server
using System.Data.SqlClient;

namespace Penjualan_PBD_IF19C_WahyuWijanarko.GUI {

    public partial class FBarang : Form {

        //import kelas koneksi
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //variabel untuk proses crud
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        //prosedur bersih
        void BERSIH() {
            TxtKodeBarang.Clear();
            TxtNamaBarang.Clear();
            TxtHargaBarang.Clear();
            TxtStokBarang.Clear();
            CmbSatuan.Text = "-Pilih Satuan-";
            TxtCariBarang.Clear();
        }

        //prosedur atur tombol
        void ATUR_TOMBOL(Boolean status) {
            BtnEdit.Enabled = status;
            BtnHapus.Enabled = status;
        }

        //prosedur refresh barang
        void refresh_barang() {
            SqlConnection conn = konn.GetConn();

            try {
                conn.Open();
                cmd = new SqlCommand("select * from barang", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "barang");
                ListBarang.DataSource = ds;
                ListBarang.DataMember = "barang";
                ListBarang.Refresh();
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
            finally {
                conn.Close();
            }

        }

        public FBarang() {
            InitializeComponent();

            //memanggil prosedur saat form dijalankan
            BERSIH();
            ATUR_TOMBOL(false);
            refresh_barang();
        }

        private void BtnBaru_Click(object sender, EventArgs e) {
            //koding tombol baru
            BERSIH();
            TxtKodeBarang.Focus();
            ATUR_TOMBOL(false);
            BtnSimpan.Enabled = true;
        }

        private void BtnSimpan_Click(object sender, EventArgs e) {
            //perintah simpan data barang
            //kondisi jika ada teks kosong
            if (TxtKodeBarang.Text.Trim() == "" || TxtNamaBarang.Text.Trim() == "" ||
                TxtHargaBarang.Text.Trim() == "" || TxtStokBarang.Text.Trim() == "" ||
                CmbSatuan.Text.Trim() == "") {

                //menamilkan pesan bahwa data belum lengkap
                MessageBox.Show("Data belum lengkap, lengkapi data", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                //mempersiapkan sql connection
                SqlConnection conn = konn.GetConn();
                try {
                    //mempersiapkan sqlcommand yg akan dieksekusi
                    cmd = new SqlCommand("execute simpan_barang '" + TxtKodeBarang.Text + "','"
                        + TxtNamaBarang.Text + "','" + TxtHargaBarang.Text + "','"
                        + TxtStokBarang.Text + "','" + CmbSatuan.Text + "'", conn);

                    //membuka koneksi database
                    conn.Open();

                    //menjalankan perintah query
                    cmd.ExecuteNonQuery();

                    //pesan berhasil disimpan
                    MessageBox.Show("Data berhasil disimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //peosedur bersih dan refresh barang
                    BERSIH();
                    refresh_barang();
                }
                catch (Exception x) {
                    MessageBox.Show(x.ToString());
                }
            }

        }

        private void ListBarang_CellClick(object sender, DataGridViewCellEventArgs e) {
            //mengambil nilai yang dipilih
            try {
                BtnSimpan.Enabled = false;
                ATUR_TOMBOL(true);
                DataGridViewRow row = this.ListBarang.Rows[e.RowIndex];
                TxtKodeBarang.Text = row.Cells[0].Value.ToString();
                TxtNamaBarang.Text = row.Cells[1].Value.ToString();
                TxtHargaBarang.Text = row.Cells[2].Value.ToString();
                TxtStokBarang.Text = row.Cells[3].Value.ToString();
                CmbSatuan.Text = row.Cells[4].Value.ToString();

            }
            catch (Exception x) {
                MessageBox.Show(x.ToString());
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e) {
            //edit data barang
            if (TxtKodeBarang.Text.Trim() == "" || TxtNamaBarang.Text.Trim() == "" ||
                TxtHargaBarang.Text.Trim() == "" || TxtStokBarang.Text.Trim() == "" ||
                CmbSatuan.Text.Trim() == "") {

                MessageBox.Show("Data belum lengkap, lengkapi data", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                //mempersiapkan sql connection
                SqlConnection conn = konn.GetConn();
                try {
                    //mempersiapkan sqlcommand yg akan dieksekusi
                    cmd = new SqlCommand("execute ubah_barang '" + TxtNamaBarang.Text + "','"
                        + TxtHargaBarang.Text + "','" + TxtStokBarang.Text + "','"
                        + CmbSatuan.Text + "','" + TxtKodeBarang.Text + "'", conn);

                    //membuka koneksi database
                    conn.Open();

                    //menjalankan perintah query
                    cmd.ExecuteNonQuery();

                    //pesan berhasil disimpan
                    MessageBox.Show("Data berhasil diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //peosedur bersih dan refresh barang
                    BERSIH();
                    refresh_barang();

                    //prosedur atur tombol
                    ATUR_TOMBOL(false);
                    BtnSimpan.Enabled = true;
                }
                catch (Exception x) {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e) {
            //hapus data barang
            if (MessageBox.Show("Yakin ingin menghapus data barang ?",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                SqlConnection conn = konn.GetConn();
                cmd = new SqlCommand("execute hapus_barang '" + TxtKodeBarang.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BERSIH();
                refresh_barang();
                ATUR_TOMBOL(false);
                BtnSimpan.Enabled = true;
            }
        }

        private void BtnKeluar_Click(object sender, EventArgs e) {
            //keluar dari form barang
            Close();
        }

        private void TxtCariBarang_TextChanged(object sender, EventArgs e) {
            //cari nama barang
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("execute cari_barang '" + TxtCariBarang.Text + "'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "barang");
            ListBarang.DataSource = ds;
            ListBarang.DataMember = "barang";
            ListBarang.Refresh();
            conn.Close();
        }
    }
}
