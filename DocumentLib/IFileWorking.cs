namespace DocumentLib
{
    public interface IFileWorking
    {
        public Document Open(string path);
        public bool SaveAs(string path, Document document);
        public bool Save(Document document);
        public void Close();
        public void Print(Document document);
    }
}