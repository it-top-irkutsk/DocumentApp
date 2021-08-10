using System.IO;
using DocumentLib.Document;

namespace DocumentLib.FileWorking
{
    public class MdFileWorking : IFileWorking
    {
        public Document.Document Create(string path)
        {
            return new MdDocument(path);
        }

        public Document.Document Open(string path)
        {
            var document = new MdDocument(path);

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