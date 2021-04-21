using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//library sqlserver
using System.Data.SqlClient;

namespace Penjualan_PBD_IF19C_WahyuWijanarko.GUI {

    public partial class FPelanggan : Form {

        //import kelas koneksi
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //variabel untuk proses crud
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        //membuat prosedur bersih
        void BERSIH() {
            TxtKodePelanggan.Clear();
            TxtNamaPelanggan.Clear();
            TxtAlamatPelanggan.Clear();
            TxtCariPelanggan.Clear();
        }

        //membat prosedur atur tombol
        void ATUR_TOMBOL(Boolean status) {
            BtnEdit.Enabled = status;
            BtnHapus.Enabled = status;
        }

        //membuat prosedur atur pelanggan
        void refresh_pelanggan() {
            SqlConnection conn = konn.GetConn();

            try {
                conn.Open();
                cmd = new SqlCommand("select * from pelanggan", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "pelanggan");
                ListPelanggan.DataSource = ds;
                ListPelanggan.DataMember = "pelanggan";
                ListPelanggan.Refresh();
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
            finally {
                conn.Close();
            }

        }

        public FPelanggan() {
            InitializeComponent();

            //panggil prosedur saat form pertama kali dijalankan
            BERSIH();
            ATUR_TOMBOL(false);
            refresh_pelanggan();
        }

        private void BtnBaru_Click(object sender, EventArgs e) {
            //memanggil prosedur bersih dan atur tombol
            BERSIH();
            TxtKodePelanggan.Focus();
            ATUR_TOMBOL(false);
            BtnSimpan.Enabled = true;
        }

        private void BtnSimpan_Click(object sender, EventArgs e) {
            //perintah simpan data pelanggan
            //kondisi jika ada teks kosong
            if (TxtKodePelanggan.Text.Trim() == "" || TxtNamaPelanggan.Text.Trim() == "" ||
                TxtAlamatPelanggan.Text.Trim() == "") {

                //menamilkan pesan bahwa data belum lengkap
                MessageBox.Show("Data belum lengkap, lengkapi data", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                //mempersiapkan sql connection
                SqlConnection conn = konn.GetConn();
                try {
                    //mempersiapkan sqlcommand yg akan dieksekusi
                    cmd = new SqlCommand("execute simpan_pelanggan '" + TxtKodePelanggan.Text + "','"
                        + TxtNamaPelanggan.Text + "','" + TxtAlamatPelanggan.Text + "'", conn);

                    //membuka koneksi database
                    conn.Open();

                    //menjalankan perintah query
                    cmd.ExecuteNonQuery();

                    //pesan berhasil disimpan
                    MessageBox.Show("Data berhasil disimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //peosedur bersih dan refresh pelanggan
                    BERSIH();
                    refresh_pelanggan();
                }
                catch (Exception x) {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void ListPelanggan_CellClick(object sender, DataGridViewCellEventArgs e) {
            //mengambil nilai record yang dipilih menjutu textbox
            try {
                BtnSimpan.Enabled = false;
                ATUR_TOMBOL(true);
                DataGridViewRow row = this.ListPelanggan.Rows[e.RowIndex];
                TxtKodePelanggan.Text = row.Cells[0].Value.ToString();
                TxtNamaPelanggan.Text = row.Cells[1].Value.ToString();
                TxtAlamatPelanggan.Text = row.Cells[2].Value.ToString();
            }
            catch (Exception x) {
                MessageBox.Show(x.ToString());
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e) {
            //edit data pelanggan
            if (TxtKodePelanggan.Text.Trim() == "" || TxtNamaPelanggan.Text.Trim() == "" ||
                TxtAlamatPelanggan.Text.Trim() == "") {

                MessageBox.Show("Data belum lengkap, lengkapi data", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                //mempersiapkan sql connection
                SqlConnection conn = konn.GetConn();
                try {
                    //mempersiapkan sqlcommand yg akan dieksekusi
                    cmd = new SqlCommand("execute ubah_pelanggan '" + TxtKodePelanggan.Text + "','"
                        + TxtNamaPelanggan.Text + "','" + TxtAlamatPelanggan.Text + "'", conn);

                    //membuka koneksi database
                    conn.Open();

                    //menjalankan perintah query
                    cmd.ExecuteNonQuery();

                    //pesan berhasil disimpan
                    MessageBox.Show("Data berhasil diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //peosedur bersih dan refresh barang
                    BERSIH();
                    refresh_pelanggan();

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
            //hapus data pelanggan
            if (MessageBox.Show("Yakin ingin menghapus data pelanggan ?",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                SqlConnection conn = konn.GetConn();
                cmd = new SqlCommand("execute hapus_pelanggan '" + TxtKodePelanggan.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BERSIH();
                refresh_pelanggan();

                //memanggil prosedur atur tombol
                ATUR_TOMBOL(false);
                BtnSimpan.Enabled = true;
            }
        }

        private void BtnKeluar_Click(object sender, EventArgs e) {
            //kluar form pelanggan
            Close();
        }

        private void TxtCariPelanggan_TextChanged(object sender, EventArgs e) {
            //cari nama pelanggan
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("execute cari_pelanggan '" + TxtCariPelanggan.Text + "'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "pelanggan");
            ListPelanggan.DataSource = ds;
            ListPelanggan.DataMember = "pelanggan";
            ListPelanggan.Refresh();
            conn.Close();

        }
    }
}
