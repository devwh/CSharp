using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * sizeof   值类型字节长度，对于复杂类型，需要将代码块放入 unsafe 块中
 * is       检查对象是否与特定的类型兼容
 * typeof   返回特定类型的 System.Type 对象，用于反射
 * as       执行引用类型的显示转换，失败返回null
 */
namespace 类型信息运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            if (i is object)
            {
                Console.WriteLine("i is an object");
            }

            object o1 = "Some string";
            object o2 = 10;
            string s1 = o1 as string;
            string s2 = o2 as string; // null
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
