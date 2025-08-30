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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            float dlt = float.Parse(txtDLyThuyet.Text);
            float dth = float.Parse(txtDThucHanh.Text);
            float dtb=(dlt+dth)/2;
            if (dlt > 10 || dth > 10)
                lblKetQua.Text = "Điểm số quá 10!!!";
            else
            {
                if (dlt < 5 || dth < 5)
                {
                    lblKetQua.Text = "Yếu";
                }
                else
                {
                    if (dtb < 7) lblKetQua.Text = "Trung Bình";
                    else

                        if (dtb < 8) lblKetQua.Text = "Khá";
                    else
                            if (dtb < 9) lblKetQua.Text = "Giỏi";
                    else lblKetQua.Text = "Xuất sắc";

                }
            }    
        }
    }
}
