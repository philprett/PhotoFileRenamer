namespace PhotoFileRenamer;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        FolderWithPhotos = new TextBox();
        label1 = new Label();
        LoadButton = new Button();
        BrowseButton = new Button();
        Grid = new DataGridView();
        SourceFilename = new DataGridViewTextBoxColumn();
        FileTimestamp = new DataGridViewTextBoxColumn();
        EXIFTimestamp = new DataGridViewTextBoxColumn();
        NewFilename = new DataGridViewTextBoxColumn();
        label2 = new Label();
        RenameButton = new Button();
        ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
        SuspendLayout();
        // 
        // FolderWithPhotos
        // 
        FolderWithPhotos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        FolderWithPhotos.Location = new Point(124, 12);
        FolderWithPhotos.Name = "FolderWithPhotos";
        FolderWithPhotos.Size = new Size(928, 23);
        FolderWithPhotos.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 15);
        label1.Name = "label1";
        label1.Size = new Size(106, 15);
        label1.TabIndex = 1;
        label1.Text = "Folder with photos";
        // 
        // LoadButton
        // 
        LoadButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        LoadButton.Location = new Point(1139, 11);
        LoadButton.Name = "LoadButton";
        LoadButton.Size = new Size(75, 23);
        LoadButton.TabIndex = 2;
        LoadButton.Text = "Load";
        LoadButton.UseVisualStyleBackColor = true;
        LoadButton.Click += LoadButton_Click;
        // 
        // BrowseButton
        // 
        BrowseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        BrowseButton.Location = new Point(1058, 11);
        BrowseButton.Name = "BrowseButton";
        BrowseButton.Size = new Size(75, 23);
        BrowseButton.TabIndex = 3;
        BrowseButton.Text = "Browse";
        BrowseButton.UseVisualStyleBackColor = true;
        BrowseButton.Click += BrowseButton_Click;
        // 
        // Grid
        // 
        Grid.AllowUserToAddRows = false;
        Grid.AllowUserToDeleteRows = false;
        Grid.AllowUserToResizeRows = false;
        Grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        Grid.BackgroundColor = SystemColors.Window;
        Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        Grid.Columns.AddRange(new DataGridViewColumn[] { SourceFilename, FileTimestamp, EXIFTimestamp, NewFilename });
        Grid.Location = new Point(12, 78);
        Grid.Name = "Grid";
        Grid.RowHeadersVisible = false;
        Grid.RowTemplate.Height = 25;
        Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        Grid.Size = new Size(1202, 535);
        Grid.TabIndex = 4;
        // 
        // SourceFilename
        // 
        SourceFilename.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        SourceFilename.HeaderText = "Filename";
        SourceFilename.Name = "SourceFilename";
        SourceFilename.ReadOnly = true;
        // 
        // FileTimestamp
        // 
        FileTimestamp.HeaderText = "File Timestamp";
        FileTimestamp.Name = "FileTimestamp";
        FileTimestamp.ReadOnly = true;
        FileTimestamp.Width = 150;
        // 
        // EXIFTimestamp
        // 
        EXIFTimestamp.HeaderText = "EXIF Timestamp";
        EXIFTimestamp.Name = "EXIFTimestamp";
        EXIFTimestamp.ReadOnly = true;
        EXIFTimestamp.Width = 150;
        // 
        // NewFilename
        // 
        NewFilename.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        NewFilename.HeaderText = "New Filename";
        NewFilename.Name = "NewFilename";
        NewFilename.ReadOnly = true;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 60);
        label2.Name = "label2";
        label2.Size = new Size(65, 15);
        label2.TabIndex = 5;
        label2.Text = "Photo Files";
        // 
        // RenameButton
        // 
        RenameButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        RenameButton.Location = new Point(12, 619);
        RenameButton.Name = "RenameButton";
        RenameButton.Size = new Size(1202, 135);
        RenameButton.TabIndex = 6;
        RenameButton.Text = "Rename All Files";
        RenameButton.UseVisualStyleBackColor = true;
        RenameButton.Click += RenameButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1226, 766);
        Controls.Add(RenameButton);
        Controls.Add(label2);
        Controls.Add(Grid);
        Controls.Add(BrowseButton);
        Controls.Add(LoadButton);
        Controls.Add(label1);
        Controls.Add(FolderWithPhotos);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Photo File Renamer";
        ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox FolderWithPhotos;
    private Label label1;
    private Button LoadButton;
    private Button BrowseButton;
    private DataGridView Grid;
    private Label label2;
    private Button RenameButton;
    private DataGridViewTextBoxColumn SourceFilename;
    private DataGridViewTextBoxColumn FileTimestamp;
    private DataGridViewTextBoxColumn EXIFTimestamp;
    private DataGridViewTextBoxColumn NewFilename;
}