using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    class ClassN<T>
    {
        public static int x;
    }
    // ClassN<int>  和 ClassN<string> 存在两组静态字段 x
}
