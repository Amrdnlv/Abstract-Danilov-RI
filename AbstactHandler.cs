using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Tasks1_DavilovRI
{
    abstract class AbstractHandler
    {
        protected string filename;
        public AbstractHandler(string filename)
        {
            this.filename = filename;
        }
        public void Open() 
        {
            Console.WriteLine($"{filename} открыт");
        }
        public void Create() {
            Console.WriteLine($"{filename} создан");
        }
        public void Chenge() {
            Console.WriteLine($"{filename} отредактирован");
        }
        public abstract void Save();

    }
    class XMLHandler :AbstractHandler
    {
        public XMLHandler(string filename):base(filename)
        {

        }

        public override void Save() => Console.Write($"{filename} Save XML file");
    }
    class TXTHandler : AbstractHandler
    {
        public TXTHandler(string filename) : base(filename)
        {

        }
        public override void Save() => Console.Write("Save TXT file");

    }
    class DOCHandler : AbstractHandler
    {
        public DOCHandler(string filename) : base(filename)
        {

        }
        public override void Save() => Console.Write("Save DOC file");

    }
}
