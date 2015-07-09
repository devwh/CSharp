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
            // doubleOp[] operations = 
            Func<double, double>[] operations = 
            {
                MathOperations.multiplyByTwo,
                MathOperations.square
            };
            for (int i = 0; i < operations.Length; ++i)
            {
                processAndDisplayNumber(operations[i], 4);
                processAndDisplayNumber(operations[i], 5);
            }
            // 修改为多播委托，返回值需要为void 使用Action<T>
            // 多播问题：调用没有顺序，如果其中方法抛出异常，则直接停止迭代
            // 可以使用 Delegate[] delegate = op.GetInvocationList() 获取操作数组，然后foeach手动迭代
            Action<double> op = MathOperations.multicastMultiplyByTwo;
            op += MathOperations.multicastSquare;
            processAndDisplayNumber(op, 4);
            processAndDisplayNumber(op, 5);

            // Func<T> 示例
            Employee[] employee = {
                                      new Employee("a", 20000),
                                      new Employee("b", 30000),
                                      new Employee("c", 25000),
                                      new Employee("d", 15000),
                                      new Employee("e", 50000)
                                  };
            BubbleSorter.sort(employee, Employee.compareSalary);
            foreach(Employee e in employee)
            {
                Console.WriteLine(e);
            }
        }

        public static void processAndDisplayNumber(/*doubleOp action*/Func<double, double> action, double value)
        {
             Console.WriteLine(action(value));
        }
        public static void processAndDisplayNumber(Action<double> action, double value)
        {
            action(value);
        }

        public delegate double doubleOp(double value);

        public delegate double twoLongsOp(long first, long second);
    }
}
