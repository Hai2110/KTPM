using QLGARA.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DAO
{
    internal class HDDAO
    {
        private static HDDAO instance;

        public static HDDAO Instance
        {
            get { if (instance == null) instance = new HDDAO(); return HDDAO.instance; }
            private set { HDDAO.instance = value; }
        }
        private HDDAO() { }
        public List<HD> GetListHD()
        {
            List<HD> list = new List<HD>();

            string query = "select * from HoaDon";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HD hd = new HD(item);
                list.Add(hd);
            }

            return list;
        }
    }
}
