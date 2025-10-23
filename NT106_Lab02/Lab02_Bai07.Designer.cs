using System.Windows.Forms;
using System.Drawing;

namespace NT106_Lab02
{
    partial class Lab02_Bai07
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Button_Exit = new Button();
            TreeView = new TreeView();
            GroupBox = new GroupBox();
            PictureBox = new PictureBox();
            GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // Button_Exit
            // 
            Button_Exit.BackColor = Color.CornflowerBlue;
            Button_Exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_Exit.Location = new Point(12, 500);
            Button_Exit.Name = "Button_Exit";
            Button_Exit.Size = new Size(120, 35);
            Button_Exit.TabIndex = 0;
            Button_Exit.Text = "Exit";
            Button_Exit.UseVisualStyleBackColor = false;
            Button_Exit.Click += Button_Exit_Click;
            // 
            // TreeView
            // 
            TreeView.BackColor = Color.LavenderBlush;
            TreeView.Location = new Point(12, 12);
            TreeView.Name = "TreeView";
            TreeView.Size = new Size(280, 470);
            TreeView.TabIndex = 1;
            // 
            // GroupBox
            // 
            GroupBox.BackColor = Color.AliceBlue;
            GroupBox.Controls.Add(PictureBox);
            GroupBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            GroupBox.ForeColor = Color.CornflowerBlue;
            GroupBox.Location = new Point(310, 12);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(530, 470);
            GroupBox.TabIndex = 2;
            GroupBox.TabStop = false;
            GroupBox.Text = "File Content";
            // 
            // PictureBox
            // 
            PictureBox.BackColor = Color.White;
            PictureBox.Dock = DockStyle.Fill;
            PictureBox.Location = new Point(3, 26);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(524, 441);
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // Lab02_Bai07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 550);
            Controls.Add(GroupBox);
            Controls.Add(TreeView);
            Controls.Add(Button_Exit);
            Name = "Lab02_Bai07";
            Text = "Bài 07 - Trình Duyệt File";
            Load += Lab02_Bai07_Load;
            GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Button_Exit;
        private TreeView TreeView;
        private GroupBox GroupBox;
        private PictureBox PictureBox;
    }
}
