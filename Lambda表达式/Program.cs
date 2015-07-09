using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 运算符为 =>  左边列出需要的参数
namespace Lambda表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            // 一个参数，一条语句，可不写花括号和 return 语句
            Func<string, string> oneParam = param => String.Format("{0}", param.ToUpper());
            Console.WriteLine(oneParam("devwh"));

            // 多个参数，一条语句
            Func<double, double, double> twoParams = (x, y) => x * y; // (double x, double y) => x * y
            Console.WriteLine(twoParams(12, 12));

            // 对条语句
            Func<double, double> two = x =>
            {
                return x * x;
            };
            Console.WriteLine(two(11));
        }
    }
}
