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

    public partial class FCariPelanggan : Form {

        //variael untuk proses read data
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string kodeplg, namaplg = "";

        //import kelas koneks
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //prosedur refresh pelanggan
        void refresh_pelanggan() {

            SqlConnection conn = konn.GetConn();
            try {
                conn.Open();
                cmd = new SqlCommand("select * from pelanggan", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "pelanggan");
                DataGridPelanggan.DataSource = ds;
                DataGridPelanggan.DataMember = "pelanggan";
                DataGridPelanggan.Refresh();
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
            finally {
                conn.Close();
            }

        }

        public FCariPelanggan() {
            InitializeComponent();
            //membersihkan komponen inputan dan panggil refresh pelanggan
            TxtCariPelanggan.Clear();
            refresh_pelanggan();
        }

        private void TxtCariPelanggan_TextChanged(object sender, EventArgs e) {
            //membuat perintah cari pelangan berdasarkan kode atau nama
            SqlConnection conn = konn.GetConn();
            cmd = new SqlCommand("select * from pelanggan where NamaPelanggan like '%" +
            TxtCariPelanggan.Text + "%' or KodePelanggan like '%" + TxtCariPelanggan.Text + "%'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "pelanggan");
            DataGridPelanggan.DataSource = ds;
            DataGridPelanggan.DataMember = "pelanggan";
            DataGridPelanggan.Refresh();
            conn.Close();
        }

        private void DataGridPelanggan_CellClick(object sender, DataGridViewCellEventArgs e) {
            //mengambil nilai yang dipilih ke variabel glbobal
            try {
                DataGridViewRow row = this.DataGridPelanggan.Rows[e.RowIndex];
                kodeplg = row.Cells[0].Value.ToString();
                namaplg = row.Cells[1].Value.ToString();
                this.Close();
            }
            catch (Exception x) {
                MessageBox.Show(x.ToString());
            }
        }

        //membuat fungsi ambil kode pelanggan
        public string ambil_kode_pelanggan {
            get {
                return kodeplg;
            }
        }

        //fungsi ambil nama pelangna
        public string ambil_nama_pelanggan {
            get {
                return namaplg;
            }
        }

    }
}
