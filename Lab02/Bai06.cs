using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai06 : Form
    {
        private List<(string tenMon, string nguoiDung, string quyenHan, string hinhAnh)> dsMonAn = new List<(string, string, string, string)>();
        private readonly string dbPath = Path.Combine(Application.StartupPath, "food.db");
        private readonly string imageFolder = @"D:\UIT_Tài liệu_&_Bài tập\NT106_Lập trình mạng căn bản\TH\Lab02\NT106_Lab02\Hình Ảnh";
        private readonly string connString = $"Data Source={{0}};Version=3;Pooling=False;Journal Mode=WAL;Synchronous=Full;";

        public Bai06()
        {
            InitializeComponent();
        }

        public Bai06(Point location, Size size)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
        }

        // KHỞI TẠO DATABASE
        private void InitializeDatabase()
        {
            try
            {
                bool isNewDb = !File.Exists(dbPath);
                string cs = string.Format(connString, dbPath);

                using (var conn = new SQLiteConnection(cs))
                {
                    conn.Open();
                    
                    if (isNewDb)
                    {
                        string createNguoiDung = @"
                            CREATE TABLE NguoiDung (
                                IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                                HoVaTen TEXT NOT NULL,
                                QuyenHan TEXT
                            );";

                        string createMonAn = @"
                            CREATE TABLE MonAn (
                                IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                                TenMon TEXT NOT NULL,
                                HinhAnh TEXT,
                                IDNCC INTEGER,
                                FOREIGN KEY (IDNCC) REFERENCES NguoiDung(IDNCC)
                            );";

                        using (var cmd = new SQLiteCommand(createNguoiDung, conn))
                            cmd.ExecuteNonQuery();

                        using (var cmd = new SQLiteCommand(createMonAn, conn))
                            cmd.ExecuteNonQuery();

                        MessageBox.Show("✅ Đã tạo database food.db!", "Thành công");
                    }
                    
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
        }

        // FORM LOAD
        private void Lab02_Bai06_Load(object sender, EventArgs e)
        {
            InitializeDatabase();
            SetupListView();
            SetupTreeView();
        }

        // SETUP LISTVIEW
        private void SetupListView()
        {
            try
            {
                var lvControls = Controls.Find("ListView_MonAn", true);
                if (lvControls.Length > 0 && lvControls[0] is ListView lv)
                {
                    lv.View = View.Details;
                    lv.Columns.Clear();
                    lv.Columns.Add("Tên Món Ăn", 200);
                    lv.Columns.Add("Người Dùng", 150);
                    lv.Columns.Add("Quyền Hạn", 100);
                    lv.FullRowSelect = true;
                }
            }
            catch { }
        }

        // SETUP TREEVIEW
        private void SetupTreeView()
        {
            // Giả sử bạn có TreeView_KetQua trên form
            // if (Controls.Find("TreeView_KetQua", true).Length > 0)
            // {
            //     var tv = Controls.Find("TreeView_KetQua", true)[0] as TreeView;
            //     if (tv != null)
            //     {
            //         tv.Nodes.Clear();
            //     }
            // }
        }

        // NÚT READ FILE
        private void Button_ReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                dsMonAn.Clear();
                string cs = string.Format(connString, dbPath);

                using (var conn = new SQLiteConnection(cs))
                {
                    conn.Open();
                    string sql = @"
                        SELECT m.IDMA, m.TenMon, m.HinhAnh, m.IDNCC, n.HoVaTen, n.QuyenHan
                        FROM MonAn m
                        LEFT JOIN NguoiDung n ON m.IDNCC = n.IDNCC
                        ORDER BY m.IDMA;";

                    using (var cmd = new SQLiteCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tenMon = reader["TenMon"].ToString() ?? "";
                            string hinhAnh = reader["HinhAnh"].ToString() ?? "";
                            string hoVaTen = reader["HoVaTen"].ToString() ?? "N/A";
                            string quyenHan = reader["QuyenHan"].ToString() ?? "N/A";

                            dsMonAn.Add((tenMon, hoVaTen, quyenHan, hinhAnh));
                        }
                    }

                    conn.Close();
                }

                DisplayListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
        }

        // HIỂN THỊ LISTVIEW
        private void DisplayListView()
        {
            try
            {
                var lvControls = Controls.Find("ListView_MonAn", true);
                if (lvControls.Length > 0 && lvControls[0] is ListView lv)
                {
                    lv.Items.Clear();
                    foreach (var (tenMon, nguoiDung, quyenHan, _) in dsMonAn)
                    {
                        ListViewItem item = new ListViewItem(tenMon);
                        item.SubItems.Add(nguoiDung);
                        item.SubItems.Add(quyenHan);
                        lv.Items.Add(item);
                    }
                }
            }
            catch { }
        }

        // NÚT DELETE ALL
        private void Button_DeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa toàn bộ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string cs = string.Format(connString, dbPath);

                    using (var conn = new SQLiteConnection(cs))
                    {
                        conn.Open();

                        using (var cmd = new SQLiteCommand("DELETE FROM MonAn;", conn))
                            cmd.ExecuteNonQuery();

                        using (var cmd = new SQLiteCommand("DELETE FROM NguoiDung;", conn))
                            cmd.ExecuteNonQuery();

                        conn.Close();
                    }

                    dsMonAn.Clear();
                    DisplayListView();
                    ClearTreeView();
                    MessageBox.Show("Đã xóa toàn bộ!", "Thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
                }
            }
        }

        // NÚT FIND RANDOM
        private void Button_FindRandom_Click(object sender, EventArgs e)
        {
            if (dsMonAn.Count == 0)
            {
                MessageBox.Show("Danh sách trống! Hãy click 'Read File' trước.", "Thông báo");
                return;
            }

            try
            {
                Random rand = new Random();
                int index = rand.Next(dsMonAn.Count);
                var (tenMon, nguoiDung, quyenHan, hinhAnh) = dsMonAn[index];

                DisplayTreeViewResult(tenMon, nguoiDung, quyenHan, hinhAnh);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
        }
        
        // HIỂN THỊ TREEVIEW KẾT QUẢ
        private void DisplayTreeViewResult(string tenMon, string nguoiDung, string quyenHan, string hinhAnh)
        {
            try
            {
                var tvControls = Controls.Find("TreeView_KetQua", true);
                if (tvControls.Length > 0 && tvControls[0] is TreeView tv)
                {
                    tv.Nodes.Clear();

                    var nodeMonAn = tv.Nodes.Add("Tên Món Ăn");
                    nodeMonAn.Nodes.Add(tenMon);

                    var nodeNguoiDung = tv.Nodes.Add("Tên Người Dùng");
                    nodeNguoiDung.Nodes.Add(nguoiDung);

                    var nodeQuyenHan = tv.Nodes.Add("Quyền Hạn");
                    nodeQuyenHan.Nodes.Add(quyenHan);

                    var nodeHinhAnh = tv.Nodes.Add("Hình Ảnh");
                    nodeHinhAnh.Nodes.Add(hinhAnh);

                    tv.ExpandAll();
                }

                // Hiển thị hình ảnh trong PictureBox
                DisplayImage(hinhAnh);
            }
            catch { }
        }

        // HIỂN THỊ HÌNH ẢNH TRONG PICTUREBOX
        private void DisplayImage(string fileName)
        {
            try
            {
                var pbControls = Controls.Find("PictureBox_Result", true);
                if (pbControls.Length > 0 && pbControls[0] is PictureBox pb)
                {
                    pb.Image = null;

                    if (string.IsNullOrEmpty(fileName))
                        return;

                    string imagePath = Path.Combine(imageFolder, fileName);
                    if (File.Exists(imagePath))
                    {
                        pb.Image = new Bitmap(imagePath);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show($"Không tìm thấy hình ảnh: {imagePath}", "Lỗi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải hình ảnh: {ex.Message}", "Lỗi");
            }
        }

        // XÓA TREEVIEW
        private void ClearTreeView()
        {
            try
            {
                var tvControls = Controls.Find("TreeView_KetQua", true);
                if (tvControls.Length > 0 && tvControls[0] is TreeView tv)
                    tv.Nodes.Clear();
            }
            catch { }
        }

        // NÚT EXIT
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Home home = new Home(this.Location, this.Size);
            home.Show();
            this.Hide();
        }
    }
}