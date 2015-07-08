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
    }
}
