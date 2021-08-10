using System;
using DocumentLib;
using DocumentLib.FileWorking;

namespace DocumentEditor_CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Stari\Desktop\BestOil.txt";
            IFileWorking fileWorking;

            fileWorking = new TxtFileWorking();
            var document = fileWorking.Open(path);
            Console.WriteLine(document.Content);
        }
    }
}