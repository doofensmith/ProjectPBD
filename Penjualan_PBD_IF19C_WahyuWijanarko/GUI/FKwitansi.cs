using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//tambah library
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Penjualan_PBD_IF19C_WahyuWijanarko.GUI {
    public partial class FKwitansi : Form {

        //variabel data
        private DataSet ds;
        private SqlDataAdapter da;

        //kelas koneksi
        Kelas.Koneksi konn = new Kelas.Koneksi();

        public FKwitansi() {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e) {
            //load kwitansi berdasarkan nomorkwitansi
            SqlConnection conn = konn.GetConn();
            conn.Open();
            da = new SqlDataAdapter("select * from View_Kwitansi where NomorKwitansi = '" +
            FTransaksi.ObjTransaksi.TxtNoKwitansi.Text + "'", conn);
            ds = new DataSet();
            da.Fill(ds, "View_Kwitansi");

            //memanggil report cetak kwitansi
            Laporan.CetakKwitansi myReport = new Laporan.CetakKwitansi();
            myReport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myReport;
            crystalReportViewer1.Refresh();
        }
    }
}
