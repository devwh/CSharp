using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposable接口
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = null;
            try
            {
                myClass = new MyClass();
                myClass.func();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (myClass != null)
                {
                    myClass.Dispose();
                }
            }

            // 简写
            using(MyClass s = new MyClass())
            {
                try
                {                   
                    s.func();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }

    class MyClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("IDisposable接口");
        }
        public void func()
        {
            throw new Exception("a");
        }
    }
}
