using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    // 定义委托
    public delegate void intMethodInvoker(int x);
    class Program
    {
        private delegate string getAString();
        static void Main(string[] args)
        {
            // 使用委托
            int x = 40;
            // getAString firstStringMethod = new getAString(x.ToString); // 参数为委托引用的方法
            getAString firstStringMethod = x.ToString;
            Console.WriteLine("String is {0}.", firstStringMethod());

            // 委托数组
            doubleOp[] method = 
            {
                MathOperations.multiplyByTwo,
                MathOperations.square
            };
            for (int i = 0; i < method.Length; ++i)
            {
                processAndDisplayNumber(method[i], 4);
                processAndDisplayNumber(method[i], 5);
            }
        }

        public static void processAndDisplayNumber(doubleOp action, double value)
        {
             Console.WriteLine(action(value));
        }

        public delegate double doubleOp(double value);

        public delegate double twoLongsOp(long first, long second);
    }
}
