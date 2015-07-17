using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 问题： 只有在垃圾回收时才会调用析构函数，而垃圾回收的时间不确定
namespace 析构函数
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                MyClass myClass = new MyClass();
            }
        }
    }

    class MyClass
    {
        ~MyClass()
        {
            Console.WriteLine("MyClass 析构函数");
        }
    }
}
