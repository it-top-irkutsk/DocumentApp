using System.IO;
using DocumentLib.Document;
using DocumentLib.FileWorking;

namespace DocumentLib
{
    public class TxtFileWorking : IFileWorking
    {
        public Document.Document Create(string path)
        {
            return new TxtDocument(path);
        }

        public Document.Document Open(string path)
        {
            var document = new TxtDocument(path);

            using var file = new StreamReader(path);
            document.Content = file.ReadToEnd();
            return document;
        }

        public void SaveAs(string path, Document.Document document)
        {
            using var file = new StreamWriter(path, false);
            file.WriteAsync(document.Content);
            document.Path = path;
        }

        public void Save(Document.Document document)
        {
            SaveAs(document.Path, document);
        }

        public void Close()
        {
            //TODO
        }

        public void Print(Document.Document document)
        {
            //TODO
        }
    }
}