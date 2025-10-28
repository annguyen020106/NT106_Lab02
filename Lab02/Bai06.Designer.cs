using System.Windows.Forms;
using System.Drawing;

namespace Lab02
{
    partial class Bai06
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
            Button_FindRandom = new Button();
            Button_ReadFile = new Button();
            label3 = new Label();
            Button_DeleteAll = new Button();
            TreeView_KetQua = new TreeView();
            ListView_MonAn = new ListView();
            PictureBox_Result = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Result).BeginInit();
            SuspendLayout();
            // 
            // Button_Exit
            // 
            Button_Exit.BackColor = Color.CornflowerBlue;
            Button_Exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_Exit.ForeColor = SystemColors.ControlText;
            Button_Exit.Location = new Point(22, 596);
            Button_Exit.Name = "Button_Exit";
            Button_Exit.Size = new Size(130, 33);
            Button_Exit.TabIndex = 11;
            Button_Exit.Text = "Exit";
            Button_Exit.UseVisualStyleBackColor = false;
            Button_Exit.Click += Button_Exit_Click;
            // 
            // Button_FindRandom
            // 
            Button_FindRandom.BackColor = Color.CornflowerBlue;
            Button_FindRandom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_FindRandom.ForeColor = SystemColors.ControlText;
            Button_FindRandom.Location = new Point(650, 289);
            Button_FindRandom.Name = "Button_FindRandom";
            Button_FindRandom.Size = new Size(120, 33);
            Button_FindRandom.TabIndex = 7;
            Button_FindRandom.Text = "Find Random";
            Button_FindRandom.UseVisualStyleBackColor = false;
            Button_FindRandom.Click += Button_FindRandom_Click;
            // 
            // Button_ReadFile
            // 
            Button_ReadFile.BackColor = Color.CornflowerBlue;
            Button_ReadFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_ReadFile.ForeColor = SystemColors.ControlText;
            Button_ReadFile.Location = new Point(55, 23);
            Button_ReadFile.Name = "Button_ReadFile";
            Button_ReadFile.Size = new Size(120, 33);
            Button_ReadFile.TabIndex = 2;
            Button_ReadFile.Text = "Read File";
            Button_ReadFile.UseVisualStyleBackColor = false;
            Button_ReadFile.Click += Button_ReadFile_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(1013, 33);
            label3.Name = "label3";
            label3.Size = new Size(163, 23);
            label3.TabIndex = 3;
            label3.Text = "Món ăn hôm nay là";
            // 
            // Button_DeleteAll
            // 
            Button_DeleteAll.BackColor = Color.CornflowerBlue;
            Button_DeleteAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_DeleteAll.ForeColor = SystemColors.ControlText;
            Button_DeleteAll.Location = new Point(475, 23);
            Button_DeleteAll.Name = "Button_DeleteAll";
            Button_DeleteAll.Size = new Size(120, 33);
            Button_DeleteAll.TabIndex = 6;
            Button_DeleteAll.Text = "Delete ALL";
            Button_DeleteAll.UseVisualStyleBackColor = false;
            // 
            // TreeView_KetQua
            // 
            TreeView_KetQua.Location = new Point(807, 80);
            TreeView_KetQua.Name = "TreeView_KetQua";
            TreeView_KetQua.Size = new Size(549, 192);
            TreeView_KetQua.TabIndex = 12;
            // 
            // ListView_MonAn
            // 
            ListView_MonAn.Location = new Point(55, 100);
            ListView_MonAn.Name = "ListView_MonAn";
            ListView_MonAn.Size = new Size(540, 459);
            ListView_MonAn.TabIndex = 13;
            ListView_MonAn.UseCompatibleStateImageBehavior = false;
            // 
            // PictureBox_Result
            // 
            PictureBox_Result.Location = new Point(807, 266);
            PictureBox_Result.Name = "PictureBox_Result";
            PictureBox_Result.Size = new Size(549, 293);
            PictureBox_Result.TabIndex = 14;
            PictureBox_Result.TabStop = false;
            // 
            // Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1368, 657);
            Controls.Add(PictureBox_Result);
            Controls.Add(ListView_MonAn);
            Controls.Add(TreeView_KetQua);
            Controls.Add(Button_ReadFile);
            Controls.Add(label3);
            Controls.Add(Button_DeleteAll);
            Controls.Add(Button_FindRandom);
            Controls.Add(Button_Exit);
            Name = "Bai06";
            Text = "Bài 06";
            Load += Lab02_Bai06_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox_Result).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button Button_Exit;
        private Button Button_FindRandom;
        private Button Button_ReadFile;
        private TextBox TextBox_DanhSach;
        private Label label3;
        private Button Button_DeleteAll;
        private TreeView TreeView_KetQua;
        private ListView ListView_MonAn;
        private PictureBox PictureBox_Result;
    }
}
