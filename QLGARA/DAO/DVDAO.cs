using QLGARA.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DAO
{
     public class DVDAO
    {
        private static DVDAO instance;

        public static DVDAO Instance
        {
            get { if (instance == null) instance = new DVDAO(); return DVDAO.instance; }
            private set { DVDAO.instance = value; }
        }
        private DVDAO() { }
        public List<DV> GetListDV()
        {
            List<DV> list = new List<DV>();

            string query = "select * from DV";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DV dv = new DV(item);
                list.Add(dv);
            }
            return list;
        }
    }
}
