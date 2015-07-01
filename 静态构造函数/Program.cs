
// 编写静态构造函数的原因：类的一些静态字段或属性，需要在第一次使用类前，从外部初始化，如读取配置
// 没有访问控制，其他C#不调用，由.Net调用
// 不能带参，只能有一个，可以和无参构造同时存在，不能访问实例成员

using System;

namespace 静态构造函数
{
    class UserPreference
    {
        // 只读类型，只能在构造函数中初始化
        public static readonly int backColor;
        static UserPreference()
        {
            DateTime now = DateTime.Now;
            if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
            {
                backColor = 1;
            }
            else
            {
                backColor = 2;
            }
        }
        private UserPreference()
        {

        }
    }

    class MainEntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User-preferences: BackColor is: " + UserPreference.backColor.ToString());
        }
    }
}
