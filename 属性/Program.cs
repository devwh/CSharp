using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 属性
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        // 普通属性
        private string m_name;
        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }
        

        // 只读属性
        private int m_age;
        public int age
        {
            get
            {
                return m_age;
            }
        }

        // 访问级别的属性，必须有一个具备访问级别，否则编译报错
        private bool m_gender;
        public bool gender
        {
            // protected get // Error
            get
            {
                return m_gender;
            }
            private set
            {
                m_gender = value;
            }
        }

        // 自动实现的属性，自动有一个 private string m_firstName;
        public string firstName{get; set;} // 必须要有两个访问器，可以有不同的访问级别，
    }
}
