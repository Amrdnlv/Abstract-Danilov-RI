using System;

namespace Lesson4_Tasks1_DavilovRI
{
    
    class Program
    {
        /*
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Требуется:
            Создайте класс AbstractHandler.
            В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
            Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса
            AbstractHandler.
            Написать программу, которая будет выполнять определение документа и для каждого формата
            должны быть методы открытия, создания, редактирования, сохранения определенного
            формата документа.
         */
        static void Main(string[] args)
        {
            Redact txt = new Redact();
            txt.ChooseDocument("example.txt");
            txt.open();
            txt.save();
            Console.WriteLine();
            Console.WriteLine(new string('-', 20));
            Redact doc = new Redact();
            doc.ChooseDocument("readme.doc");
            doc.change();
            doc.save();
        }
    }
}
