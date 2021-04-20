using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//library koneksi ke sql server
using System.Data.SqlClient;

namespace Penjualan_PBD_IF19C_WahyuWijanarko.Kelas {
    class Koneksi {

        public SqlConnection GetConn() {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-OUBEMH7; Initial Catalog=pbd_if19c_ww; Integrated Security=true";
            return conn;
        }

    }
}
