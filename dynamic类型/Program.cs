using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 给dynamic类型定义的任何操作都是有效的，运行期检测错误
 * dynamic对象可以在运行期改变类型
 */
namespace dynamic类型
{
    class Program
    {
        static void Main(string[] args)
        {
            var staticPerson = new Person();
            dynamic dynamicPerson = new Person();
            // staticPerson.getFullName("Jone", "Smith"); // 编辑期报错
            // dynamicPerson.getFullName("Jone", "Smith"); // 运行期报错

            //改变类型
            dynamic d = 100;
            Console.WriteLine(d.GetType());
            Console.WriteLine(d);

            d = "devwh";
            Console.WriteLine(d.GetType());
            Console.WriteLine(d);

            d = new Person();
            Console.WriteLine(d.GetType());
            Console.WriteLine(d);
        }
    }

    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string getFullName()
        {
            return string.Concat(firstName, " ", lastName);
        }
    }
}
