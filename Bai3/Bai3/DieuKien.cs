using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class DieuKien
    {
        private static bool checkNT(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        public static string NguyenTo(int n)
        {
            string result = "";
            for (int i = 2; i < n; i++)
                if (checkNT(i))
                    result += i + " ";
            return result;
        }

        private static bool checkCP(int n)
        {
            int sqrt = (int)Math.Sqrt(n);
            if (n ==  sqrt * sqrt)
                return true;
            return false;
        }

        public static string ChinhPhuong(int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
                if (checkCP(i))
                    result += i + " ";
            return result;
        }

        private static bool checkHH(int n)
        {
            int tong = 0;
            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0)
                    tong += i;
            return tong == n;
        }

        public static string HoanHao(int n)
        {
            string result = "";
            for (int i = 1; i < n; i++)
                if (checkHH(i))
                    result += i + " ";
            return result;
        }
    }
}
