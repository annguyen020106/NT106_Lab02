using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
            InitForm();
        }
        public Bai05(Point location, Size size)
        {
            InitializeComponent();
            InitForm();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
        }

        private readonly Dictionary<string, (int gia, List<int> phong)> dsPhim = new()
        {
            { "Đào, phở và piano", (45000, new List<int>{1,2,3}) },
            { "Mai", (100000, new List<int>{2,3}) },
            { "Gặp lại chị bầu", (70000, new List<int>{1}) },
            { "Tarot", (90000, new List<int>{3}) }
        };

        private readonly HashSet<string> gheDaBan = new();
        private bool _dangXuLy = false;

        private void InitForm()
        {
            ComboBox_Movie.Items.AddRange(dsPhim.Keys.ToArray());
            ComboBox_Movie.SelectedIndexChanged += ComboBox_Phim_Chon;

            CheckedListBox_Seat.Items.Clear();
            for (char hang = 'A'; hang <= 'C'; hang++)
                for (int i = 1; i <= 5; i++)
                    CheckedListBox_Seat.Items.Add($"{hang}{i}");

            ProgressBar.Visible = false;
        }
        // Nhấn Exit
        private void Button_Exit_Click(object? sender, EventArgs e)
        {
            Home home = new Home(this.Location, this.Size);
            home.Show();
            this.Hide();
        }
        // Nhấn Buy
        private void Button_Buy_Click(object? sender, EventArgs e)
        {
            if (_dangXuLy) return;
            _dangXuLy = true;

            this.BeginInvoke(new Action(() =>
            {
                try
                {
                    string hoTen = TextBox_Name.Text.Trim();
                    if (string.IsNullOrEmpty(hoTen))
                    {
                        MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(TextBox_Name.Text))
                    {
                        MessageBox.Show("Tên khách hàng không được toàn khoảng trắng!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (hoTen.Any(ch => !char.IsLetter(ch) && !char.IsWhiteSpace(ch)))
                    {
                        MessageBox.Show("Tên khách hàng không được chứa số hoặc ký tự đặc biệt!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string? tenPhim = ComboBox_Movie.SelectedItem?.ToString();
                    string? phongStr = ComboBox_Room.SelectedItem?.ToString();

                    if (tenPhim == null)
                    {
                        MessageBox.Show("Vui lòng chọn phim!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (phongStr == null)
                    {
                        MessageBox.Show("Vui lòng chọn phòng chiếu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!dsPhim.ContainsKey(tenPhim))
                    {
                        MessageBox.Show("Phim không tồn tại!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var selectedSeats = CheckedListBox_Seat.CheckedItems.Cast<object>()
                        .Select(s => s.ToString()?.Trim() ?? "")
                        .Where(s => s != "")
                        .ToList();

                    if (selectedSeats.Count == 0)
                    {
                        MessageBox.Show("Vui lòng chọn ít nhất 1 ghế!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (selectedSeats.Count > 2)
                    {
                        MessageBox.Show("Không được chọn nhiều hơn 2 ghế!", "Giới hạn lựa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int phong = int.Parse(phongStr.Split(' ')[1]);
                    var gheTrung = selectedSeats
                        .Where(g => gheDaBan.Contains($"{tenPhim}-{phong}-{g}"))
                        .ToList();

                    if (gheTrung.Count > 0)
                    {
                        MessageBox.Show($"Ghế đã bán: {string.Join(", ", gheTrung)}. Vui lòng chọn lại.", "Ghế đã có người", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    int giaChuan = dsPhim[tenPhim].gia;
                    int tongTien = 0;
                    var chiTietGhe = new List<string>();

                    foreach (var ghe in selectedSeats)
                    {
                        int gia = TinhGiaVe(ghe, giaChuan);
                        tongTien += gia;
                        chiTietGhe.Add($"{ghe} - {gia:N0} đ");
                        gheDaBan.Add($"{tenPhim}-{phong}-{ghe}");
                    }

                    var sb = new StringBuilder();
                    sb.AppendLine($"Họ tên: {hoTen}");
                    sb.AppendLine($"Phim: {tenPhim}");
                    sb.AppendLine($"Phòng chiếu: {phong}");
                    sb.AppendLine("Ghế:");
                    foreach (var line in chiTietGhe) sb.AppendLine("  " + line);
                    sb.AppendLine($"Tổng tiền: {tongTien:N0} đ");
                    TextBox_KQ.Text = sb.ToString();

                    for (int i = 0; i < CheckedListBox_Seat.Items.Count; i++)
                        CheckedListBox_Seat.SetItemChecked(i, false);

                    MessageBox.Show("Mua vé thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    _dangXuLy = false;
                }
            }));
        }
        // Nhấn Delete
        private void Button_Delete_Click(object? sender, EventArgs e)
        {
            TextBox_Name.Clear();
            TextBox_KQ.Clear();
            ComboBox_Movie.SelectedIndex = -1;
            ComboBox_Room.Items.Clear();

            for (int i = 0; i < CheckedListBox_Seat.Items.Count; i++)
                CheckedListBox_Seat.SetItemChecked(i, false);
        }
               
        // Nhấn Export File
        private void Button_ExportFile_Click(object? sender, EventArgs e)
        {
            if (_dangXuLy) return;
            _dangXuLy = true;

            try
            {
                int tongGheMoiPhong = CheckedListBox_Seat.Items.Count;
                var thongKe = dsPhim.Select(kv =>
                {
                    string tenPhim = kv.Key;
                    int giaChuan = kv.Value.gia;
                    var phongList = kv.Value.phong;
                    int tongGhe = phongList.Count * tongGheMoiPhong;
                    int veBan = 0, doanhThu = 0;

                    foreach (int phong in phongList)
                    {
                        var ghePhim = gheDaBan.Where(g => g.StartsWith($"{tenPhim}-{phong}-")).ToList();
                        veBan += ghePhim.Count;
                        foreach (var ghe in ghePhim)
                            doanhThu += TinhGiaVe(ghe.Split('-')[2], giaChuan);
                    }

                    int veTon = tongGhe - veBan;
                    double tiLe = tongGhe > 0 ? (double)veBan / tongGhe * 100 : 0;
                    return (tenPhim, veBan, veTon, tiLe, doanhThu);
                }).OrderByDescending(t => t.doanhThu).ToList();

                using SaveFileDialog sfd = new()
                {
                    Title = "Chọn nơi lưu thống kê",
                    Filter = "Text File|*.txt",
                    FileName = "output5.txt"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;

                    ProgressBar.Visible = true;
                    ProgressBar.Minimum = 0;
                    ProgressBar.Maximum = thongKe.Count;
                    ProgressBar.Value = 0;
                    ProgressBar.Step = 1;

                    using (StreamWriter sw = new(filePath, false, Encoding.UTF8))
                    {
                        sw.WriteLine("THỐNG KÊ PHÒNG VÉ");
                        sw.WriteLine(new string('-', 40));
                        int rank = 1;

                        foreach (var p in thongKe)
                        {
                            sw.WriteLine($"Hạng {rank++}: {p.tenPhim}");
                            sw.WriteLine($"  Vé bán: {p.veBan}");
                            sw.WriteLine($"  Vé tồn: {p.veTon}");
                            sw.WriteLine($"  Tỉ lệ bán: {p.tiLe:F2}%");
                            sw.WriteLine($"  Doanh thu: {p.doanhThu:N0} đ");
                            sw.WriteLine();

                            ProgressBar.PerformStep();
                            Application.DoEvents();
                        }
                    }

                    MessageBox.Show("Đã xuất file thống kê thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try { System.Diagnostics.Process.Start("notepad.exe", filePath); } catch { }

                    ProgressBar.Visible = false;
                }
            }
            finally
            {
                _dangXuLy = false;
            }
        }

        private void ComboBox_Phim_Chon(object? sender, EventArgs e)
        {
            if (_dangXuLy) return;
            ComboBox_Room.Items.Clear();

            if (ComboBox_Movie.SelectedItem is string tenPhim && dsPhim.ContainsKey(tenPhim))
            {
                var phim = dsPhim[tenPhim];
                foreach (int p in phim.phong)
                    ComboBox_Room.Items.Add($"Phòng {p}");
            }

            for (int i = 0; i < CheckedListBox_Seat.Items.Count; i++)
                CheckedListBox_Seat.SetItemChecked(i, false);
        }

        private int TinhGiaVe(string ghe, int giaChuan)
        {
            ghe = ghe.Trim().ToUpper();
            return ghe switch
            {
                "A1" or "A5" or "C1" or "C5" => giaChuan / 4,
                "B2" or "B3" or "B4" => giaChuan * 2,
                _ => giaChuan
            };
        }
    }
}
