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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            string ho=txtHo.Text;
            string ten=txtTen.Text;
            string nc=" ";
            int n=int.Parse(txtN.Text);
            long gt;
            if (rdbNoiChuoi.Checked)
            {
                NoiChuoi_GiaiThua.NoiChuoi(ho, ten, ref nc);
                lblKetQua.Text = nc;
            }
            else 
            {
                gt = NoiChuoi_GiaiThua.GiaiThua(n); 
                lblKetQua.Text=gt.ToString();
            }

        }
    }
}
