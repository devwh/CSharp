using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    public interface IInterface<T>
    {
        void func();
    }
    // 继承自泛型接口
    public class ClassH<T> : IInterface<T>
    {
        public void func() { }
    }
    // 继承自泛型类，必须重复泛型类型，或指定基类类型
    public class ClassK<T> : ClassH<T>
    { }
    public class ClassL<T> : ClassH<int>
    { }
    public class ClassM : ClassH<int>
    { }
}
