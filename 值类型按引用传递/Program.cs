using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型按引用传递
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            var b = 0;

            // 调用按引用传递
            function(a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void function(int a, ref int b)
        {
            a = 100;
            b = 100;
        }
    }
}
