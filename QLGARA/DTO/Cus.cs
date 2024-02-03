using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DTO
{
        public class Cus
        {
            public Cus(string maKH, string tenKH, string NTNS, string SDT, string diaChi, string email)
            {
                this.maKH = maKH;
                this.tenKH = tenKH;
                this.NTNS = NTNS;
                this.SDT = SDT;
                this.diaChi = diaChi;
                this.email = email;
            }

            public Cus(DataRow row)
            {
                this.maKH = row["maKH"].ToString();
                this.tenKH = row["tenKH"].ToString();
                this.NTNS = row["NTNS"].ToString();
                this.SDT = row["SDT"].ToString();
                this.diaChi = row["diaChi"].ToString();
                this.email = row["email"].ToString();
        }


            private string maKH;

            public string MaKH
            {
                get { return maKH; }
                set { maKH = value; }
            }
        private string tenKH;

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        private string NTNS;

        public string ntns
        {
            get { return NTNS; }
            set { NTNS = value; }
        }

        private string SDT;

        public string sdt
        {
            get { return SDT; }
            set { SDT = value; }
        }

        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
