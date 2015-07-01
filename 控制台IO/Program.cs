using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台IO
{
    struct Custom
    {
        public string m_name;
        int m_age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); // 读取控制台输入
            Console.WriteLine(s); // 输出到控制台

            // 格式化输出
            int i = 10;
            int j = 20;
            Console.WriteLine("{0} plus {1} equals {2}", i, j, i + j);

            // 带宽度的输出
            i = 940;
            j = 73;
            Console.WriteLine("  {0, 4}\n+{1, 4}\n ————\n  {2, 4}", i, j, i + j);

            // 可以使用 @关键字，将c#的关键字作为标识符
            int @int = 1;
            Console.WriteLine(@int);

            Custom custom = new Custom();
            custom.m_name = @"abc";
        }
    }
}
