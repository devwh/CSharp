using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// abstract

namespace 抽象类和抽象方法
{
    // 密封类，不能被继承
    sealed class A
    {

    }
    abstract class Building
    {
        private string m_name;
        public abstract decimal calucateHeatingCost();
    }

    class B : Building
    {
        public override decimal calucateHeatingCost()
        {
            return 112M;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Building building = new B();
            Console.WriteLine(building.calucateHeatingCost());
        }
    }
}
