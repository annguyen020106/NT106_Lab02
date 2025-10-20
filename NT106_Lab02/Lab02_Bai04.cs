using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NT106_Lab02
{
    public partial class Lab02_Bai04 : Form
    {
        private readonly string inputPath;
        private readonly string outputPath;
        private List<SinhVien> danhSach = new List<SinhVien>();
        private int currentIndex = -1;

        public Lab02_Bai04()
        {
            InitializeComponent();
            string folder = Application.StartupPath;
            inputPath = Path.Combine(folder, "input4.txt");
            outputPath = Path.Combine(folder, "output4.txt");
        }

        public Lab02_Bai04(Point location, Size size)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
            this.Size = size;

            string folder = Application.StartupPath;
            inputPath = Path.Combine(folder, "input4.txt");
            outputPath = Path.Combine(folder, "output4.txt");
        }
        private void ClearInput()
        {
            TextBox_Name.Clear();
            TextBox_MSSV.Clear();
            TextBox_Phone.Clear();
            TextBox_Course1.Clear();
            TextBox_Course2.Clear();
            TextBox_Course3.Clear();
        }
        private void Button_Add_Click(object sender, EventArgs e)
        {
            string name = TextBox_Name.Text.Trim();
            string mssv = TextBox_MSSV.Text.Trim();
            string phone = TextBox_Phone.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(mssv))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên và MSSV!");
                return;
            }

            if (!double.TryParse(TextBox_Course1.Text, out double c1) ||
                !double.TryParse(TextBox_Course2.Text, out double c2) ||
                !double.TryParse(TextBox_Course3.Text, out double c3))
            {
                MessageBox.Show("Điểm nhập không hợp lệ!");
                return;
            }

            double avg = Math.Round((c1 + c2 + c3) / 3, 2);

            SinhVien sv = new SinhVien(name, mssv, phone, c1, c2, c3, avg);

            danhSach.Add(sv);

            ListBox_Content.Items.Add(sv.ToString());

            ClearInput();
        }

        private void Button_Write_Click(object sender, EventArgs e)
        {
            try
            {
                if (danhSach.Count == 0)
                {
                    MessageBox.Show("Chưa có sinh viên nào để ghi!");
                    return;
                }

                using (StreamWriter sw = new StreamWriter(inputPath))
                {
                    foreach (var sv in danhSach)
                        sw.WriteLine($"{sv.Name};{sv.MSSV};{sv.Phone};{sv.Course1};{sv.Course2};{sv.Course3};{sv.Average}");
                }

                double avgClass = danhSach.Average(s => s.Average);
                var max = danhSach.MaxBy(s => s.Average);
                var min = danhSach.MinBy(s => s.Average);

                using (StreamWriter sw = new StreamWriter(outputPath))
                {
                    sw.WriteLine($"Tổng số sinh viên: {danhSach.Count}");
                    sw.WriteLine($"Điểm trung bình lớp: {avgClass:F2}");
                    sw.WriteLine($"Cao nhất: {max.Name} ({max.Average})");
                    sw.WriteLine($"Thấp nhất: {min.Name} ({min.Average})");
                }

                MessageBox.Show($"Đã lưu thành công:\n{inputPath}\nvà\n{outputPath}", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message);
            }
        }

        private void Button_Read_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(inputPath))
                {
                    MessageBox.Show("Không tìm thấy file input4.txt!");
                    return;
                }

                danhSach.Clear();
                ListBox_Content.Items.Clear();

                foreach (string line in File.ReadAllLines(inputPath))
                {
                    string[] parts = line.Split(';');
                    if (parts.Length >= 7)
                    {
                        danhSach.Add(new SinhVien(
                            parts[0], parts[1], parts[2],
                            double.Parse(parts[3]),
                            double.Parse(parts[4]),
                            double.Parse(parts[5]),
                            double.Parse(parts[6])
                        ));
                    }
                }

                foreach (var sv in danhSach)
                    ListBox_Content.Items.Add(sv.ToString());

                MessageBox.Show("Đọc file thành công!", "Thông báo");

                if (danhSach.Count > 0)
                {
                    currentIndex = 0;
                    ShowStudent(danhSach[currentIndex]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
            }
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            if (danhSach.Count == 0) return;
            if (currentIndex > 0)
            {
                currentIndex--;
                ShowStudent(danhSach[currentIndex]);
            }
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            if (danhSach.Count == 0) return;
            if (currentIndex < danhSach.Count - 1)
            {
                currentIndex++;
                ShowStudent(danhSach[currentIndex]);
            }
        }

        private void ShowStudent(SinhVien sv)
        {
            TextBox_Out_Name.Text = sv.Name;
            TextBox_Out_MSSV.Text = sv.MSSV;
            TextBox_Out_Phone.Text = sv.Phone;
            TextBox_Out_Course1.Text = sv.Course1.ToString();
            TextBox_Out_Course2.Text = sv.Course2.ToString();
            TextBox_Out_Course3.Text = sv.Course3.ToString();
            TextBox_Out_Average.Text = sv.Average.ToString("F2");
            TextBox_Page.Text = $"{currentIndex + 1}/{danhSach.Count}";
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Home BT = new Home(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
    }

    public class SinhVien
    {
        public string Name { get; set; }
        public string MSSV { get; set; }
        public string Phone { get; set; }
        public double Course1 { get; set; }
        public double Course2 { get; set; }
        public double Course3 { get; set; }
        public double Average { get; set; }

        public SinhVien(string name, string mssv, string phone, double c1, double c2, double c3, double avg)
        {
            Name = name;
            MSSV = mssv;
            Phone = phone;
            Course1 = c1;
            Course2 = c2;
            Course3 = c3;
            Average = avg;
        }

        public override string ToString()
        {
            return $"{MSSV} - {Name} ({Average:F2})";
        }
    }
}
