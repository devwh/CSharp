using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    public interface IDocument
    {
        string title { get; set; }
        string content { get; set; }
    }
    public class Document : IDocument
    { 
        public Document()
        {

        }
        public Document(string title, string content)
        {
            this.title = title;
            this.content = content;
        }
        public string title { get; set; }
        public string content { get; set; }
    }
}
