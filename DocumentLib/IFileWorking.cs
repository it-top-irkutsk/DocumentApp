namespace DocumentLib
{
    public interface IFileWorking
    {
        public Document Create(string path);
        public Document Open(string path);
        public void SaveAs(string path, Document document);
        public void Save(Document document);
        public void Close();
        public void Print(Document document);
    }
}