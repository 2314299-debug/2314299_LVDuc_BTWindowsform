using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindowsFormCau3
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public int HeSoLuong { get; set; }
        public int HeSoPhuCap { get; set; }
        public NhanVien() { }
        public NhanVien(string maNV, string hoTen, DateTime ngaySinh, int heSoLuong, int heSoPhuCap)
        {
            MaNV = maNV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            HeSoLuong = heSoLuong;
            HeSoPhuCap = heSoPhuCap;
        }
        public int TongLuong()
        {
            int tl=0;
            tl=(this.HeSoLuong+this.HeSoPhuCap)*1150000;
            return tl;
        }
        public string HienThi()
        {
            return string.Format("{0, 14}|{1,19}|{2,13}|{3,20}|{4,25}|{5,13}", MaNV, HoTen, NgaySinh.ToShortDateString(), HeSoLuong, HeSoPhuCap, TongLuong());
        }
    }
}
