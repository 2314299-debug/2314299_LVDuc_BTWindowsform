using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindowsFormCau4
{
    internal class Cau3
    {
        public static void ChaoHoi(string hoTen, bool gioiTinh, ref string kq)
        {
            if(gioiTinh)
            {
               kq= "Chào Ông "+hoTen;
            }
            kq = "Chào Bà " + hoTen;
        }
        public static int USCLN(int m, int n)
        {
            if (n == 0) return m;
            return USCLN(n,m%n);
        }
    }
}
