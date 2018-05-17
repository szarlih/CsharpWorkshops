namespace TextSearch
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    using TextSearch.TextFiles;

    /// <summary>
    /// 
    /// </summary>
    public partial class MainForm : Form
    {
        private OpenFileDialog openFileDialog;
        private IFile file;
        public MainForm()
        {
            InitializeComponent();
            CreateFileLoading();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadFile_Click(object sender, EventArgs e)
        {
            CreateFileLoading();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = openFileDialog.FileName;
                FileLoading(SelectedType(openFileDialog.FilterIndex), pathTextBox.Text);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            resultListView.DataSource = (file as IFile).Find(searchTextBox.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        private void CreateFileLoading()
        {
            if (openFileDialog != null)
            {
                return;
            }

            openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = SupportedFileTypes();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string SupportedFileTypes()
        {
            string files = string.Empty;
            foreach (string type in Enum.GetNames(typeof(FileTypes)))
            {
                files += type + "|*." + type.ToLower() + "|";
            }

            return files.Substring(0, files.Length - 1);
        }

        private FileTypes SelectedType(int index)
        {
            return (FileTypes) index;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="path"></param>
        private void FileLoading(FileTypes type, string path)
        {
            switch (type)
            {
                case FileTypes.RTF:
                    file = new Rtf(path);
                    break;
                default:
                    file = new Txt(path);                    
                    break;
            }

            textBodyTextBox.Text = file.Body;
            documentNameLabel.Text = "Nazwa dokumentu: " + Path.GetFileName(path);
        }
    }
}