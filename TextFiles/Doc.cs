namespace TextSearch.TextFiles
{
    using System;
    using System.ComponentModel;

    class Doc : IFile
    {
        public Doc()
        {
        }

        public Doc(string path)
        {
            Read(path);
        }

        public string Body => throw new NotImplementedException();

        public BindingList<string> Find(string keyword)
        {
            throw new NotImplementedException();
        }

        public bool Read(string sciezka)
        {
            return false;
        }

    }
}
