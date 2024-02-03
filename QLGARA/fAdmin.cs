using QLGARA.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLGARA.DTO;

namespace QLGARA
{
    public partial class fAdmin : Form
    {
        BindingSource cusList = new BindingSource();
        BindingSource nvList = new BindingSource();
        BindingSource qlList = new BindingSource();
        BindingSource dvList = new BindingSource();
        BindingSource ptList = new BindingSource();
        BindingSource hdList = new BindingSource();
        BindingSource scheList = new BindingSource();
        BindingSource carList = new BindingSource();
        BindingSource phList = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dtgvCus.DataSource = cusList;
            dtgvNV.DataSource = nvList;
            dtgvAcc.DataSource = qlList;
            dtgvSer.DataSource = dvList;
            dtgvPT.DataSource = ptList;
            dtgvBill.DataSource = hdList;
            dtgvSche.DataSource = scheList;
            dtgvCar.DataSource = carList;
            dtgvCar.DataSource = phList;
            LoadListNV();
            LoadListCus();
            LoadListQL();
            LoadListDV();
            LoadListPT();
            LoadListCar();
            LoadListSche();
            LoadListPH();
            LoadListHD();
            AddCusBinding();
            AddNVBinding();
            AddQLBinding();
            AddDVBinding();
            AddPTBinding();
            AddHDBinding();
            AddScheBinding();
            AddCarBinding();
            AddPHBinding();
        }
        void LoadListCus()
        {
            cusList.DataSource = CusDAO.Instance.GetListCus();
        }
        private void btnShowCus_Click(object sender, EventArgs e)
        {
            LoadListCus();
        }

        void LoadListNV()
        {
            dtgvNV.DataSource = NVDAO.Instance.GetListNV();
        }
        private void btnShowSV_Click(object sender, EventArgs e)
        {
            LoadListNV();
        }
        void LoadListQL()
        {
            dtgvAcc.DataSource = QLDAO.Instance.GetListQL();
        }
        private void btnShowQL_Click(object sender, EventArgs e)
        {
            LoadListQL();
        }
        void LoadListDV()
        {
            dtgvSer.DataSource = DVDAO.Instance.GetListDV();
        }
        private void btnShowSer_Click(object sender, EventArgs e)
        {
            LoadListDV();
        }
        void LoadListPT()
        {
            dtgvPT.DataSource = PTDAO.Instance.GetListPT();
        }
        private void btnShowPT_Click(object sender, EventArgs e)
        {
            LoadListPT();
        }
        void LoadListCar()
        {
            dtgvCar.DataSource = CarDAO.Instance.GetListCar();
        }
        private void btnShowCar_Click(object sender, EventArgs e)
        {
            LoadListCar();
        }
        void LoadListSche()
        {
            dtgvSche.DataSource = ScheDAO.Instance.GetListSche();
        }
        private void btnShowSche_Click(object sender, EventArgs e)
        {
            LoadListSche();
        }
        void LoadListPH()
        {
            dtgvApp.DataSource = PHDAO.Instance.GetListPH();
        }
        private void btnShowApp_Click(object sender, EventArgs e)
        {
            LoadListPH();
        }
        void LoadListHD()
        {
            dtgvBill.DataSource = HDDAO.Instance.GetListHD();
        }
        private void btnShowBill_Click(object sender, EventArgs e)
        {
            LoadListHD();
        }
        void AddCusBinding()
        {
            txbNameCus.DataBindings.Add(new Binding("Text", dtgvCus.DataSource, "TenKH", true, DataSourceUpdateMode.Never));
            txbIDCus.DataBindings.Add(new Binding("Text", dtgvCus.DataSource, "MaKH", true, DataSourceUpdateMode.Never));
            txbPhoneCus.DataBindings.Add(new Binding("Text", dtgvCus.DataSource, "sdt", true, DataSourceUpdateMode.Never));
            txbDCCus.DataBindings.Add(new Binding("Text", dtgvCus.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txbMailCus.DataBindings.Add(new Binding("Text", dtgvCus.DataSource, "Email", true, DataSourceUpdateMode.Never));
            dtpNTNSCus.DataBindings.Add(new Binding("Value", dtgvCus.DataSource, "ntns", true, DataSourceUpdateMode.Never));
        }
        void AddNVBinding()
        {
            txbNameNV.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
            txbIDNV.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            txbSDTNV.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "sdt", true, DataSourceUpdateMode.Never));
            txbDCNV.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txbMailNV.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "Email", true, DataSourceUpdateMode.Never));
            dtpNTNSNV.DataBindings.Add(new Binding("Value", dtgvNV.DataSource, "ntns", true, DataSourceUpdateMode.Never));
        }
        void AddQLBinding()
        {
            txbNameQL.DataBindings.Add(new Binding("Text", dtgvAcc.DataSource, "TenQL", true, DataSourceUpdateMode.Never));
            txbIDQL.DataBindings.Add(new Binding("Text", dtgvAcc.DataSource, "MaQL", true, DataSourceUpdateMode.Never));
            txbSDTQL.DataBindings.Add(new Binding("Text", dtgvAcc.DataSource, "sdt", true, DataSourceUpdateMode.Never));
            txbDCQL.DataBindings.Add(new Binding("Text", dtgvAcc.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txbMailQL.DataBindings.Add(new Binding("Text", dtgvAcc.DataSource, "Email", true, DataSourceUpdateMode.Never));
            dtpNTNSQL.DataBindings.Add(new Binding("Value", dtgvAcc.DataSource, "ntns", true, DataSourceUpdateMode.Never));
        }
        void AddDVBinding()
        {
            txbSerID.DataBindings.Add(new Binding("Text", dtgvSer.DataSource, "TenDV", true, DataSourceUpdateMode.Never));
            txbSerName.DataBindings.Add(new Binding("Text", dtgvSer.DataSource, "MaDV", true, DataSourceUpdateMode.Never));
            nmSerPrice.DataBindings.Add(new Binding("Value", dtgvSer.DataSource, "GiaDV", true, DataSourceUpdateMode.Never));
        }
        void AddPTBinding()
        {
            txbIDPT.DataBindings.Add(new Binding("Text", dtgvPT.DataSource, "MaPT", true, DataSourceUpdateMode.Never));
            txbNamePT.DataBindings.Add(new Binding("Text", dtgvPT.DataSource, "TenPT", true, DataSourceUpdateMode.Never));
            txbHangPT.DataBindings.Add(new Binding("Text", dtgvPT.DataSource, "HangSX", true, DataSourceUpdateMode.Never));
            nmSLTKPT.DataBindings.Add(new Binding("Value", dtgvPT.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));
            nmGNPT.DataBindings.Add(new Binding("Value", dtgvPT.DataSource, "GiaNhap", true, DataSourceUpdateMode.Never));
            txbNCCPT.DataBindings.Add(new Binding("Text", dtgvPT.DataSource, "NhaCC", true, DataSourceUpdateMode.Never));
        }
        void AddHDBinding()
        {
            txbIDBill.DataBindings.Add(new Binding("Text", dtgvBill.DataSource, "MaHoaDon", true, DataSourceUpdateMode.Never));
            txbTienBill.DataBindings.Add(new Binding("Text", dtgvBill.DataSource, "TienTra", true, DataSourceUpdateMode.Never));
            dtpXDBill.DataBindings.Add(new Binding("Value", dtgvBill.DataSource, "NgayXuatDon", true, DataSourceUpdateMode.Never));

        }
        void AddScheBinding()
        {
            txbIDSche.DataBindings.Add(new Binding("Text", dtgvSche.DataSource, "MaLich", true, DataSourceUpdateMode.Never));
            txbDateSche.DataBindings.Add(new Binding("Text", dtgvSche.DataSource, "NgayLam", true, DataSourceUpdateMode.Never));
            txbStartSche.DataBindings.Add(new Binding("Text", dtgvSche.DataSource, "BatDau", true, DataSourceUpdateMode.Never));
            txbEndSche.DataBindings.Add(new Binding("Text", dtgvSche.DataSource, "KetThuc", true, DataSourceUpdateMode.Never));
            nmSche.DataBindings.Add(new Binding("Value", dtgvSche.DataSource, "SoKH", true, DataSourceUpdateMode.Never));
            txbQLSche.DataBindings.Add(new Binding("Text", dtgvSche.DataSource, "MaQL", true, DataSourceUpdateMode.Never));
        }
        void AddCarBinding()
        {
            txbIDCar.DataBindings.Add(new Binding("Text", dtgvCar.DataSource, "BienSoXe", true, DataSourceUpdateMode.Never));
            txbNameCar.DataBindings.Add(new Binding("Text", dtgvCar.DataSource, "TenXe", true, DataSourceUpdateMode.Never));
            txbHangCar.DataBindings.Add(new Binding("Text", dtgvCar.DataSource, "HangXe", true, DataSourceUpdateMode.Never));
            txbNamSXCar.DataBindings.Add(new Binding("Text", dtgvCar.DataSource, "NamSX", true, DataSourceUpdateMode.Never));
            txbLSCar.DataBindings.Add(new Binding("Text", dtgvCar.DataSource, "LichsuSDDV", true, DataSourceUpdateMode.Never));
            txbTTCar.DataBindings.Add(new Binding("Text", dtgvCar.DataSource, "TinhTrangXe", true, DataSourceUpdateMode.Never));
            txbKHCar.DataBindings.Add(new Binding("Text", dtgvCar.DataSource, "MaKH", true, DataSourceUpdateMode.Never));
            txbMauCar.DataBindings.Add(new Binding("Text", dtgvCar.DataSource, "MauXe", true, DataSourceUpdateMode.Never));
        }
        void AddPHBinding()
        {
            txbIDApp.DataBindings.Add(new Binding("Text", dtgvApp.DataSource, "MaPhieu", true, DataSourceUpdateMode.Never));
            txbLDHApp.DataBindings.Add(new Binding("Text", dtgvApp.DataSource, "LydoHen", true, DataSourceUpdateMode.Never));
            dtpNDApp.DataBindings.Add(new Binding("Text", dtgvApp.DataSource, "NgayDat", true, DataSourceUpdateMode.Never));
            dtpHTApp.DataBindings.Add(new Binding("Text", dtgvApp.DataSource, "NgayTra", true, DataSourceUpdateMode.Never));
            txbHTTTApp.DataBindings.Add(new Binding("Text", dtgvApp.DataSource, "HinhthucTra", true, DataSourceUpdateMode.Never));
            nmApp.DataBindings.Add(new Binding("Text", dtgvApp.DataSource, "TongTienCoc", true, DataSourceUpdateMode.Never));
            txbCarApp.DataBindings.Add(new Binding("Text", dtgvApp.DataSource, "BienSoXe", true, DataSourceUpdateMode.Never));
            txbHDApp.DataBindings.Add(new Binding("Text", dtgvApp.DataSource, "MaHoaDon", true, DataSourceUpdateMode.Never));
            txbScheApp.DataBindings.Add(new Binding("Text", dtgvApp.DataSource, "MaLich", true, DataSourceUpdateMode.Never));
            
        }
    }
}