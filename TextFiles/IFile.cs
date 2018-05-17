namespace TextSearch.TextFiles
{
    using System.ComponentModel;

    interface IFile
    {
        bool Read(string path);
        BindingList<string> Find(string keyword);

        string Body { get; }
    }
}