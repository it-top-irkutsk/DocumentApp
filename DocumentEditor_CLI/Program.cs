using System;
using DocumentLib;
using DocumentLib.Document;
using DocumentLib.FileWorking;

namespace DocumentEditor_CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = string.Empty;
            
            IFileWorking fileWorking;
            
            Console.WriteLine("Выьерите какой файл вы хотели бы открыть:");
            Console.WriteLine("1. TXT");
            Console.WriteLine("2. MD");
            var select = Console.ReadLine();
            switch (select)
            {
                case "1":
                    fileWorking = new TxtFileWorking();
                    path = @"C:\Users\Stari\Desktop\BestOil.txt";
                    break;
                case "2":
                    fileWorking = new MdFileWorking();
                    path = @"C:\Users\Stari\Desktop\BestOil.md";
                    break;
                default:
                    return;
            }

            var document = fileWorking.Open(path);
            
            Show(document);
        }

        static void Show(Document document)
        {
            var type = document.GetType().FullName;
            Console.WriteLine(type);

            switch (type)
            {
                case "DocumentLib.Document.TxtDocument":
                    TxtShow(document);
                    break;
                case "DocumentLib.Document.MdDocument":
                    MdShow(document);
                    break;
            }
        }

        static void TxtShow(Document document)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(document.Content);
            Console.ResetColor();
        }

        static void MdShow(Document document)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(document.Content);
            Console.ResetColor();
        }
    }
}