using QLGARA.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DAO
{
    public class QLDAO
    {
        private static QLDAO instance;

        public static QLDAO Instance
        {
            get { if (instance == null) instance = new QLDAO(); return QLDAO.instance; }
            private set { QLDAO.instance = value; }
        }
        private QLDAO() { }
        public List<QL> GetListQL()
        {
            List<QL> list = new List<QL>();

            string query = "select * from QL";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                QL ql = new QL(item);
                list.Add(ql);
            }

            return list;
        }
    }
}
