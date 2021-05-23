using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//libray sqlserver
using System.Data.SqlClient;
using System.Globalization;

namespace Penjualan_PBD_IF19C_WahyuWijanarko.GUI {

    public partial class FTransaksi : Form {

        //import kelas koneksi
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //variabel untuk sql
        private SqlCommand cmd;
        private SqlDataReader rd;
        private DataSet ds;
        private SqlDataAdapter da;

        //prosedur bersih
        private void Bersih() {
            TxtNoKwitansi.Text = "";
            DtpTanggalKwitansi.Value = DateTime.Now;
            TxtKodePelanggan.Text = "";
            TxtNamaPelanggan.Text = "";
            TxtKodeBarang.Text = "";
            TxtNamaBarang.Text = "";
            TxtHargaBarang.Text = "";
            TxtJumlahJual.Text = "";
            LblTotalBayar.Text = "Rp. -";
        }

        //prosedr awal
        private void awal() {
            //panggil prosedur bersih
            Bersih();
            //mennaktifkan data grid penjualan
            DataGridPenjualan.Enabled = false;
            SqlConnection conn = konn.GetConn();
            {
                try {
                    conn.Open();
                    cmd = new SqlCommand("select * from kwitansi order by NomorKwitansi desc", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "kwitansi");
                    DataGridPenjualan.DataSource = ds;
                    DataGridPenjualan.DataMember = "kwitansi";
                    DataGridPenjualan.Refresh();
                }
                catch (Exception e) {
                    MessageBox.Show(e.ToString());
                }
                finally {
                    conn.Close();
                }
            }

        }

        //prosedur auto number
        private void auto_number() {

            long hitung;
            string urut;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select NomorKwitansi from kwitansi where NomorKwitansi in(select max(NomorKwitansi) from kwitansi) order by NomorKwitansi desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();

            //jika suda ada data transaksi
            if (rd.HasRows) {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["NomorKwitansi"].ToString().Length - 4, 4)) + 1;
                string joinstr = "0000" + hitung;
                urut = "K" + joinstr.Substring(joinstr.Length - 4, 4);
            }
            //jika belum ada data transaksi
            else {
                urut = "K0001";
            }
            rd.Close();
            TxtNoKwitansi.Text = urut;
            conn.Close();

        }

        //prosedur simpan master penjualan
        private void Simpan_MasterPenjualan() {
            //sql conncetion
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("execute simpan_kwitansi '" + TxtNoKwitansi.Text + "','" +
                DtpTanggalKwitansi.Text + "','" + TxtKodePelanggan.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            
        }

        //prosedur simpan detail penjualan
        private void Simpan_DetailPenjualan() {
            //sql conncetion
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("execute simpan_detailkwitansi '" + TxtNoKwitansi.Text + "','" +
                TxtKodeBarang.Text + "','" + TxtJumlahJual.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            
        }

        //prosedur refresh penjualan
        private void refresh_penjualan() {
            //get connection
            SqlConnection conn = konn.GetConn();
            {
                try {
                    conn.Open();
                    cmd = new SqlCommand("select * from view_detailkwitansi where NomorKwitansi = '" +
                    TxtNoKwitansi.Text + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "view_detailkwitansi");
                    DataGridPenjualan.DataSource = ds;
                    DataGridPenjualan.DataMember = "view_detailkwitansi";
                    DataGridPenjualan.Refresh();
                }
                catch (Exception e) {
                    MessageBox.Show(e.ToString());
                }
                finally {
                    conn.Close();
                }
            }
            
        }

        //prosedur refresh transaksi per barang
        private void RefreshTransaksi() {
            //memanggil proc refresh penjualan
            refresh_penjualan();

            TxtKodeBarang.Clear();
            TxtNamaBarang.Clear();
            TxtHargaBarang.Clear();
            TxtJumlahJual.Clear();
            TxtKodeBarang.Focus();
        }

        //prosedur refresh total seluruh
        private void totalseluruh() {

            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                cmd = new SqlCommand("select sum(JumlahBayar) as TotalBayar from view_detailkwitansi where NomorKwitansi = '" +
                TxtNoKwitansi.Text + "'", conn);
                cmd.Connection = conn;
                int result = ((int)cmd.ExecuteScalar());
                String TotalSeluruh = result.ToString();
                LblTotalBayar.Text = "Rp. " + result.ToString("N",new CultureInfo("id-ID"));
                conn.Close();
            }
            
        }

        public FTransaksi() {
            InitializeComponent();
            //memanggil prosedur awal
            awal();
        }

        private void BtnBrowsePelanggan_Click(object sender, EventArgs e) {
            //memanggil form cari pelanggan
            FCariPelanggan cariplg = new FCariPelanggan();
            cariplg.ShowDialog();
            TxtKodePelanggan.Text = cariplg.ambil_kode_pelanggan;
            TxtNamaPelanggan.Text = cariplg.ambil_nama_pelanggan;
            TxtKodeBarang.Focus();
        }

        private void BtnBrowseBarang_Click(object sender, EventArgs e) {
            //memanggil form cari barang
            FCariBarang caribrg = new FCariBarang();
            caribrg.ShowDialog();
            TxtKodeBarang.Text = caribrg.ambil_kode_barang;
            TxtNamaBarang.Text = caribrg.ambil_nama_barang;
            TxtHargaBarang.Text = caribrg.ambil_harga_barang;
            TxtJumlahJual.Focus();
        }

        private void BtnBaru_Click(object sender, EventArgs e) {
            //menaggill prosedur awal, auto number
            awal();
            auto_number();
            DtpTanggalKwitansi.Focus();
        }

        private void BtnTambah_Click(object sender, EventArgs e) {
            //simpan data penjualan per barang
            DataGridPenjualan.Enabled = true;
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                //jika ada data yang kosong
                if (TxtNoKwitansi.Text.Trim() == "" || TxtKodePelanggan.Text.Trim() == "" ||
                    TxtKodeBarang.Text.Trim() == "" || TxtJumlahJual.Text.Trim() == "0") {

                    //pesan data belum lengkap
                    MessageBox.Show("Data belum lengkap, lengkapi data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //jika data sudah terisi
                else {
                    conn.Open();
                    cmd = new SqlCommand("select * from kwitansi where NomorKwitansi = '" +
                    TxtNoKwitansi.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    //jika data penjualan sudah ada
                    if (reader.Read()) {
                        //refresh koneksi
                        conn.Close();
                        conn.Open();

                        cmd = new SqlCommand("select * from detail_kwitansi where NomorKwitansi = '" +
                        TxtNoKwitansi.Text + "' and KodeBarang = '" + TxtKodeBarang.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        reader = cmd.ExecuteReader();
                        //jika data barang sudah diinputkan ke tabel detail kwitansi
                        if (reader.Read()) {
                            MessageBox.Show("Data barang " + TxtNamaBarang.Text + " sudah diinputkan, harap pilih barang yang lain", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        //jika data barang belum diinputkan ke tabel
                        else {
                            //panggil prosedur detail penjulana
                            Simpan_DetailPenjualan();
                            //panggil prosedur total seluruh
                            totalseluruh();
                        }

                    }
                    //jika data penjualan belum ada
                    else {
                        //panggil prosedur simpan master dan detail penjualan
                        Simpan_MasterPenjualan();
                        Simpan_DetailPenjualan();
                        //panggil prosedur totalseluruh
                        totalseluruh();
                    }
                    //panggil prosedur refresh transaksi
                    RefreshTransaksi();

                }
            }     

        }

        private void BtnKurang_Click(object sender, EventArgs e) {
            //hapus data penjualan per barang
            //koneksi database
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                //kueri menghapus data berdasar NomorKwitansi dan KodeBarang pada tbl detail
                cmd = new SqlCommand("execute hapus_detailkwitansi '" + TxtNoKwitansi.Text + "','" +
                TxtKodeBarang.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                //cek data di detail kwitansi
                cmd = new SqlCommand("select * from detail_kwitansi where NomorKwitansi = '" +
                TxtNoKwitansi.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                //jika ada data
                if (reader.Read()) {
                    //panggil prosedur total seluruh
                    totalseluruh();
                }
                //jika belum ada data
                else {
                    LblTotalBayar.Text = "Rp. -";
                }
                //refresh tanssaksi
                RefreshTransaksi();
            }           

        }

        private void DataGridPenjualan_CellClick(object sender, DataGridViewCellEventArgs e) {
            //tampilkan data penjualan er barang
            DataGridViewRow row = this.DataGridPenjualan.Rows[e.RowIndex];
            TxtKodeBarang.Text = row.Cells["KodeBarang"].Value.ToString();
            TxtNamaBarang.Text = row.Cells["NamaBarang"].Value.ToString();
            TxtHargaBarang.Text = row.Cells["HargaBarang"].Value.ToString();
            TxtJumlahJual.Text = row.Cells["JumlahJual"].Value.ToString();
        }

        private void BtnSimpan_Click(object sender, EventArgs e) {
            //jika data grid kosong
            if (LblTotalBayar.Text=="Rp. -" && TxtNoKwitansi.Text != null) {
                SqlConnection conn = konn.GetConn();
                cmd = new SqlCommand("delete from kwitansi where NomorKwitansi = '" +
                TxtNoKwitansi.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            //transaksi selesai
            MessageBox.Show("Transaksi Selesai");
            awal();
        }

        private void BtnKeluar_Click(object sender, EventArgs e) {
            //keluar form transaksi
            Close();
        }

    }
}
