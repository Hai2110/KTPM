using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DTO
{
    public class Sche
    {
        public Sche(string maLich, string ngayLam, string batDau, string ketThuc, int soKH, string maQL)
        {
            this.maLich = maLich;
            this.ngayLam = ngayLam;
            this.batDau = batDau;
            this.ketThuc = ketThuc;
            this.soKH = soKH;
            this.maQL = maQL;
        }

        public Sche(DataRow row)
        {
            this.maLich = row["maLich"].ToString();
            this.ngayLam = row["ngayLam"].ToString();
            this.batDau = row["batDau"].ToString();
            this.ketThuc = row["ketThuc"].ToString();
            this.soKH = (int)row["soKH"];
            this.maQL = row["maQL"].ToString();
        }


        private string maLich;

        public string MaLich
        {
            get { return maLich; }
            set { maLich = value; }
        }
        private string ngayLam;

        public string NgayLam
        {
            get { return ngayLam; }
            set { ngayLam = value; }
        }
        private string batDau;

        public string BatDau
        {
            get { return batDau; }
            set { batDau = value; }
        }

        private string ketThuc;

        public string KetThuc
        {
            get { return ketThuc; }
            set { ketThuc = value; }
        }

        private int soKH;

        public int SoKH
        {
            get { return soKH; }
            set { soKH = value; }
        }
        private string maQL;

        public string MaQL
        {
            get { return maQL; }
            set { maQL = value; }
        }
    }
}
