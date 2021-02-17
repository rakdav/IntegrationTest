using System;

namespace MathLibrary
{
    public class ClassMath
    {
        public static double Sec(double x)
        {
            int n = 1;
            double S = 0;
            double dx=0;
            while(dx<0.001)
            {
                dx = (Math.Pow(-1, n - 1)) * Math.Pow(x, 2 * n - 1) / fact(2 * n - 1);
                n++;
                S += dx;
            }
            return 1 / S;
        }
        public static double CoSec(double x)
        {
            int n = 0;
            double S = 0;
            double dx = 0;
            while (dx < 0.001)
            {
                dx = (Math.Pow(-1, n)) * Math.Pow(x, 2 * n) / fact(2 * n);
                n++;
                S += dx;
            }
            return 1 / S;
        }
        public static long fact(int n)
        {
            long F = 1;
            for (int i = 1; i <= n; i++) F *= i;
            return F;
        }
    }
}
