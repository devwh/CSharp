using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命名参数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(func("Dev", "Wh"));
            Console.WriteLine(func(lastName: "wh", firstName: "dev"));
        }

        static string func(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
