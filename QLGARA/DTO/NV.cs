using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DTO
{
    internal class NV
    {
        public NV(string maNV, string tenNV, string NTNS, string SDT, string diaChi, string email)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.NTNS = NTNS;
            this.SDT = SDT;
            this.diaChi = diaChi;
            this.email = email;
        }

        public NV(DataRow row)
        {
            this.maNV = row["maNV"].ToString();
            this.tenNV = row["tenNV"].ToString();
            this.NTNS = row["NTNS"].ToString();
            this.SDT = row["SDT"].ToString();
            this.diaChi = row["diaChi"].ToString();
            this.email = row["email"].ToString();
        }


        private string maNV;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private string tenNV;

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
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
