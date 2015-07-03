using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    class Program
    {
//         static void Main(string[] args)
//         {
//             var list1 = new LinkedList();
//             list1.addLast(1);
//             list1.addLast(2); // 装箱
//             // list1.addLast("3"); // 异常 
//             foreach (int i in list1)
//             {
//                 Console.WriteLine(i); // 
//             }
// 
//             var list2 = new LinkedList<int>();
//             list2.addLast(1);
//             list2.addLast(2);
//             // list2.addLast("3"); // 类型不匹配
//             foreach(int i in list2)
//             {
//                 Console.WriteLine(i);
//             }
//         }
    }

    // 一般的、非泛型链表类
    public class LinkedListNode
    {
        public LinkedListNode(object value)
        {
            this.value = value;
        }

        public LinkedListNode next { get; internal set; }
        public LinkedListNode prev { get; internal set; }

        public object value { get; private set; }
    }

    public class LinkedList : IEnumerable
    {
        public LinkedListNode first { get; private set; }
        public LinkedListNode last { get; private set; }

        public LinkedListNode addLast(object node)
        {
            var newNode = new LinkedListNode(node);
            if (first == null)
            {
                first = newNode;
                newNode.prev = last;
                last = first;
            }
            else
            {
                LinkedListNode previous = last;
                last.next = newNode;
                last = newNode;
                last.prev = previous;
            }
            return newNode;
        }
        public IEnumerator GetEnumerator()
        {
            LinkedListNode current = first;
            while (current != null)
            {
                yield return current.value;
                current = current.next;
            }
        }
    }

    // 泛型类
    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            this.value = value;
        }
        public LinkedListNode<T> next { get; internal set; }
        public LinkedListNode<T> prev { get; internal set; }

        public T value { get; private set; }
    }
    public class LinkedList<T> : IEnumerable<T>
    {
        public LinkedListNode<T> first { get; private set; }
        public LinkedListNode<T> last { get; private set; }
        public LinkedListNode<T> addLast(T node)
        {
            var newNode = new LinkedListNode<T>(node);
            if (first == null)
            {
                first = newNode;
                newNode.prev = last;
                last = first;
            }
            else
            {
                LinkedListNode<T> previous = last;
                last.next = newNode;
                last = newNode;
                last.prev = previous;
            }
            return newNode;
        }
        // 泛型类需要实现以下两个函数
        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = first;
            while (currentNode != null)
            {
                yield return currentNode.value;
                currentNode = currentNode.next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
