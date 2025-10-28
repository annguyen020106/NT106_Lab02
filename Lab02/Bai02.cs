using System;
using System.IO;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }
        public Bai02(Point location, Size size)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
        }
        // Nhấn Exit
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Home BT = new Home(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        // Nhấn Read
        private void Button_Read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn file .txt cần đọc";
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.InitialDirectory = Application.StartupPath;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string content = File.ReadAllText(ofd.FileName);

                    FileInfo info = new FileInfo(ofd.FileName);
                    string[] lines = File.ReadAllLines(ofd.FileName);
                    string[] words = content.Split(new char[] { ' ', '\n', '\r', '\t' },
                                                   StringSplitOptions.RemoveEmptyEntries);

                    TextBox_FileName.Text = info.Name;
                    TextBox_Size.Text = info.Length + " bytes";
                    TextBox_URL.Text = info.FullName;
                    TextBox_LineCount.Text = lines.Length.ToString();
                    TextBox_WordsCount.Text = words.Length.ToString();
                    TextBox_CharacterCount.Text = content.Length.ToString();
                    TextBox_Content.Text = content;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn file nào!", "Thông báo");
            }
        }
    }
}
