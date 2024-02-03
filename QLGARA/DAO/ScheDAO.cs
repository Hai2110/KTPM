using QLGARA.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DAO
{
    public class ScheDAO
    {
        private static ScheDAO instance;

        public static ScheDAO Instance
        {
            get { if (instance == null) instance = new ScheDAO(); return ScheDAO.instance; }
            private set { ScheDAO.instance = value; }
        }
        private ScheDAO() { }
        public List<Sche> GetListSche()
        {
            List<Sche> list = new List<Sche>();

            string query = "select * from Lich";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Sche sche = new Sche(item);
                list.Add(sche);
            }

            return list;
        }
    }
}
