using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowsFormCau3
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            NhanVien nv=new NhanVien();
            nv.MaNV = "2314299";
            nv.HoTen = "Lâm Văn Đức";
            nv.NgaySinh = new DateTime(2004, 02, 07);
            nv.HeSoLuong = 2;
            nv.HeSoPhuCap = 5;
            lblThongTin.Text = nv.HienThi();
        }
    }
}
