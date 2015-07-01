using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 如果子类定义了一个与基类相同签名的方法，编译器会发出警告
// 使用new修饰方法

namespace new隐藏基类方法
{
    class Base
    {
        static void Main(string[] args)
        {
            Base child = new Child();
            Console.WriteLine(child.func(12));
        }

        public int func(int a)
        {
            return a;
        }
    }
    class Child : Base
    {
        public new int func(int a)
        {
            return a * a;
        }
    }
}
