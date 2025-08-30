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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int n = int.Parse(txtN.Text);
            int kq = 0;

            if (rdbTong2So.Checked)
            {
                TinhToan.CongHaiSo(a, b, ref kq);
            }
            else
            {
                kq = TinhToan.TongDaySo(n);
            }
            lblKetQua.Text = kq.ToString();
        }
    }
}
