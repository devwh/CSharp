using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举
{
    public enum TimeOfDay
    {
        Morning = 0,
        Afternoon = 1,
        Evening = 2
    }
    class Program
    {
        static void Main(string[] args)
        {
            WriteGreeting(TimeOfDay.Morning);

            // 获取枚举值，并转为整数int
            TimeOfDay time = (TimeOfDay)Enum.Parse(typeof(TimeOfDay), "afternoon", true);
            int t = (int)TimeOfDay.Evening;//(int)time;
            Console.WriteLine(t);
        }

        static void WriteGreeting(TimeOfDay timeOfDay)
        {
            switch (timeOfDay)
            {
                case TimeOfDay.Morning:
                    Console.WriteLine("Good " + timeOfDay.ToString());
                    break;
                case TimeOfDay.Afternoon:
                    Console.WriteLine(timeOfDay.ToString());
                    break;
                case TimeOfDay.Evening:
                    Console.WriteLine(timeOfDay.ToString());
                    break;
                default:
                    break;
            }
        }
    }
}
