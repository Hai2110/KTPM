using QLGARA.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DAO
{
    public class PHDAO
    {
        private static PHDAO instance;

        public static PHDAO Instance
        {
            get { if (instance == null) instance = new PHDAO(); return PHDAO.instance; }
            private set { PHDAO.instance = value; }
        }
        private PHDAO() { }
        public List<PH> GetListPH()
        {
            List<PH> list = new List<PH>();

            string query = "select * from PhieuHen";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PH ph = new PH(item);
                list.Add(ph);
            }

            return list;
        }
    }
}
