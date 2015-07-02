using devwh;
using devwh.venus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devwh
{
    public interface IBackCount
    {
        void payIn(decimal amount);
        bool withdraw(decimal amount);
        decimal balance { get; }
    }
}

namespace devwh.venus
{
    public class SaverCount : IBackCount
    {
        private decimal m_balance;
        public void payIn(decimal amount)
        {
            m_balance += amount;
        }
        public bool withdraw(decimal amount)
        {
            if (m_balance >= amount)
            {
                m_balance -= amount;
                return true;
            }
            Console.WriteLine("withdraw attempt failed");
            return false;
        }
        public override string ToString()
        {
            return String.Format("Venus Bank Server: Balance = {0, 6:C}", m_balance);
        }
        public decimal balance
        {
            get
            {
                return m_balance;
            }
        }
    }
}

namespace test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IBackCount venusBank = new SaverCount();
            venusBank.payIn(2000);
            venusBank.withdraw(100);
            Console.WriteLine(venusBank.ToString());
        }
    }
}
