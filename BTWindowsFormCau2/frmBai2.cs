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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            double kq = 0;
            int s1 = int.Parse(txtSoThuNhat.Text);
            int s2 = int.Parse(txtSoThuHai.Text);
            if (rdbCong.Checked) { kq = s1 + s2; }
            else if (rdbTru.Checked) { kq = s1 - s2; }
            else if (rdbNhan.Checked) { kq = s1 * s2; }
            else { kq = s1 / s2; }
            ;
            lblKetQua.Text = kq.ToString();
        }
    }
}
