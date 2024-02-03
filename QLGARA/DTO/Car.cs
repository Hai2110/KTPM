using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DTO
{
    public class Car
    {
        public Car(string bienSoXe, string tenXe, string hangXe, string mauXe, int namSX, string lichsuSDDV, string tinhTrangXe, string maKH )
        {
            this.bienSoXe = bienSoXe;
            this.tenXe = tenXe;
            this.hangXe = hangXe;
            this.mauXe = mauXe;
            this.namSX = namSX;
            this.lichsuSDDV = lichsuSDDV;
            this.tinhTrangXe = tinhTrangXe;
        }

        public Car(DataRow row)
        {
            this.maKH = row["maKH"].ToString();
            this.bienSoXe = row["bienSoXe"].ToString();
            this.tenXe = row["tenXe"].ToString();
            this.hangXe = row["hangXe"].ToString();
            this.mauXe = row["mauXe"].ToString();
            this.namSX = (int)row["namSX"];
            this.lichsuSDDV = row["lichsuSDDV"].ToString();
            this.tinhTrangXe = row["tinhTrangXe"].ToString();
        }

        private string bienSoXe;

        public string BienSoXe
        {
            get { return bienSoXe; }
            set { bienSoXe = value; }
        }
        private string tenXe;

        public string TenXe
        {
            get { return tenXe; }
            set { tenXe = value; }
        }

        private string hangXe;

        public string HangXe
        {
            get { return hangXe; }
            set { hangXe = value; }
        }

        private string mauXe;

        public string MauXe
        {
            get { return mauXe; }
            set { mauXe = value; }
        }
        private string lichsuSDDV;

        public string LichsuSDDV
        {
            get { return lichsuSDDV; }
            set { lichsuSDDV = value; }
        }
        private string tinhTrangXe;
        public string TinhTrangXe
        {
            get { return tinhTrangXe; }
            set { tinhTrangXe = value; }
        }
        private int namSX;
        public int NamSX
        {
            get { return namSX; }
            set { namSX = value; }
        }
        private string maKH;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
    }
}
