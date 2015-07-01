using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out参数可以不初始化
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine(func(out a));
            Console.WriteLine(a);
        }

        static int func(out int a)
        {
            a = 100;
            return a;
        }
    }
}
