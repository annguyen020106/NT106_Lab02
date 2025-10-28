using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai04 : Form
    {
        [Serializable]
        public class SinhVien
        {
            public string Name { get; set; }
            public string MSSV { get; set; }
            public string Phone { get; set; }
            public double Course1 { get; set; }
            public double Course2 { get; set; }
            public double Course3 { get; set; }
            public double Average { get; set; }

            public void CalcAverage()
            {
                Average = (Course1 + Course2 + Course3) / 3.0;
            }

            public override string ToString()
            {
                return $"{Name} - {MSSV} - {Phone} - {Course1} - {Course2} - {Course3} - {Average:F2}";
            }
        }

        private List<SinhVien> danhSach = new List<SinhVien>();
        private int currentIndex = -1;
        private readonly string folder = Application.StartupPath;
        private readonly string inputFile;
        private readonly string outputFile;

        public Bai04()
        {
            InitializeComponent();
            inputFile = Path.Combine(folder, "input4.txt");
            outputFile = Path.Combine(folder, "output4.txt");
        }
        public Bai04(Point location, Size size) : this()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
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
        // Kiểm tra
        private bool IsValidSinhVien(out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(TextBox_Name.Text) ||
                string.IsNullOrWhiteSpace(TextBox_MSSV.Text) ||
                string.IsNullOrWhiteSpace(TextBox_Phone.Text) ||
                string.IsNullOrWhiteSpace(TextBox_Course1.Text) ||
                string.IsNullOrWhiteSpace(TextBox_Course2.Text) ||
                string.IsNullOrWhiteSpace(TextBox_Course3.Text))
            {
                error = "Vui lòng nhập đầy đủ thông tin sinh viên!";
                return false;
            }

            if (!Regex.IsMatch(TextBox_Name.Text.Trim(), @"^[\p{L}\s]+$"))
            {
                error = "Tên chỉ được chứa chữ cái và khoảng trắng!";
                return false;
            }

            if (!Regex.IsMatch(TextBox_MSSV.Text.Trim(), @"^\d{8}$"))
            {
                error = "MSSV phải gồm đúng 8 chữ số!";
                return false;
            }

            if (!Regex.IsMatch(TextBox_Phone.Text.Trim(), @"^0\d{9}$"))
            {
                error = "SĐT phải bắt đầu bằng 0 và đủ 10 chữ số!";
                return false;
            }

            if (!float.TryParse(TextBox_Course1.Text, out float c1) || c1 < 0 || c1 > 10 ||
                !float.TryParse(TextBox_Course2.Text, out float c2) || c2 < 0 || c2 > 10 ||
                !float.TryParse(TextBox_Course3.Text, out float c3) || c3 < 0 || c3 > 10)
            {
                error = "Điểm phải là số thực từ 0 đến 10!";
                return false;
            }

            return true;
        }
        // Nhấn Exit
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Home home = new Home(this.Location, this.Size);
            home.Show();
            this.Hide();
        }
        // Nhấn Add
        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidSinhVien(out string error))
                {
                    MessageBox.Show(error, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SinhVien st = new SinhVien
                {
                    Name = TextBox_Name.Text.Trim(),
                    MSSV = TextBox_MSSV.Text.Trim(),
                    Phone = TextBox_Phone.Text.Trim(),
                    Course1 = double.Parse(TextBox_Course1.Text),
                    Course2 = double.Parse(TextBox_Course2.Text),
                    Course3 = double.Parse(TextBox_Course3.Text)
                };
                st.CalcAverage();

                danhSach.Add(st);
                //TextBox_Average.Text = st.Average.ToString("F2");
                UpdateContentBox();

                MessageBox.Show("Đã thêm sinh viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm: {ex.Message}");
            }
        }
        // Write
        private void Button_Write_Click(object sender, EventArgs e)
        {
            try
            {
                if (danhSach.Count == 0)
                {
                    MessageBox.Show("Danh sách trống, không ghi file được!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (StreamWriter sw = new StreamWriter(inputFile))
                {
                    foreach (var sv in danhSach)
                    {
                        sw.WriteLine($"{sv.Name}");
                        sw.WriteLine($"{sv.MSSV}");
                        sw.WriteLine($"{sv.Phone}");
                        sw.WriteLine($"{sv.Course1}");
                        sw.WriteLine($"{sv.Course2}");
                        sw.WriteLine($"{sv.Course3}");
                        sw.WriteLine($"{sv.Average:F2}");
                        sw.WriteLine(); // dòng trống giữa 2 sinh viên
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi ghi file: {ex.Message}");
            }
        }
        // Nhấn Read
        private void Button_Read_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(inputFile))
                {
                    MessageBox.Show("Không tìm thấy file input4.txt!");
                    return;
                }

                danhSach.Clear();

                using (StreamReader sr = new StreamReader(inputFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string name = sr.ReadLine();
                        if (string.IsNullOrWhiteSpace(name)) continue;

                        string mssv = sr.ReadLine();
                        string phone = sr.ReadLine();
                        double c1 = double.Parse(sr.ReadLine());
                        double c2 = double.Parse(sr.ReadLine());
                        double c3 = double.Parse(sr.ReadLine());
                        double avg = double.Parse(sr.ReadLine());

                        danhSach.Add(new SinhVien
                        {
                            Name = name,
                            MSSV = mssv,
                            Phone = phone,
                            Course1 = c1,
                            Course2 = c2,
                            Course3 = c3,
                            Average = avg
                        });

                        sr.ReadLine(); // bỏ qua dòng trống giữa 2 sinh viên
                    }
                }

                currentIndex = 0;
                UpdateContentBox();
                if (danhSach.Count > 0)
                    ShowSinhVien(currentIndex);

                MessageBox.Show("Đọc file input4.txt thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc file: {ex.Message}");
            }
        }
        // Nhấn Back
        private void Button_Back_Click(object sender, EventArgs e)
        {
            if (danhSach.Count == 0) return;
            currentIndex = (currentIndex - 1 + danhSach.Count) % danhSach.Count;
            ShowSinhVien(currentIndex);
        }
        // Nhấn Next
        private void Button_Next_Click(object sender, EventArgs e)
        {
            if (danhSach.Count == 0) return;
            currentIndex = (currentIndex + 1) % danhSach.Count;
            ShowSinhVien(currentIndex);
        }
        // Nhấn Delete
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (danhSach.Count == 0)
            {
                MessageBox.Show("Danh sách trống!");
                return;
            }
            danhSach.RemoveAt(currentIndex);

            if (danhSach.Count == 0)
            {
                currentIndex = -1;
                ClearOutput();
            }
            else
            {
                if (currentIndex >= danhSach.Count)
                    currentIndex = danhSach.Count - 1;

                ShowSinhVien(currentIndex);
            }

            UpdateContentBox();
            MessageBox.Show("Đã xóa sinh viên hiện tại!");
        }
        
        private void ShowSinhVien(int index)
        {
            if (index < 0 || index >= danhSach.Count) return;
            var s = danhSach[index];
            TextBox_Out_Name.Text = s.Name;
            TextBox_Out_MSSV.Text = s.MSSV;
            TextBox_Out_Phone.Text = s.Phone;
            TextBox_Out_Course1.Text = s.Course1.ToString();
            TextBox_Out_Course2.Text = s.Course2.ToString();
            TextBox_Out_Course3.Text = s.Course3.ToString();
            TextBox_Out_Average.Text = s.Average.ToString("F2");
            TextBox_Page.Text = $"{index + 1}/{danhSach.Count}";
        }

        private void UpdateContentBox()
        {
            TextBox_Content.Clear();
            foreach (var sv in danhSach)
            {
                TextBox_Content.AppendText(
                    $"{sv.Name}\r\n" +
                    $"{sv.MSSV}\r\n" +
                    $"{sv.Phone}\r\n" +
                    $"{sv.Course1}\r\n" +
                    $"{sv.Course2}\r\n" +
                    $"{sv.Course3}\r\n" +
                    $"{sv.Average:F2}\r\n\r\n"
                );
            }
        }

        private void ClearOutput()
        {
            TextBox_Out_Name.Text = "";
            TextBox_Out_MSSV.Text = "";
            TextBox_Out_Phone.Text = "";
            TextBox_Out_Course1.Text = "";
            TextBox_Out_Course2.Text = "";
            TextBox_Out_Course3.Text = "";
            TextBox_Out_Average.Text = "";
            TextBox_Page.Text = "0/0";
        }
    }
}
