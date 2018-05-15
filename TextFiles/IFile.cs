namespace TextSearch.TextFiles
{
    using System.ComponentModel;

    interface IFile
    {
        bool Read(string sciezka);
        BindingList<string> Find(string keyword);

        string Body { get; }
    }
}