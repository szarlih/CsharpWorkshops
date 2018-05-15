namespace TextSearch.TextFiles
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    class Rtf : IFile
    {
        public Rtf(string path)
        {
            Body = string.Empty;
            Read(path);
        }

        public string Body { get; private set; }

        public BindingList<string> Find(string keyword)
        {
            return Search.Find(keyword, Body);
        }

        public bool Read(string path)
        {
            try
            {
                using (RichTextBox rtb = new RichTextBox())
                {
                    rtb.Rtf = System.IO.File.ReadAllText(path);
                    Body = rtb.Text;
                }

            }
            catch(Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}
