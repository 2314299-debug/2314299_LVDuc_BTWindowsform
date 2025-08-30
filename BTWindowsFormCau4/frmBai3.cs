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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void frmBai3_Load(object sender, EventArgs e)
        {

        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            string ht=txtHoTen.Text;
            int m=int.Parse(txtM.Text);
            int n=int.Parse(txtN.Text);
            int kq = 0;
            string kQ = "";
            if (rdbChaoHoi.Checked)
            {
                if (rdbNam.Checked) Cau3.ChaoHoi(ht, true, ref kQ);
                 else {Cau3.ChaoHoi(ht, false, ref kQ); }
                lblKetQua.Text = kQ;
            }
            else
            {
                kq=Cau3.USCLN(m, n);   
                lblKetQua.Text=kq.ToString();
            }

        }
    }
}
