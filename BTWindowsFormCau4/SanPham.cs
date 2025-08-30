using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindowsFormCau4
{
    internal class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public SanPham() { }
        public int NamHetHan()
        {
            int nam;
            nam = this.NgaySanXuat.Year + 3;
            return nam;
        }
        public string HienThi()
        {
            return string.Format("{0, 17}|{1,26}|{2,22}|{3,17}|{4,14}", MaSanPham, TenSanPham, LoaiSanPham, NgaySanXuat.ToShortDateString(), NamHetHan() );

        }
    }
}
