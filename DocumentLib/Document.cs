namespace DocumentLib
{
    public abstract class Document
    {
        public string Path { get; set; }
        public string Content { get; set; }

        public Document(string path)
        {
            Path = path;
            Content = string.Empty;
        }
    }
}