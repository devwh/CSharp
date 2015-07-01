using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            // 基本数据类型都是值类型，存在于堆栈中，
            // 类类型及自定义类型是引用类型，存在于堆中，必须使用new创建，类似于C++的引用
            // 自定义类型 结构体 为 值类型

            // 基本预定义类型对应于.Net类型（CTS类型）,因此可以有方法
            int i = 10;
            string s = i.ToString();
            Console.WriteLine(s);
            // 整形
            /*
             * sbyte    System.SByte    8位有符号
             * short    System.Int16    16位有符号
             * int      System.Int32    32位有符号
             * long     System.Int64    64位有符号      L
             * byte     System.Byte     8位无符号   (与char不同，必须显示转换）
             * ushort   System.UInt16
             * uint     System.UInt32
             * ulong    System.UInt64                   UL
             */

            // 浮点
            /*
             * float    System.Single   32位单精度      7位精度    F
             * double   System.Double   64位双精度      15/16位精度
             * decimal  System.Decimal  128位高精度     28位精度   M    十进制数表示  财务计算（非基本类型）
             */
            decimal d = 1.23M;

            // bool
            /*
             * bool     System.Boolean  不能与整数隐式转换
             */

            // 字符类型
            /*
             * char     System.Char     16位Unicode字符    \u0041
             */

            // 预定义引用类型
            /*
             * object   System.Object   根类型
             * string   System.String   Unicode字符串      修改字符串，会创建新的string
             */
            string s1 = @"c:\user\administrator";
        }
    }
}
