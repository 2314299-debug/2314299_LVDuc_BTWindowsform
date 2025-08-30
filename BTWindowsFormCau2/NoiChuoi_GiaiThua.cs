using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindowsFormCau2
{
    internal class NoiChuoi_GiaiThua
    {
        public static void NoiChuoi(string ho, string ten, ref string s)
        {
            s= ho+' '+ten;
        }
        public static long GiaiThua(int n)
        {
            long kq=1;
            int i = 1;
            while (i<=n)
            {
                kq *= i;
                i++;
            }
            return kq;
        }
    }
}
