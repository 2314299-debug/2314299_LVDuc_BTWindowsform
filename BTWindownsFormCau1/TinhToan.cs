using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindownsFormCau1
{
    internal class TinhToan
    {
        public static void CongHaiSo(int a, int b, ref int s)
        {
            s = a + b;
        }
        public static int TongDaySo(int n)
        {
            int kq = 0;
            for (int i = 1; i <= n; i++)
            {
                kq += i;
            }
            return kq;
        }
    }
}
