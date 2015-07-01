using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类型推断
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "devwh";
            var age = 28;
            var isRabbit = true;

            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isRabbitType = isRabbit.GetType();

            Console.WriteLine(nameType);
            Console.WriteLine(ageType);
            Console.WriteLine(isRabbitType);

            int j = 0;
            for (int i = 0; i < 10; ++i)
            {
                // 不会隐藏上一个作用域内的j
                // int j = i;
            }
        }
    }
}
