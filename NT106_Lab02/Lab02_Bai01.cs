using System;
using System.IO;
using System.Windows.Forms;

namespace NT106_Lab02
{
    public partial class Lab02_Bai01 : Form
    {
        private string inputFilePath;
        private string outputFilePath;
        public Lab02_Bai01()
        {
            InitializeComponent();
            InitializeFilePaths();
        }
        public Lab02_Bai01(Point location, Size size)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
            this.Size = size;
            InitializeFilePaths();
        }
        // Khởi tạo
        private void InitializeFilePaths()
        {
            string folderPath = Application.StartupPath;

            inputFilePath = Path.Combine(folderPath, "input1.txt");
            outputFilePath = Path.Combine(folderPath, "output1.txt");

            if (!File.Exists(inputFilePath))
            {
                try
                {
                    File.WriteAllText(inputFilePath, "Nguyen Chieu An\n24520054\nuit\nlap trinh mang can ban");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể tạo file input1.txt: {ex.Message}");
                }
            }
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
            try
            {
                if (!File.Exists(inputFilePath))
                {
                    MessageBox.Show($"Không tìm thấy file: {inputFilePath}");
                    return;
                }

                string input = File.ReadAllText(inputFilePath);
                TextBox_Content.Text = input;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Nhấn Write
        private void Button_Write_Click(object sender, EventArgs e)
        {
            try
            {
                string input = TextBox_Content.Text;
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Không có nội dung để ghi!");
                    return;
                }
                File.WriteAllText(outputFilePath, input.ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi ghi file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
