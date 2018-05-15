using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSearch.TextFiles
{
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
