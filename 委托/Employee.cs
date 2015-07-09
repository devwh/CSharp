using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    class Employee
    {
        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public override string ToString()
        {
            return string.Format("{0} {1:C}", name, salary);
        }

        // 必须成对
        public static bool operator < (Employee e1, Employee e2)
        {
            return e1.salary < e2.salary;
        }
        public static bool operator > (Employee e1, Employee e2)
        {
            return e1.salary > e2.salary;
        }
        public static bool compareSalary(Employee e1, Employee e2)
        {
            return e1.salary < e2.salary;
        }
        
        public string name { get; set; }
        public decimal salary { get; set; }
    }
}
