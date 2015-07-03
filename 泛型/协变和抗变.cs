using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    // 不是很清楚，需要查资料
    // 协变：参数类型是协变的，即，基类引用指向子类引用
    // 抗变：返回值是抗变的，即，子类不能指向返回的基类引用

    public class Sharp
    {
        
    }
    public class Rectangle : Sharp
    {

    }
    // 接口协变 out， 则返回值类型只能是 T
    public interface IIndex<out T>
    {
        T this[int index] { get; }
        int count { get; }
    }
    public class RectangleCollection : IIndex<Rectangle>
    {
        private Rectangle[] data = //new Rectangle[3]
        {
            new Rectangle{},
            new Rectangle{},
            new Rectangle{}
        };
        public static RectangleCollection getRectangles()
        {
            return new RectangleCollection();
        }
        public Rectangle this[int index]
        {
            get
            {
                if (index < 0 || index >= data.Length)
                {
                    throw new ArgumentOutOfRangeException("index");
                }
                return data[index];
            }
        }

        public int count
        {
            get
            {
                return data.Length;
            }
        }

        public static void Main()
        {
            IIndex<Rectangle> rectangles = RectangleCollection.getRectangles();
            IIndex<Sharp> sharps = rectangles;
        }
    }

    // 抗变 in， 只能将 T 作为方法输入
    public interface IDisplay<in T>
    {
        void show(T item);
       // T getItem();
    }
    public class SharpDisplay : IDisplay<Sharp>
    {
        public void show(Sharp s)
        { }
        public Sharp getItem()
        {
            return new Sharp();
        }
    }
}
