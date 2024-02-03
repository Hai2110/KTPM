using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLGARA.DAO;
using QLGARA.DTO;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Numerics;
using QLGARA.Class;


namespace QLGARA
{
    public partial class fHoaDon : Form
    {
        DataTable tblCTHD;

        public fHoaDon()
        {
            InitializeComponent();
        }

        private void fHoaDon_Load(object sender, EventArgs e)
        {

        }

        // Nap du lieu len Datagrid
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT *FROM dbo.HoaDon";
           // tblCTHD = Functions.GetDataToTable(sql);
        }

        private void dataGridViewHoaDon_Click(object sender, EventArgs e)
        {
            
        }
    }
}
