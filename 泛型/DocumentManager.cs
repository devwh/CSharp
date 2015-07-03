using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    public class ClassA<T>
        where T : struct // 结构约束，T 必须是值类型
    { }
    public class ClassB<T>
        where T : class // 类约束，T 必须是引用类型
    { }
    public class ClassC<T>
        where T : IDocument // 接口约束，T 必须实现IDocument接口
    { }
    public class ClassD<T>
        where T : Document // 派生约束，T 必须继承自Document
    { }
    public class ClassE<T>
        where T : new() // 构造约束，T 必须有一个默认构造函数，只能为默认构造函数定义约束
    { }
    public class ClassF<T1, T2>
        where T1 : T2 // 裸类型约束，T1 派生自 T2
    { }
    // 各种约束可以合并
    public class ClassG<T>
        where T : class, new()
    { }

    public class DocumentManager<TDocument>
        where TDocument : IDocument // 接口约束
    {
        public void addDocument(TDocument doc)
        {
            lock(this)
            {
                documentQueue.Enqueue(doc);
            }
        }
        public TDocument getDocument()
        {
            // defaule 将引用类型赋值为null 将值类型赋值为0
            TDocument doc = default(TDocument);
            lock(this)
            {
                doc = documentQueue.Dequeue();
            }
            return doc;
        }
        public bool isDocumentAvailable
        {
            get
            {
                return documentQueue.Count > 0;
            }
        }

        public void displayAllDocument()
        {
            foreach(TDocument doc in documentQueue)
            {
                // 强转，那么doc必须继承自IDocument,  使用where限制 DocmentManager 只接受继承至IDocument的类
                // Console.WriteLine(((IDocument)doc).title);
                Console.WriteLine(doc.title); // 简写
            }
        }

        private readonly Queue<TDocument> documentQueue = new Queue<TDocument>();
    }
}
