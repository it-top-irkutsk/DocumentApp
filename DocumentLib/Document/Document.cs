namespace DocumentLib.Document
{
    public abstract class Document
    {
        public string Path { get; set; }
        public string Content { get; set; }

        protected Document(string path)
        {
            Path = path;
            Content = string.Empty;
        }
    }
}