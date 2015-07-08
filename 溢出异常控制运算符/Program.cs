using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * checked      检查代码块溢出   -> OverflowException
 * unchecked    禁止检查代码块溢出，不抛异常，但可能丢失数据（默认，可省略）
 */
namespace 溢出异常控制运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 255;
            try
            {
                long val = 3000000000;
               // int i = checked((int)val);

                long myLongNumber = val;
                object myObject = myLongNumber; // 装箱
                int myIntNumber = (int)myObject; // 拆箱  类型不匹配  InvaildCaseException

               // unchecked
               // {
                    b++;
              //  }
                Console.WriteLine(b);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
