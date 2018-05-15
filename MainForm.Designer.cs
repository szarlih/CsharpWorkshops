namespace TextSearch
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.documentNameLabel = new System.Windows.Forms.Label();
            this.textBodyTextBox = new System.Windows.Forms.RichTextBox();
            this.resultListView = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.25478F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.74522F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.Controls.Add(this.searchLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.loadFileButton, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.pathTextBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.documentNameLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBodyTextBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.resultListView, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(627, 374);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // searchLabel
            // 
            this.searchLabel.Location = new System.Drawing.Point(3, 3);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(3);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(83, 21);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Szukana fraza:";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(545, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 21);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.searchTextBox, 2);
            this.searchTextBox.Location = new System.Drawing.Point(92, 4);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(447, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // loadFileButton
            // 
            this.loadFileButton.Location = new System.Drawing.Point(545, 30);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(75, 22);
            this.loadFileButton.TabIndex = 4;
            this.loadFileButton.Text = "Plik";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(297, 30);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(242, 20);
            this.pathTextBox.TabIndex = 5;
            this.pathTextBox.TabStop = false;
            // 
            // documentNameLabel
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.documentNameLabel, 2);
            this.documentNameLabel.Location = new System.Drawing.Point(3, 30);
            this.documentNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.documentNameLabel.Name = "documentNameLabel";
            this.documentNameLabel.Size = new System.Drawing.Size(288, 22);
            this.documentNameLabel.TabIndex = 6;
            this.documentNameLabel.Text = "Nazwa dokumentu";
            this.documentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBodyTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBodyTextBox, 2);
            this.textBodyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBodyTextBox.Location = new System.Drawing.Point(3, 58);
            this.textBodyTextBox.Name = "textBodyTextBox";
            this.textBodyTextBox.Size = new System.Drawing.Size(288, 313);
            this.textBodyTextBox.TabIndex = 7;
            this.textBodyTextBox.Text = "";
            // 
            // resultListView
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.resultListView, 2);
            this.resultListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultListView.Location = new System.Drawing.Point(297, 58);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(327, 313);
            this.resultListView.TabIndex = 8;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(627, 374);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "MainForm";
            this.Text = "Wyszukiwarka Tekstowa";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label documentNameLabel;
        private System.Windows.Forms.RichTextBox textBodyTextBox;
        private System.Windows.Forms.ListBox resultListView;
    }
}

