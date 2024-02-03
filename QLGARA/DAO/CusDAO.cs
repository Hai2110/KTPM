using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGARA.DTO;

namespace QLGARA.DAO
{
    public class CusDAO
    {
        private static CusDAO instance;

        public static CusDAO Instance
        {
            get { if (instance == null) instance = new CusDAO(); return CusDAO.instance; }
            private set { CusDAO.instance = value; }
        }
        private CusDAO() { }
        public List<Cus> GetListCus()
        {
            List<Cus> list = new List<Cus>();

            string query = "select * from KH";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Cus cus = new Cus(item);
                list.Add(cus);
            }

            return list;
        }
    }
}
