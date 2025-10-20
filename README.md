# Lab 02 – File and Stream I/O in C#

> **Môn học:** Lập Trình Mạng Căn Bản  
> **Lớp:** NT106.Q14.2  
> **Sinh viên thực hiện:** Nguyễn Chiêu Ân **- MSSV:** 24520054  
> **Giảng viên hướng dẫn:** Lê Minh Khánh Hội  

---

## Tổng quan các bài tập

### Trang chủ – Chứa toàn bộ 7 bài tập
- Giao diện cho phép chọn bài tập → chuyển sang màn hình bài tương ứng.  
- Tất cả bài đều thuộc cùng một **Project WinForms duy nhất**.

---

### Bài 01 – Ghi và Đọc file
- Đọc nội dung file `input1.txt` → hiển thị lên `RichTextBox`.  
- Chuyển toàn bộ ký tự thành **in hoa** → ghi xuống file `output1.txt`.  
- **Gợi ý:**  
  - Dùng `ReadToEnd()` để đọc toàn bộ nội dung.  
  - Dùng `StreamWriter` để ghi file.  

---

### Bài 02 – Đọc thông tin một file .txt
- Hiển thị các thông tin:  
  - Tên file, kích thước, đường dẫn, số dòng, số từ, số ký tự.  
  - Nội dung file.  
- **Gợi ý:**  
  - Dùng `StreamReader` để đọc file.  
  - Lấy tên file: `ofd.SafeFileName`.  
  - Lấy đường dẫn: `fs.Name`.

---

### Bài 03 – Đọc và Ghi file và tính toán
- Đọc file `input3.txt` gồm các phép toán (cộng, trừ, nhân, chia, ngoặc). VD: 1 + 2 + 3 + 4  
- Tính kết quả từng dòng → ghi ra `output3.txt` theo dạng:  "1 + 2 + 3 + 4 = 10"
- **Lưu ý:** Không dùng `DataTable.Compute`.  
- **Yêu cầu:** Tự xây dựng parser để xử lý biểu thức.

---

### Bài 04 – Đọc và Ghi file Sinh viên (JsonSerializer)
- Nhập danh sách sinh viên gồm:  
`Họ tên, MSSV, Điện thoại, Điểm 3 môn, Điểm trung bình`.  
- Ghi danh sách vào `input4.txt` → đọc lại, tính điểm trung bình → ghi `output4.txt`.  
- **Ràng buộc:**  
- MSSV: 8 chữ số.  
- SĐT: 10 chữ số, bắt đầu bằng 0.  
- Điểm: 0–10.  
- **Gợi ý:**  
- Dùng `JsonSerializer` thay cho `BinaryFormatter`.  
- Có thể thêm tính năng phân trang danh sách.

---

### Bài 05 – Quản lý phòng vé (phiên bản 2)
- Đọc file `input5.txt` theo cấu trúc.  
- Quản lý thông tin phòng vé, thống kê doanh thu → ghi `output5.txt` gồm:  
- Tên phim, số vé bán, vé tồn, tỉ lệ bán, doanh thu, xếp hạng doanh thu.  
- **Gợi ý:**  
- Thêm `ProgressBar` khi xuất file để hiển thị tiến độ.

---

### Bài 06 – Hôm nay ăn gì? (phiên bản 2)
- Lưu trữ dữ liệu món ăn và người dùng bằng **SQLite**.  
- Thực hiện truy vấn hiển thị danh sách món ăn.  
- Chọn ngẫu nhiên 1 món để hiển thị kèm hình ảnh và người đóng góp.  
- **Gợi ý:**  
- Bảng `MonAn(IDMA, TenMonAn, HinhAnh, IDNCC)`  
- Bảng `NguoiDung(IDNCC, HoVaTen, QuyenHan)`  
- Dùng `ListView` hoặc `TreeView` để hiển thị.

---

### Bài 07 – Duyệt thư mục
- Ứng dụng duyệt tất cả file và folder trong máy tính.  
- Nhấp đúp để mở thư mục, bấm chọn để xem nội dung file.  
- **Gợi ý:**  
- Dùng `TreeView` hoặc `ListView`.  
- Dùng các lớp `DirectoryInfo`, `FileInfo`.

---

## Ngôn ngữ & Công cụ
- **Ngôn ngữ:** C#  
- **Công cụ:** Visual Studio (.NET Framework / .NET 6 WinForms)  

---

## Mục tiêu
- Hiểu và sử dụng các lớp `FileStream`, `StreamReader`, `StreamWriter`, `JsonSerializer`.  
- Nắm vững thao tác **đọc – ghi file**, **xử lý dữ liệu**, và **tổ chức lưu trữ thông tin**.  
- Kết hợp giao diện WinForms để thể hiện kết quả trực quan, sinh động.
