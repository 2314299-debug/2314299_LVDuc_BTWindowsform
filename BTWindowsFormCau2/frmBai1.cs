using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowsFormCau2
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi();
            tb.MaThietBi = "MT03";
            tb.TenThietBi = "Chuột";
            tb.NuocSanXuat = "Mỹ";
            tb.SoLuong = 2;
            tb.DonGia = 30000000;

            lblThongTin.Text = tb.HienThi();
        }
    }
}
