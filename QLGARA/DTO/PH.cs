using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DTO
{
    public class PH
    {
        public PH(string maPhieu, string lydoHen, string ngayDat, string ngayTra, string hinhthucTra, string tongTienCoc, string bienSoXe, string maLich, string maHoaDon)
        {
            this.maPhieu = maPhieu;
            this.lydoHen = lydoHen;
            this.ngayDat = ngayDat;
            this.ngayTra = ngayTra;
            this.hinhthucTra = hinhthucTra;
            this.tongTienCoc = tongTienCoc;
            this.bienSoXe = bienSoXe;
            this.maLich = maLich;
            this.maHoaDon = maHoaDon;
        }

        public PH(DataRow row)
        {
            this.maPhieu = row["maPhieu"].ToString();
            this.lydoHen = row["lydoHen"].ToString();
            this.ngayDat = row["ngayDat"].ToString();
            this.ngayTra = row["ngayTra"].ToString();
            this.hinhthucTra = row["hinhthucTra"].ToString();
            this.tongTienCoc = row["tongTienCoc"].ToString();
            this.bienSoXe = row["bienSoXe"].ToString();
            this.maLich = row["maLich"].ToString();
            this.maHoaDon = row["maHoaDon"].ToString();
        }


        private string maPhieu;

        public string MaPhieu
        {
            get { return maPhieu; }
            set { maPhieu = value; }
        }
        private string lydoHen;

        public string LydoHen
        {
            get { return lydoHen; }
            set { lydoHen = value; }
        }
        private string ngayDat;

        public string NgayDat
        {
            get { return ngayDat; }
            set { ngayDat = value; }
        }

        private string ngayTra;

        public string NgayTra
        {
            get { return ngayTra; }
            set { ngayTra = value; }
        }

        private string hinhthucTra;

        public string HinhthucTra
        {
            get { return hinhthucTra; }
            set { hinhthucTra = value; }
        }
        private string tongTienCoc;
        public string TongTienCoc
        {
            get { return tongTienCoc; }
            set { tongTienCoc = value; }
        }
        private string bienSoXe;
        public string BienSoXe
        {
            get { return bienSoXe; }
            set { bienSoXe = value; }
        }
        private string maLich;
        public string MaLich
        {
            get { return maLich; }
            set { maLich = value; }
        }
        private string maHoaDon;
        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
    }
}
