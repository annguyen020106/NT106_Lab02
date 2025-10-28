using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai07 : Form
    {
        public Bai07()
        {
            InitializeComponent();
        }
        public Bai07(Point location, Size size)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
        }
        private void Lab02_Bai07_Load(object sender, EventArgs e)
        {
            LoadDrives();
            TreeView.BeforeExpand += TreeView_BeforeExpand;
            TreeView.AfterSelect += TreeView_AfterSelect;
        }

        private void LoadDrives()
        {
            TreeView.Nodes.Clear();
            foreach (var drive in DriveInfo.GetDrives())
            {
                try
                {
                    if (!drive.IsReady) continue;
                    TreeNode node = new TreeNode(drive.Name)
                    {
                        Tag = drive.RootDirectory.FullName
                    };
                    node.Nodes.Add("...");
                    
                }
                catch { }
            }
        }

        private void TreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            string path = e.Node.Tag.ToString();
            e.Node.Nodes.Clear();

            try
            {
                foreach (var dir in Directory.GetDirectories(path))
                {
                    TreeNode dirNode = new TreeNode(Path.GetFileName(dir)) { Tag = dir };
                    dirNode.Nodes.Add("...");
                    e.Node.Nodes.Add(dirNode);
                }

                foreach (var file in Directory.GetFiles(path))
                {
                    TreeNode fileNode = new TreeNode(Path.GetFileName(file)) { Tag = file };
                    e.Node.Nodes.Add(fileNode);
                }
            }
            catch
            {
                MessageBox.Show("Không thể truy cập thư mục: " + path);
            }
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag.ToString();
            if (File.Exists(path))
                DisplayFileContent(path);
        }

        private void DisplayFileContent(string path)
        {
            // Dọn dẹp
            PictureBox.Controls.Clear();
            PictureBox.Image = null;

            string ext = Path.GetExtension(path).ToLower();
            string[] textExts = { ".txt", ".cs", ".json", ".xml", ".html", ".htm", ".log", ".ini", ".config" };
            string[] imgExts = { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".tiff" };

            try
            {
                if (textExts.Contains(ext))
                {
                    TextBox txt = new TextBox
                    {
                        Multiline = true,
                        ReadOnly = true,
                        ScrollBars = ScrollBars.Both,
                        Dock = DockStyle.Fill,
                        Font = new Font("Consolas", 10),
                        Text = File.ReadAllText(path)
                    };
                    PictureBox.Controls.Add(txt);
                }
                else if (imgExts.Contains(ext))
                {
                    using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        Image img = Image.FromStream(fs);
                        PictureBox.Image = new Bitmap(img);
                    }
                    PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    Label lbl = new Label
                    {
                        Text = "Không thể hiển thị định dạng này.",
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Segoe UI", 11, FontStyle.Bold)
                    };
                    PictureBox.Controls.Add(lbl);
                }
            }
            catch (Exception ex)
            {
                Label lbl = new Label
                {
                    Text = "Lỗi khi mở file: " + ex.Message,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 10)
                };
                PictureBox.Controls.Add(lbl);
            }
        }
        // Nhấn Exit
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Home home = new Home(this.Location, this.Size);
            home.Show();
            this.Hide();
        }
    }
}
