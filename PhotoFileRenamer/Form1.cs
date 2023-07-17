using PhotoFileRenamer.Data;

namespace PhotoFileRenamer;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void BrowseButton_Click(object sender, EventArgs e)
    {
        var f = new FolderBrowserDialog();
        f.SelectedPath = FolderWithPhotos.Text;

        if (f.ShowDialog() == DialogResult.OK)
        {
            FolderWithPhotos.Text = f.SelectedPath;
        }
    }

    private void LoadButton_Click(object sender, EventArgs e)
    {
        var dir = new DirectoryInfo(FolderWithPhotos.Text);

        var photoFiles =
            dir.GetFiles()
                .Where(o => IsPhotoFile(o.Name))
                .Select(o => new PhotoFile(o))
                .OrderBy(o => o.Timestamp)
                .ToList();

        Grid.Rows.Clear();
        foreach (var file in photoFiles)
        {
            var row = new DataGridViewRow();
            row.Tag = file;

            var cell1 = new DataGridViewTextBoxCell();
            cell1.Value = file.File.Name;
            row.Cells.Add(cell1);

            var cell2 = new DataGridViewTextBoxCell();
            cell2.Value = file.FileTimestamp.ToString("dd.MM.yyyy HH:mm:ss");
            row.Cells.Add(cell2);

            var cell3 = new DataGridViewTextBoxCell();
            cell3.Value = file.ExifTimestamp?.ToString("dd.MM.yyyy HH:mm:ss") ?? "";
            row.Cells.Add(cell3);

            var cell4 = new DataGridViewTextBoxCell();
            cell4.Value =
                file.HasAlreadyBeenRenamed()
                    ? file.File.Name
                    : $"{file.Timestamp.ToString("yyyyMMdd_HHmmss")} {file.File.Name}";
            row.Cells.Add(cell4);

            Grid.Rows.Add(row);
        }
    }

    private bool IsPhotoFile(string path)
    {
        if (path.EndsWith(".jpg", StringComparison.CurrentCultureIgnoreCase))
        {
            return true;
        }

        return false;
    }

    private void RenameButton_Click(object sender, EventArgs e)
    {
        foreach (var row in Grid.Rows.Cast<DataGridViewRow>())
        {
            if (row.Tag == null)
            {
                continue;
            }

            var file = (PhotoFile)row.Tag;

            var newName = Path.Combine(file.File.Directory.FullName, (string)row.Cells[3].Value);
            File.Move(file.File.FullName, newName);
        }

        LoadButton_Click(sender, e);
    }
}