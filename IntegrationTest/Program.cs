using System;
using MathLibrary;
namespace IntegrationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            for(double x=-10;x<=10;x+=0.5)
            {
                Console.WriteLine(x+"        "+String.Format("{0:f3}",(ClassMath.Sec(x)+ClassMath.CoSec(x)))+"              "+String.Format("{0:f3}",((1/Math.Cos(x))+(1/Math.Sin(x)))));
            }
        }
    }
}
