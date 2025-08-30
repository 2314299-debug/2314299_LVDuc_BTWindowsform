using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindowsFormCau2
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public ThietBi() { }
        public ThietBi(string maThietBi, string tenThietBi, string nuocSanXuat, int donGia, int soLuong)
        {
            MaThietBi = maThietBi;
            TenThietBi = tenThietBi;
            NuocSanXuat = nuocSanXuat;
            DonGia = donGia;
            SoLuong = soLuong;
        }
        public static int ThanhTien(int donGia, int soLuong)
        {
            int kq = donGia * soLuong;
            return kq;
        }
        public string HienThi()
        {
            return string.Format("{0, 13}|{1,20}|{2,23}|{3,15}|{4,13}", MaThietBi, TenThietBi, NuocSanXuat, DonGia, SoLuong);
        }
    }
}
