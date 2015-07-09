using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    class MathOperations
    {
        public static double multiplyByTwo(double value)
        {
            return value * 2;
        }
        public static double square(double value)
        {
            return value * value;
        }
        public static void multicastMultiplyByTwo(double value)
        {
            double result = value * 2;
            Console.WriteLine("Multicast: " + result);
        }
        public static void multicastSquare(double value)
        {
            double result = value * value;
            Console.WriteLine("Multicast: " + result);
        }
    }
}
