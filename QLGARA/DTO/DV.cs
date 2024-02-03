using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DTO
{
    public class DV
    {
        public DV(string maDV, string tenDV, string giaDV)
        {
            this.maDV = maDV;
            this.tenDV = tenDV;
            this.giaDV = giaDV;
        }

        public DV(DataRow row)
        {
            this.maDV = row["maDV"].ToString();
            this.tenDV = row["tenDV"].ToString();
            this.giaDV = row["giaDV"].ToString();
        }

        private string maDV;

        public string MaDV
        {
            get { return maDV; }
            set { maDV = value; }
        }
        private string tenDV;

        public string TenDV
        {
            get { return tenDV; }
            set { tenDV = value; }
        }
        private string giaDV;

        public string GiaDV
        {
            get { return giaDV; }
            set { giaDV = value; }
        }
    }
}
