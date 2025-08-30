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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            var form = new frmBai1();
            form.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            var form = new frmBai2();
            form.ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            var form = new frmBai3();
            form.ShowDialog();
        }
    }
}
