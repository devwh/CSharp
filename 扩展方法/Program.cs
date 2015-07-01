using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 程序集中不能直接修改源代码，则使用扩展方法添加
// 扩展方法是静态方法，创建一个静态类，添加静态方法，方法中使用 this，告诉编译器此方法是类的一部分

namespace 扩展方法
{
    class Money
    {
        public decimal amount { get; set; }
        public override string ToString()
        {
            return "$" + amount.ToString();
        }
    }

    static class MoneyEx
    {
        // 即使是静态的，也必须使用实例调用
        public static void addAmount(this Money money, decimal amountToAdd)
        {
            money.amount += amountToAdd;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money();
            money.amount = 100;
            Console.WriteLine(money.ToString());
            money.addAmount(100);
            Console.WriteLine(money.ToString());
        }
    }
}
