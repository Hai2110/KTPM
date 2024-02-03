using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QLGARA.Class
{
    internal class Functions
    {
        public static SqlConnection Con;

        public static void Connect()
        {
            Con = new SqlConnection();
            Con.ConnectionString = "Data Source=ZERONU;Initial Catalog=Quanlygarage;Integrated Security=True";
            Con.Open();

            if (Con.State == ConnectionState.Open)
                MessageBox.Show("Ket noi thanh cong");
            else MessageBox.Show("Khong the ket noi voi du lieu");

        }

        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
                Con.Dispose();
                Con = null;
            }
        }
    }
}
