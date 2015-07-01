using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数初始化器
{
    class Car
    {
        public Car(string description, uint wheels)
        {
            this.m_description = description;
            this.m_wheels = wheels;
        }
        public Car(string description) : this(description, 4) // 对基类的调用使用 base
        {
            // 先执行初始化器，再执行此代码块内容
        }
        static void Main(string[] args)
        {
            Car car = new Car("BMW");
        }

        private string m_description;
        uint m_wheels;
    }
}
