using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 元组
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = divide(5, 2);
            Console.WriteLine("Result {0}, Reminder {1}", result.Item1, result.Item2);
        }

        // 元组用Tuple的静态函数Create() 方法创建
        public static Tuple<int, int> divide(int dividend, int divisor)
        {
            int resule = dividend / divisor;
            int reminder = dividend % divisor;
            return Tuple.Create<int, int>(resule, reminder);
        }

        // 如果元组的项超过8个，则使用带8个参数的Create函数，最后一个参数要求传入Tuple类型
    }

    
}
