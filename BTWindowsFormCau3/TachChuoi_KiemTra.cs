using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindowsFormCau3
{
    internal class TachChuoi_KiemTra
    {
        public static void TachChuoi(string hoTen, ref string ho, ref string ten)
        {
            string[] chuoi = hoTen.Split(' ');
            for (int i = 0; i < chuoi.Length-1; i++)
            {
            ho+=chuoi[i]+" ";
            }
            ten= chuoi.Last();
        }
        public static bool ThuTu(int n1, int n2)
        {
            bool kq = false;
            if (n2 == (n1+1))
            { kq = true; }
            return kq;
        }
    }
}
