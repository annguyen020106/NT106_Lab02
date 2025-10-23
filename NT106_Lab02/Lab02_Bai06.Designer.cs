using System.Windows.Forms;
using System.Drawing;

namespace NT106_Lab02
{
    partial class Lab02_Bai06
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Button_Exit = new Button();
            Button_Delete = new Button();
            Button_Find = new Button();
            Button_Push = new Button();
            Button_ReadFile = new Button();
            Button_WriteFile = new Button();
            label1 = new Label();
            TextBox_DanhSach = new TextBox();
            TextBox_MonMoi = new TextBox();
            label3 = new Label();
            TextBox_KQ = new TextBox();
            SuspendLayout();
            // 
            // Button_Exit
            // 
            Button_Exit.BackColor = Color.CornflowerBlue;
            Button_Exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_Exit.ForeColor = SystemColors.ControlText;
            Button_Exit.Location = new Point(12, 405);
            Button_Exit.Name = "Button_Exit";
            Button_Exit.Size = new Size(130, 33);
            Button_Exit.TabIndex = 11;
            Button_Exit.Text = "Exit";
            Button_Exit.UseVisualStyleBackColor = false;
            Button_Exit.Click += Button_Exit_Click;
            // 
            // Button_Delete
            // 
            Button_Delete.BackColor = Color.CornflowerBlue;
            Button_Delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_Delete.ForeColor = SystemColors.ControlText;
            Button_Delete.Location = new Point(501, 261);
            Button_Delete.Name = "Button_Delete";
            Button_Delete.Size = new Size(120, 33);
            Button_Delete.TabIndex = 6;
            Button_Delete.Text = "Delete";
            Button_Delete.UseVisualStyleBackColor = false;
            Button_Delete.Click += Button_Delete_Click;
            // 
            // Button_Find
            // 
            Button_Find.BackColor = Color.CornflowerBlue;
            Button_Find.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_Find.ForeColor = SystemColors.ControlText;
            Button_Find.Location = new Point(336, 261);
            Button_Find.Name = "Button_Find";
            Button_Find.Size = new Size(120, 33);
            Button_Find.TabIndex = 7;
            Button_Find.Text = "Find";
            Button_Find.UseVisualStyleBackColor = false;
            Button_Find.Click += Button_Find_Click;
            // 
            // Button_Push
            // 
            Button_Push.BackColor = Color.CornflowerBlue;
            Button_Push.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_Push.ForeColor = SystemColors.ControlText;
            Button_Push.Location = new Point(236, 57);
            Button_Push.Name = "Button_Push";
            Button_Push.Size = new Size(94, 33);
            Button_Push.TabIndex = 5;
            Button_Push.Text = "Push";
            Button_Push.UseVisualStyleBackColor = false;
            Button_Push.Click += Button_Push_Click;
            // 
            // Button_ReadFile
            // 
            Button_ReadFile.BackColor = Color.CornflowerBlue;
            Button_ReadFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_ReadFile.ForeColor = SystemColors.ControlText;
            Button_ReadFile.Location = new Point(336, 358);
            Button_ReadFile.Name = "Button_ReadFile";
            Button_ReadFile.Size = new Size(120, 33);
            Button_ReadFile.TabIndex = 2;
            Button_ReadFile.Text = "Read File";
            Button_ReadFile.UseVisualStyleBackColor = false;
            Button_ReadFile.Click += Button_Read_Click;
            // 
            // Button_WriteFile
            // 
            Button_WriteFile.BackColor = Color.CornflowerBlue;
            Button_WriteFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_WriteFile.ForeColor = SystemColors.ControlText;
            Button_WriteFile.Location = new Point(501, 358);
            Button_WriteFile.Name = "Button_WriteFile";
            Button_WriteFile.Size = new Size(120, 33);
            Button_WriteFile.TabIndex = 1;
            Button_WriteFile.Text = "Write File";
            Button_WriteFile.UseVisualStyleBackColor = false;
            Button_WriteFile.Click += Button_Write_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 8;
            label1.Text = "Nhập món ăn";
            // 
            // TextBox_DanhSach
            // 
            TextBox_DanhSach.Location = new Point(336, 24);
            TextBox_DanhSach.Multiline = true;
            TextBox_DanhSach.Name = "TextBox_DanhSach";
            TextBox_DanhSach.ScrollBars = ScrollBars.Vertical;
            TextBox_DanhSach.Size = new Size(285, 231);
            TextBox_DanhSach.TabIndex = 9;
            // 
            // TextBox_MonMoi
            // 
            TextBox_MonMoi.Location = new Point(142, 24);
            TextBox_MonMoi.Name = "TextBox_MonMoi";
            TextBox_MonMoi.Size = new Size(188, 27);
            TextBox_MonMoi.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(167, 329);
            label3.Name = "label3";
            label3.Size = new Size(163, 23);
            label3.TabIndex = 3;
            label3.Text = "Món ăn hôm nay là";
            // 
            // TextBox_KQ
            // 
            TextBox_KQ.Location = new Point(336, 325);
            TextBox_KQ.Name = "TextBox_KQ";
            TextBox_KQ.Size = new Size(285, 27);
            TextBox_KQ.TabIndex = 4;
            // 
            // Lab02_Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Button_WriteFile);
            Controls.Add(Button_ReadFile);
            Controls.Add(label3);
            Controls.Add(TextBox_KQ);
            Controls.Add(Button_Push);
            Controls.Add(Button_Delete);
            Controls.Add(Button_Find);
            Controls.Add(label1);
            Controls.Add(TextBox_DanhSach);
            Controls.Add(TextBox_MonMoi);
            Controls.Add(Button_Exit);
            Name = "Lab02_Bai06";
            Text = "Bài 06 - Ghi / Đọc File Món Ăn";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button Button_Exit;
        private Button Button_Delete;
        private Button Button_Find;
        private Button Button_Push;
        private Button Button_ReadFile;
        private Button Button_WriteFile;
        private Label label1;
        private TextBox TextBox_DanhSach;
        private TextBox TextBox_MonMoi;
        private Label label3;
        private TextBox TextBox_KQ;
    }
}
