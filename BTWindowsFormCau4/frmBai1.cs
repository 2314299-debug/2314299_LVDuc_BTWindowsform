using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowsFormCau4
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            SanPham sp=new SanPham();
            sp.MaSanPham = "GF01";
            sp.TenSanPham = "Tẩy";
            sp.LoaiSanPham = "Văn phòng phẩm";
            sp.NgaySanXuat = new DateTime(2025, 08, 30);
            lblThongTin.Text = sp.HienThi();
        }
    }
}
