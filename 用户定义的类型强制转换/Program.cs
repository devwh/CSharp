using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 用户定义的类型强制转换
{
    class Program
    {
        static void Main(string[] args)
        {
            Currency currency = new Currency(50, 35);
            Console.WriteLine(currency); // 这里默认隐式转换为float
            Console.WriteLine("currency is " + currency);
            Console.WriteLine("tostring is " + currency.ToString()); 

            float f = currency; // 需要类型强制转换
            Console.WriteLine("converting to float " + f);

            currency = (Currency)f; // 需要显示转换
            Console.WriteLine("convert back " + currency);

            currency = (Currency)(-50.50); // 
            Console.WriteLine("out of range " + currency);
        }
    }

    struct Currency
    {
        public Currency(uint dollars, ushort cents)
        {
            this.m_dollars = dollars;
            this.m_cents = cents;
        }
        // 类型强制转换必须同时声明 public static
        public static implicit operator float(Currency currency)
        {
            return currency.m_dollars + (currency.m_cents / 100.0f);
        }
        public static explicit operator Currency(float f)
        {
            // 溢出检查
            checked
            {
                uint dollars = (uint)f;
                // ushort cents = (ushort)((f - dollars) * 100);
                // 智能四舍五入 System.Convert 但会有性能损失
                ushort cents = Convert.ToUInt16((f - dollars) *100);
                return new Currency(dollars, cents);
            }
        }
        public override string ToString()
        {
            return string.Format(" ${0}.{1, -2:00} ", dollars, cents);
        }
        public uint dollars
        {
            get
            {
                return m_dollars;
            }
            set
            {
                m_dollars = value;
            }
        }
        public ushort cents
        {
            get
            {
                return m_cents;
            }
            set
            {
                m_cents = cents;
            }
        }

        private uint m_dollars;
        private ushort m_cents;
    }
}
