namespace DocumentLib
{
    public abstract class Document
    {
        protected string _path;
        public string Content { get; protected set; }
    }
}