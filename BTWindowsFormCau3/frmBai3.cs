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
            int n1=int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);
            string ho = "";
            string ten = "";
            if(rdbTachChuoi.Checked)
            {
                TachChuoi_KiemTra.TachChuoi(ht, ref ho, ref ten);
                lblKetQua1.Text ="Họ: "+ ho;
                lblKetQua2.Text ="Tên: "+ ten;
            } 
            else
            {
                lblKetQua2.Text = "";

                if(TachChuoi_KiemTra.ThuTu(n1,n2))
                {
                lblKetQua1.Text = "Liên tiếp";
                } 
             else
                lblKetQua1.Text = "Không liên tiếp";  
            }    
                
        }
    }
}
