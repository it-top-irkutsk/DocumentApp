namespace DocumentLib.Document
{
    public abstract class Document
    {
        public string Path { get; set; }
        public string Content { get; set; }

        public Document()
        {
            Path = string.Empty;
            Content = string.Empty;
        }
        protected Document(string path)
        {
            Path = path;
            Content = string.Empty;
        }
    }
}