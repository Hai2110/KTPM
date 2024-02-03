using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DTO
{
    public class HD
    {
        public HD(string maHoaDon, string tienTra, string ngayXuatDon)
        {
            this.maHoaDon = maHoaDon;
            this.tienTra = tienTra;
            this.ngayXuatDon = ngayXuatDon;

        }

        public HD(DataRow row)
        {
            this.maHoaDon = row["maHoaDon"].ToString();
            this.tienTra = row["tienTra"].ToString();
            this.ngayXuatDon = row["ngayXuatDon"].ToString();

        }


        private string maHoaDon;

        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
        private string tienTra;

        public string TienTra
        {
            get { return tienTra; }
            set { tienTra = value; }
        }
        private string ngayXuatDon;

        public string NgayXuatDon
        {
            get { return ngayXuatDon; }
            set { ngayXuatDon = value; }
        }

    }
}
