namespace DocumentLib.FileWorking
{
    public interface IFileWorking
    {
        public Document.Document Create(string path);
        public Document.Document Open(string path);
        public void SaveAs(string path, Document.Document document);
        public void Save(Document.Document document);
        public void Close();
        public void Print(Document.Document document);
    }
}