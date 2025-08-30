using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindownsFormCau1
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.MaHang = "DS01";
            hh.TenHang = "Máy in";
            hh.DVT = "Cái";
            hh.SoLuong = 3;
            hh.DonGia = 20000000;

            lblHienThi.Text = hh.HienThi();
        }
    }
}
