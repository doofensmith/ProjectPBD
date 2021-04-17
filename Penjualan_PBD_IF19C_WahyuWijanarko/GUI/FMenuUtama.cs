using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penjualan_PBD_IF19C_WahyuWijanarko.GUI {
    public partial class FMenuUtama : Form {

        //Membuat variabel/objek dari form terkait
        public static FMenuUtama mdiobj;
        FAboutProgrammer aboutprog;
        FPelanggan plg;
        FBarang brg;
        FTransaksi trx;

        //Membuat prosedur event form closed
        void Proc_AboutProgrammerClosed(Object sender, FormClosedEventArgs e) {
            aboutprog = null;
        }

        void Proc_PelangganClosed(Object sender, FormClosedEventArgs e) {
            plg = null;
        }

        void Proc_BarangClosed(Object sender, FormClosedEventArgs e) {
            brg = null;
        }

        void Proc_TransaksiClosed(Object sender, FormClosedEventArgs e) {
            trx = null;
        }
        

        public FMenuUtama() {
            InitializeComponent();

        }

        private void sub_menu_exit_Click(object sender, EventArgs e) {
            //membuat kode keluar aplikasi
            if (MessageBox.Show("Keluar Dari Aplikasi Penjualan ?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                    Application.Exit();

            }

        }

        private void ToolExit_Click(object sender, EventArgs e) {
            //memanggil kode dari event click pada menu exit
            sub_menu_exit_Click(sender, e);
        }

        private void submenu_customer_Click(object sender, EventArgs e) {
            //Memanggil form pelanggan
            if (plg == null) {
                plg = new FPelanggan();
                plg.MdiParent = this;
                plg.FormClosed += new FormClosedEventHandler(Proc_PelangganClosed);
                plg.Show();
            }
            else {
                plg.Activate();
            }
        }

        private void ToolCustomer_Click(object sender, EventArgs e) {
            //memanggil kode di menu customer
            submenu_customer_Click(sender, e);
        }

        private void submenu_item_Click(object sender, EventArgs e) {
            //Memanggil form barang
            if (brg == null) {
                brg = new FBarang();
                brg.MdiParent = this;
                brg.FormClosed += new FormClosedEventHandler(Proc_BarangClosed);
                brg.Show();
            }
            else {
                brg.Activate();
            }
        }

        private void ToolItems_Click(object sender, EventArgs e) {
            //memanggil kode di menu item
            submenu_item_Click(sender, e);
        }

        private void submenu_about_Click(object sender, EventArgs e) {
            //memanggil form about programmer
            if (aboutprog == null) {
                aboutprog = new FAboutProgrammer();
                aboutprog.MdiParent = this;
                aboutprog.FormClosed += new FormClosedEventHandler(Proc_AboutProgrammerClosed);
                aboutprog.Show();
            }
            else {
                aboutprog.Activate();
            }

        }

        private void submenu_selling_Click(object sender, EventArgs e) {
            //memanggil form transakti
            if (trx == null) {
                trx = new FTransaksi();
                trx.MdiParent = this;
                trx.FormClosed += new FormClosedEventHandler(Proc_TransaksiClosed);
                trx.Show();
            }
            else {
                trx.Activate();
            }

        }

        private void ToolTransaction_Click(object sender, EventArgs e) {
            //memanggil kode menu transaksi
            submenu_selling_Click(sender, e);
        }

        private void FMenuUtama_Load(object sender, EventArgs e) {
            //non aktifkan beberapa menu saat menu utama aktif
            MenuMaster.Enabled = false;
            MenuTransaction.Enabled = false;
            submenu_logout.Enabled = false;
            submenu_login.Enabled = true;
            ToolCustomer.Enabled = false;
            ToolItems.Enabled = false;
            ToolTransaction.Enabled = false;

            //memberiakn nilai untuk mdiobj adalah FMenuUtama
            mdiobj = this;

            //menamilpakn form login
            FLogin login = new FLogin();
            login.ShowDialog();
        }

        private void submenu_logout_Click(object sender, EventArgs e) {
            //non aktifkan beberapa menu saat logout
            MenuMaster.Enabled = false;
            MenuTransaction.Enabled = false;
            submenu_logout.Enabled = false;
            submenu_login.Enabled = true;
            ToolCustomer.Enabled = false;
            ToolItems.Enabled = false;
            ToolTransaction.Enabled = false;
        }

        private void submenu_login_Click(object sender, EventArgs e) {
            //memanggil form login dari menu login
            FLogin login = new FLogin();
            login.ShowDialog();
        }

        
    }
}
