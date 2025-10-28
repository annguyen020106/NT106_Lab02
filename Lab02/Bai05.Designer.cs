using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Lab02
{
    partial class Bai05
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai05));
            pictureBox3 = new PictureBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            Label_Seat = new Label();
            label4 = new Label();
            TextBox_KQ = new TextBox();
            Label_Room = new Label();
            Label_Movie = new Label();
            Label_Name = new Label();
            Button_Buy = new Button();
            CheckedListBox_Seat = new CheckedListBox();
            ComboBox_Room = new ComboBox();
            ComboBox_Movie = new ComboBox();
            TextBox_Name = new TextBox();
            Button_Exit = new Button();
            Button_ExportFile = new Button();
            Button_Delete = new Button();
            ProgressBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(1101, 75);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(182, 271);
            pictureBox3.TabIndex = 66;
            pictureBox3.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.CornflowerBlue;
            label10.Location = new Point(1307, 42);
            label10.Name = "label10";
            label10.Size = new Size(133, 20);
            label10.TabIndex = 73;
            label10.Text = "GẶP LẠI CHỊ BẦU";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.CornflowerBlue;
            label9.Location = new Point(1101, 42);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 72;
            label9.Text = "TAROT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.CornflowerBlue;
            label8.Location = new Point(888, 42);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 71;
            label8.Text = "MAI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.CornflowerBlue;
            label7.Location = new Point(679, 42);
            label7.Name = "label7";
            label7.Size = new Size(162, 20);
            label7.TabIndex = 70;
            label7.Text = "ĐÀO , PHỞ VÀ PIANO";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(1307, 75);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(185, 271);
            pictureBox4.TabIndex = 67;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(888, 75);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 271);
            pictureBox2.TabIndex = 65;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(679, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 271);
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientInactiveCaption;
            label6.Location = new Point(198, 204);
            label6.Name = "label6";
            label6.Size = new Size(163, 140);
            label6.TabIndex = 63;
            label6.Text = "         MÀN HÌNH\r\n\r\nA1    A2    A3    A4    A5\r\nB1    B2    B3    B4    B5\r\nC1    C2    C3    C4    C5\r\n\r\n          MÁY CHIẾU";
            // 
            // Label_Seat
            // 
            Label_Seat.AutoSize = true;
            Label_Seat.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            Label_Seat.ForeColor = Color.CornflowerBlue;
            Label_Seat.Location = new Point(12, 204);
            Label_Seat.Name = "Label_Seat";
            Label_Seat.Size = new Size(39, 20);
            Label_Seat.TabIndex = 62;
            Label_Seat.Text = "Seat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(404, 35);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 61;
            label4.Text = "Thông tin";
            // 
            // TextBox_KQ
            // 
            TextBox_KQ.BackColor = SystemColors.GradientInactiveCaption;
            TextBox_KQ.Location = new Point(401, 61);
            TextBox_KQ.Multiline = true;
            TextBox_KQ.Name = "TextBox_KQ";
            TextBox_KQ.ReadOnly = true;
            TextBox_KQ.ScrollBars = ScrollBars.Vertical;
            TextBox_KQ.Size = new Size(239, 283);
            TextBox_KQ.TabIndex = 60;
            // 
            // Label_Room
            // 
            Label_Room.AutoSize = true;
            Label_Room.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            Label_Room.ForeColor = Color.CornflowerBlue;
            Label_Room.Location = new Point(12, 144);
            Label_Room.Name = "Label_Room";
            Label_Room.Size = new Size(57, 23);
            Label_Room.TabIndex = 59;
            Label_Room.Text = "Room";
            // 
            // Label_Movie
            // 
            Label_Movie.AutoSize = true;
            Label_Movie.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            Label_Movie.ForeColor = Color.CornflowerBlue;
            Label_Movie.Location = new Point(12, 91);
            Label_Movie.Name = "Label_Movie";
            Label_Movie.Size = new Size(59, 23);
            Label_Movie.TabIndex = 58;
            Label_Movie.Text = "Movie";
            // 
            // Label_Name
            // 
            Label_Name.AutoSize = true;
            Label_Name.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Bold);
            Label_Name.ForeColor = Color.CornflowerBlue;
            Label_Name.Location = new Point(12, 38);
            Label_Name.Name = "Label_Name";
            Label_Name.Size = new Size(57, 23);
            Label_Name.TabIndex = 57;
            Label_Name.Text = "Name";
            // 
            // Button_Buy
            // 
            Button_Buy.BackColor = Color.CornflowerBlue;
            Button_Buy.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            Button_Buy.ForeColor = SystemColors.ControlText;
            Button_Buy.Location = new Point(198, 360);
            Button_Buy.Name = "Button_Buy";
            Button_Buy.Size = new Size(163, 29);
            Button_Buy.TabIndex = 56;
            Button_Buy.Text = "Buy";
            Button_Buy.UseVisualStyleBackColor = false;
            Button_Buy.Click += Button_Buy_Click;
            // 
            // CheckedListBox_Seat
            // 
            CheckedListBox_Seat.CheckOnClick = true;
            CheckedListBox_Seat.FormattingEnabled = true;
            CheckedListBox_Seat.Items.AddRange(new object[] { "A1 (VỚT)", "A2 (THƯỜNG)", "A3 (THƯỜNG)", "A4 (THƯỜNG)", "A5 (VỚT)", "B1", "B2 (VIP)", "B3 (VIP)", "B4 (VIP)", "B5", "C1 (VỚT)", "C2 (THƯỜNG)", "C3 (THƯỜNG)", "C4 (THƯỜNG)", "C5 (VỚT)" });
            CheckedListBox_Seat.Location = new Point(12, 230);
            CheckedListBox_Seat.Name = "CheckedListBox_Seat";
            CheckedListBox_Seat.Size = new Size(146, 114);
            CheckedListBox_Seat.TabIndex = 55;
            // 
            // ComboBox_Room
            // 
            ComboBox_Room.FormattingEnabled = true;
            ComboBox_Room.Location = new Point(163, 139);
            ComboBox_Room.Name = "ComboBox_Room";
            ComboBox_Room.Size = new Size(198, 28);
            ComboBox_Room.TabIndex = 54;
            // 
            // ComboBox_Movie
            // 
            ComboBox_Movie.FormattingEnabled = true;
            ComboBox_Movie.Location = new Point(163, 86);
            ComboBox_Movie.Name = "ComboBox_Movie";
            ComboBox_Movie.Size = new Size(198, 28);
            ComboBox_Movie.TabIndex = 53;
            // 
            // TextBox_Name
            // 
            TextBox_Name.Location = new Point(163, 34);
            TextBox_Name.Name = "TextBox_Name";
            TextBox_Name.Size = new Size(198, 27);
            TextBox_Name.TabIndex = 52;
            // 
            // Button_Exit
            // 
            Button_Exit.BackColor = Color.CornflowerBlue;
            Button_Exit.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            Button_Exit.ForeColor = SystemColors.ControlText;
            Button_Exit.Location = new Point(12, 405);
            Button_Exit.Name = "Button_Exit";
            Button_Exit.Size = new Size(130, 33);
            Button_Exit.TabIndex = 50;
            Button_Exit.Text = "Exit";
            Button_Exit.UseVisualStyleBackColor = false;
            Button_Exit.Click += Button_Exit_Click;
            // 
            // Button_ExportFile
            // 
            Button_ExportFile.BackColor = Color.CornflowerBlue;
            Button_ExportFile.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            Button_ExportFile.ForeColor = SystemColors.ControlText;
            Button_ExportFile.Location = new Point(502, 360);
            Button_ExportFile.Name = "Button_ExportFile";
            Button_ExportFile.Size = new Size(138, 29);
            Button_ExportFile.TabIndex = 74;
            Button_ExportFile.Text = "Export File";
            Button_ExportFile.UseVisualStyleBackColor = false;
            Button_ExportFile.Click += Button_ExportFile_Click;
            // 
            // Button_Delete
            // 
            Button_Delete.BackColor = Color.CornflowerBlue;
            Button_Delete.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            Button_Delete.ForeColor = SystemColors.ControlText;
            Button_Delete.Location = new Point(401, 360);
            Button_Delete.Name = "Button_Delete";
            Button_Delete.Size = new Size(91, 29);
            Button_Delete.TabIndex = 75;
            Button_Delete.Text = "Delete";
            Button_Delete.UseVisualStyleBackColor = false;
            Button_Delete.Click += Button_Delete_Click;
            // 
            // ProgressBar
            // 
            ProgressBar.BackColor = SystemColors.ControlText;
            ProgressBar.Location = new Point(679, 360);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(813, 29);
            ProgressBar.Style = ProgressBarStyle.Continuous;
            ProgressBar.TabIndex = 76;
            // 
            // Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1531, 450);
            Controls.Add(ProgressBar);
            Controls.Add(Button_Delete);
            Controls.Add(Button_ExportFile);
            Controls.Add(pictureBox3);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(Label_Seat);
            Controls.Add(label4);
            Controls.Add(TextBox_KQ);
            Controls.Add(Label_Room);
            Controls.Add(Label_Movie);
            Controls.Add(Label_Name);
            Controls.Add(Button_Buy);
            Controls.Add(CheckedListBox_Seat);
            Controls.Add(ComboBox_Room);
            Controls.Add(ComboBox_Movie);
            Controls.Add(TextBox_Name);
            Controls.Add(Button_Exit);
            Name = "Bai05";
            Text = "Bài 05";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label6;
        private Label Label_Seat;
        private Label label4;
        private TextBox TextBox_KQ;
        private Label Label_Room;
        private Label Label_Movie;
        private Label Label_Name;
        private Button Button_Buy;
        private CheckedListBox CheckedListBox_Seat;
        private ComboBox ComboBox_Room;
        private ComboBox ComboBox_Movie;
        private TextBox TextBox_Name;
        private Button Button_Exit;
        private Button Button_ExportFile;
        private Button Button_Delete;
        private ProgressBar ProgressBar;
    }
}