#nullable enable

namespace DocumentLib.FileWorking
{
    public interface IFileWorking
    {
        public SuccessObject Create(string? path, out Document.Document document);
        public SuccessObject Open(string? path, out Document.Document document);
        public void SaveAs(string path, Document.Document document);
        public void Save(Document.Document document);
        public void Close();
        public void Print(Document.Document document);
    }
}