using QLGARA.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DAO
{
    public class PTDAO
    {
        private static PTDAO instance;

        public static PTDAO Instance
        {
            get { if (instance == null) instance = new PTDAO(); return PTDAO.instance; }
            private set { PTDAO.instance = value; }
        }
        private PTDAO() { }
        public List<PT> GetListPT()
        {
            List<PT> list = new List<PT>();

            string query = "select * from PT";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PT pt = new PT(item);
                list.Add(pt);
            }

            return list;
        }
    }
}
