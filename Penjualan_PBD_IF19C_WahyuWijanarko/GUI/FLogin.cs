using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//library sql client
using System.Data.SqlClient;

namespace Penjualan_PBD_IF19C_WahyuWijanarko.GUI {

    public partial class FLogin : Form {

        //variabel cmd untuk menampung perintah sql
        private SqlCommand cmd;

        //mport kelas koneksi
        Kelas.Koneksi konn = new Kelas.Koneksi();

        public FLogin() {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e) {
            //coding button login
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_login where username = '" + TxtUserName.Text + "' and password = '" + TxtPassword.Text + "'", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            //jika user dan password benar
            if (reader.Read()) {
                MessageBox.Show("Login Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FMenuUtama.mdiobj.MenuMaster.Enabled = true;
                FMenuUtama.mdiobj.MenuTransaction.Enabled = true;
                FMenuUtama.mdiobj.submenu_logout.Enabled = true;
                FMenuUtama.mdiobj.submenu_login.Enabled = false;
                FMenuUtama.mdiobj.ToolCustomer.Enabled = true;
                FMenuUtama.mdiobj.ToolItems.Enabled = true;
                FMenuUtama.mdiobj.ToolTransaction.Enabled = true;

                //form login keluar
                this.Close();
            }
            //jika user atau password salah
            else {
                MessageBox.Show("Username atau Password Salah !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                TxtUserName.Text = "";
                TxtPassword.Text = "";
                TxtUserName.Focus();
            }

            //tutup koneksi
            conn.Close();

        }

        private void BtnBatal_Click(object sender, EventArgs e) {
            //keluar form login
            this.Close();
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e) {
            //event pada tombol enter
            if (e.KeyChar == 13) {
                BtnLogin_Click(sender, e);
            }
        }
    }
}
