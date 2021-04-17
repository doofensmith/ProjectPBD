namespace Penjualan_PBD_IF19C_WahyuWijanarko.GUI
{
    partial class FMenuUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_login = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_customer = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_selling = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolCustomer = new System.Windows.Forms.ToolStripButton();
            this.ToolItems = new System.Windows.Forms.ToolStripButton();
            this.ToolTransaction = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolExit = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuMaster,
            this.MenuTransaction,
            this.MenuTools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_login,
            this.submenu_logout,
            this.submenu_exit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "&File";
            // 
            // submenu_login
            // 
            this.submenu_login.Name = "submenu_login";
            this.submenu_login.Size = new System.Drawing.Size(152, 22);
            this.submenu_login.Text = "Login";
            this.submenu_login.Click += new System.EventHandler(this.submenu_login_Click);
            // 
            // submenu_logout
            // 
            this.submenu_logout.Name = "submenu_logout";
            this.submenu_logout.Size = new System.Drawing.Size(152, 22);
            this.submenu_logout.Text = "Logout";
            this.submenu_logout.Click += new System.EventHandler(this.submenu_logout_Click);
            // 
            // submenu_exit
            // 
            this.submenu_exit.Name = "submenu_exit";
            this.submenu_exit.Size = new System.Drawing.Size(152, 22);
            this.submenu_exit.Text = "Exit";
            this.submenu_exit.Click += new System.EventHandler(this.sub_menu_exit_Click);
            // 
            // MenuMaster
            // 
            this.MenuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_customer,
            this.submenu_item});
            this.MenuMaster.Name = "MenuMaster";
            this.MenuMaster.Size = new System.Drawing.Size(55, 20);
            this.MenuMaster.Text = "&Master";
            // 
            // submenu_customer
            // 
            this.submenu_customer.Name = "submenu_customer";
            this.submenu_customer.Size = new System.Drawing.Size(152, 22);
            this.submenu_customer.Text = "Customer";
            this.submenu_customer.Click += new System.EventHandler(this.submenu_customer_Click);
            // 
            // submenu_item
            // 
            this.submenu_item.Name = "submenu_item";
            this.submenu_item.Size = new System.Drawing.Size(152, 22);
            this.submenu_item.Text = "Item";
            this.submenu_item.Click += new System.EventHandler(this.submenu_item_Click);
            // 
            // MenuTransaction
            // 
            this.MenuTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_selling});
            this.MenuTransaction.Name = "MenuTransaction";
            this.MenuTransaction.Size = new System.Drawing.Size(79, 20);
            this.MenuTransaction.Text = "&Transaction";
            // 
            // submenu_selling
            // 
            this.submenu_selling.Name = "submenu_selling";
            this.submenu_selling.Size = new System.Drawing.Size(152, 22);
            this.submenu_selling.Text = "Selling";
            this.submenu_selling.Click += new System.EventHandler(this.submenu_selling_Click);
            // 
            // MenuTools
            // 
            this.MenuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_about});
            this.MenuTools.Name = "MenuTools";
            this.MenuTools.Size = new System.Drawing.Size(46, 20);
            this.MenuTools.Text = "T&ools";
            // 
            // submenu_about
            // 
            this.submenu_about.Name = "submenu_about";
            this.submenu_about.Size = new System.Drawing.Size(152, 22);
            this.submenu_about.Text = "About";
            this.submenu_about.Click += new System.EventHandler(this.submenu_about_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolCustomer,
            this.ToolItems,
            this.ToolTransaction,
            this.toolStripSeparator1,
            this.ToolExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(571, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolCustomer
            // 
            this.ToolCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolCustomer.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.admin64;
            this.ToolCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolCustomer.Name = "ToolCustomer";
            this.ToolCustomer.Size = new System.Drawing.Size(23, 22);
            this.ToolCustomer.Text = "ToolCustomer";
            this.ToolCustomer.ToolTipText = "Tampilkan data pelanggan";
            this.ToolCustomer.Click += new System.EventHandler(this.ToolCustomer_Click);
            // 
            // ToolItems
            // 
            this.ToolItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolItems.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.edit32;
            this.ToolItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItems.Name = "ToolItems";
            this.ToolItems.Size = new System.Drawing.Size(23, 22);
            this.ToolItems.Text = "toolStripButton2";
            this.ToolItems.ToolTipText = "Tampilkan data barang";
            this.ToolItems.Click += new System.EventHandler(this.ToolItems_Click);
            // 
            // ToolTransaction
            // 
            this.ToolTransaction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolTransaction.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.transaction64;
            this.ToolTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolTransaction.Name = "ToolTransaction";
            this.ToolTransaction.Size = new System.Drawing.Size(23, 22);
            this.ToolTransaction.Text = "toolStripButton3";
            this.ToolTransaction.ToolTipText = "Tampilkan data transaksi";
            this.ToolTransaction.Click += new System.EventHandler(this.ToolTransaction_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolExit
            // 
            this.ToolExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolExit.Image = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.exit64;
            this.ToolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolExit.Name = "ToolExit";
            this.ToolExit.Size = new System.Drawing.Size(23, 22);
            this.ToolExit.Text = "toolStripButton4";
            this.ToolExit.ToolTipText = "Keluar Aplikasi";
            this.ToolExit.Click += new System.EventHandler(this.ToolExit_Click);
            // 
            // FMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Penjualan_PBD_IF19C_WahyuWijanarko.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 287);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Sistem Informasi Penjualan Tekno Store ::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FMenuUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem MenuFile;
        public System.Windows.Forms.ToolStripMenuItem MenuMaster;
        public System.Windows.Forms.ToolStripMenuItem MenuTransaction;
        public System.Windows.Forms.ToolStripMenuItem MenuTools;
        public System.Windows.Forms.ToolStripMenuItem submenu_login;
        public System.Windows.Forms.ToolStripMenuItem submenu_logout;
        public System.Windows.Forms.ToolStripMenuItem submenu_exit;
        public System.Windows.Forms.ToolStripMenuItem submenu_customer;
        public System.Windows.Forms.ToolStripMenuItem submenu_item;
        public System.Windows.Forms.ToolStripMenuItem submenu_selling;
        public System.Windows.Forms.ToolStripMenuItem submenu_about;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton ToolCustomer;
        public System.Windows.Forms.ToolStripButton ToolItems;
        public System.Windows.Forms.ToolStripButton ToolTransaction;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton ToolExit;
    }
}