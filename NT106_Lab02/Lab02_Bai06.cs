using NT106_Lab02;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NT106_Lab02
{
    public partial class Lab02_Bai06 : Form
    {
        private List<string> dsMonAn = new List<string>();
        private readonly string filePath = Path.Combine(Application.StartupPath, "MonAn.txt");

        public Lab02_Bai06()
        {
            InitializeComponent();
            LoadDanhSach();
        }
        public Lab02_Bai06(Point location, Size size)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
            this.Size = size;
            LoadDanhSach();
        }

        private void LoadDanhSach()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    dsMonAn = new List<string>(File.ReadAllLines(filePath));
                    TextBox_DanhSach.Text = string.Join(Environment.NewLine, dsMonAn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc file: {ex.Message}");
            }
        }


        private void SaveDanhSach()
        {
            try
            {
                File.WriteAllLines(filePath, dsMonAn);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi ghi file: {ex.Message}");
            }
        }
        // Nhấn Exit
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Home home = new Home(this.Location, this.Size);
            home.Show();
            this.Hide();
        }

        // Nhấn Push
        private void Button_Push_Click(object sender, EventArgs e)
        {
            string monMoi = TextBox_MonMoi.Text.Trim();

            if (string.IsNullOrEmpty(monMoi))
            {
                MessageBox.Show("Vui lòng nhập món ăn!", "Thông báo");
                return;
            }

            dsMonAn.Add(monMoi);
            TextBox_DanhSach.Text = string.Join(Environment.NewLine, dsMonAn);
            TextBox_MonMoi.Clear();
            TextBox_MonMoi.Focus();
            SaveDanhSach();
        }

        // Nhấn Find
        private void Button_Find_Click(object sender, EventArgs e)
        {
            if (dsMonAn.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn trống, hãy thêm món trước!", "Thông báo");
                return;
            }

            Random rand = new Random();
            int index = rand.Next(dsMonAn.Count);
            string monAnChon = dsMonAn[index];
            TextBox_KQ.Text = monAnChon;
        }
        // Nhấn Delete
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa toàn bộ danh sách?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dsMonAn.Clear();
                TextBox_DanhSach.Clear();
                TextBox_KQ.Clear();
                SaveDanhSach();
            }
        }
        // Nhấn Read
        private void Button_Read_Click(object sender, EventArgs e)
        {
            LoadDanhSach();
            MessageBox.Show("Đã tải lại danh sách từ file!");
        }
        // Nhấn Write
        private void Button_Write_Click(object sender, EventArgs e)
        {
            SaveDanhSach();
            MessageBox.Show("Đã lưu danh sách vào file MonAn.txt!");
        }
    }
}
