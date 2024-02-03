using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DTO
{
    public class PT
    {
        public PT(string maPT, string tenPT, string hangSX, string nhaCC, string giaNhap, int soLuong)
        {
            this.maPT = maPT;
            this.tenPT = tenPT;
            this.hangSX = hangSX;
            this.nhaCC = nhaCC;
            this.giaNhap = giaNhap;
            this.soLuong = soLuong;
        }

        public PT(DataRow row)
        {
            this.maPT = row["maPT"].ToString();
            this.tenPT = row["tenPT"].ToString();
            this.hangSX = row["hangSX"].ToString();
            this.nhaCC = row["nhaCC"].ToString();
            this.giaNhap = row["giaNhap"].ToString();
            this.soLuong = (int)row["soLuong"];
        }

        private string maPT;

        public string MaPT
        {
            get { return maPT; }
            set { maPT = value; }
        }
        private string tenPT;

        public string TenPT
        {
            get { return tenPT; }
            set { tenPT = value; }
        }
        private string hangSX;

        public string HangSX
        {
            get { return hangSX; }
            set { hangSX = value; }
        }

        private string nhaCC;

        public string NhaCC
        {
            get { return nhaCC; }
            set { nhaCC = value; }
        }

        private string giaNhap;

        public string GiaNhap
        {
            get { return giaNhap; }
            set { giaNhap = value; }
        }
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
    }
}
