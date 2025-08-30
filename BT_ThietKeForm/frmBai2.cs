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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox2.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = 0;
            foreach (var hang in listBox2.Items)
            {
                switch (hang)
                {
                    case "Chuột":
                        s += 100000;
                        break;
                    case "Bàn phím":
                        s += 150000;
                        break;
                    case "Máy in":
                        s += 2000000;
                        break;
                    case "USB Kingmax":
                        s += 200000;
                        break;

                    default:
                        break;
                }
            }
            lblTongTien.Text = s + " đồng";
        }

    }
}
