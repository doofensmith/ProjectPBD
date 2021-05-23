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

    public partial class FCariBarang : Form {

        //variael untuk proses read data
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string kodebrg, namabrg, hargabrg = "";

        //import kelas koneks
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //prosedur refresh barang
        void refresh_barang() {

            SqlConnection conn = konn.GetConn();
            try {
                conn.Open();
                cmd = new SqlCommand("select * from barang", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "barang");
                DataGridBarang.DataSource = ds;
                DataGridBarang.DataMember = "barang";
                DataGridBarang.Refresh();
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
            finally {
                conn.Close();
            }

        }

        public FCariBarang() {
            InitializeComponent();
            //membersihkan komponen inputan dan panggil refresh barang
            TxtCariBarang.Clear();
            refresh_barang();
        }

        private void TxtCariBarang_TextChanged(object sender, EventArgs e) {
            //membuat perintah cari barang berdasarkan kode atau nama
            SqlConnection conn = konn.GetConn();
            cmd = new SqlCommand("select * from barang where NamaBarang like '%"+
            TxtCariBarang.Text+"%' or KodeBarang like '%"+TxtCariBarang.Text+"%'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "barang");
            DataGridBarang.DataSource = ds;
            DataGridBarang.DataMember = "barang";
            DataGridBarang.Refresh();
            conn.Close();
        }

        private void DataGridBarang_CellClick(object sender, DataGridViewCellEventArgs e) {
            //mengambil nilai yang dipilih ke variabel glbobal
            try {
                DataGridViewRow row = this.DataGridBarang.Rows[e.RowIndex];
                kodebrg = row.Cells[0].Value.ToString();
                namabrg = row.Cells[1].Value.ToString();
                hargabrg = row.Cells[2].Value.ToString();
                this.Close();
            }
            catch (Exception x) {
                MessageBox.Show(x.ToString());
            }
        }

        //membuat fungsi ambil kode barang
        public string ambil_kode_barang {
            get {
                return kodebrg;
            }
        }

        //fungsi ambil nama barang
        public string ambil_nama_barang {
            get {
                return namabrg;
            }
        }

        //fungsi ambil harga barang
        public string ambil_harga_barang {
            get {
                return hargabrg;
            }
        }


    }
}
