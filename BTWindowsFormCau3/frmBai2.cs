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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            int kq = 0;
            //tổng dãy
            if (rdbTinhTong.Checked)
            {
                for (int i = 0; i <=n; i++)
                {
                    kq += i;
                }
            }
            else
            {
                kq += 1;
                for (int i = 1; i <= n; i++)
                {
                    kq *= i;
                }
            }
            lblKetQua.Text=kq.ToString();
        }
    }
}
