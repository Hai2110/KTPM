using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DTO
{
    public class QL
    {
        public QL(string maQL, string tenQL, string NTNS, string SDT, string diaChi, string email)
        {
            this.maQL = maQL;
            this.tenQL = tenQL;
            this.NTNS = NTNS;
            this.SDT = SDT;
            this.diaChi = diaChi;
            this.email = email;
        }

        public QL(DataRow row)
        {
            this.maQL = row["maQL"].ToString();
            this.tenQL = row["tenQL"].ToString();
            this.NTNS = row["NTNS"].ToString();
            this.SDT = row["SDT"].ToString();
            this.diaChi = row["diaChi"].ToString();
            this.email = row["email"].ToString();
        }


        private string maQL;

        public string MaQL
        {
            get { return maQL; }
            set { maQL = value; }
        }
        private string tenQL;

        public string TenQL
        {
            get { return tenQL; }
            set { tenQL = value; }
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
