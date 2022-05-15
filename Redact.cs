using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Tasks1_DavilovRI
{
    class Redact
    {
        AbstractHandler hendler;

        public void ChooseDocument(string filename)
        {
            string format = filename.Substring(filename.Length - 4);

            switch(format)
            {
                case ".txt": hendler = new TXTHandler(filename);
                    break;
                case ".doc":
                    hendler = new DOCHandler(filename);
                    break;
                case ".xml":
                    hendler = new XMLHandler(filename);
                    break;
                default: Console.WriteLine("Error format");
                    break;
            }
        }
        public void open() => hendler.Open();
        public void change() => hendler.Chenge();
        public void create() => hendler.Create();
        public void save() => hendler.Save();

    }
}
