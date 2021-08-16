#nullable enable

using System;
using System.IO;
using DocumentLib.Document;
using DocumentLib.FileWorking;

namespace DocumentLib
{
    public class TxtFileWorking : IFileWorking
    {
        public SuccessObject Create(string? path, out Document.Document document)
        {
            if (path == null)
            {
                document = new TxtDocument();
                return new SuccessObject { Success = false, Type = ErrorType.ArgumentNull};
            }

            if (File.Exists(path))
            {
                document = new TxtDocument();
                return new SuccessObject { Success = false, Type = ErrorType.FileIsExist};
            }
            
            document = new TxtDocument(path);
            return new SuccessObject { Success = true, Type = ErrorType.NotError};
            
            //return new TxtDocument(path);
        }

        public SuccessObject Open(string? path, out Document.Document document)
        {
            try
            {
                using var file = new StreamReader(path);
                document = new TxtDocument(path);
                document.Content = file.ReadToEnd();
            }
            catch (ArgumentException)
            {
                document = new TxtDocument();
                return new SuccessObject { Success = false, Type = ErrorType.ArgumentNull };
            }
            catch (FileNotFoundException)
            {
                document = new TxtDocument();
                return new SuccessObject { Success = false, Type = ErrorType.FileNotFound };
            }
            
            return new SuccessObject { Success = true, Type = ErrorType.NotError};
            
            /*var document = new TxtDocument(path);

            using var file = new StreamReader(path);
            document.Content = file.ReadToEnd();
            return document;*/
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