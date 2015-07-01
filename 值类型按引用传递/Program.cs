using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型按引用传递
{
    class Money
    {
        public decimal amount { get; set; }
        public override string ToString()
        {
 	         return "$" + amount.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money();
            money.amount = 100;
            Console.WriteLine(money.ToString());

            var a = 0;
            var b = 0;

            // 调用按引用传递
            function(a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void function(int a, ref int b)
        {
            a = 100;
            b = 100;
        }
    }
}
