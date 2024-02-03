using QLGARA.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DAO
{
    internal class NVDAO
    {
        private static NVDAO instance;

        public static NVDAO Instance
        {
            get { if (instance == null) instance = new NVDAO(); return NVDAO.instance; }
            private set { NVDAO.instance = value; }
        }
        private NVDAO() { }
        public List<NV> GetListNV()
        {
            List<NV> list = new List<NV>();

            string query = "select * from NV";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NV nv = new NV(item);
                list.Add(nv);
            }

            return list;
        }
    }
}
