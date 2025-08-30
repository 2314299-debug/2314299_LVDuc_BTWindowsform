using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_ThietKeForm
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void rdbXanh_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "22000";
        }

        private void rdbDo_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "21000";
        }

        private void rdbTrang_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "20000";
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
          int soTien= int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
            lblTongTien.Text = soTien.ToString();
        }
    }
}
