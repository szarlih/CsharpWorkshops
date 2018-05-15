namespace TextSearch.TextFiles
{
    using System;
    using System.ComponentModel;
    using System.IO;

    class Txt : IFile
    {
        protected string filePath;
        protected string body;

        public Txt()
        {
            body = string.Empty;
        }

        public Txt(string path)
        {
            body = string.Empty;
            Read(path);
        }

        public string Body
        {
            get
            {
                return body;
            }
        }

        public bool Read(string path)
        {
            try
            {
                StreamReader reader = new StreamReader(path);
                body = reader.ReadToEnd();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public BindingList<string> Find(string keyword)
        {
            return Search.Find(keyword, body);
        }
    }
}