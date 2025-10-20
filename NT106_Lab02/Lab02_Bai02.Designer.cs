namespace NT106_Lab02
{
    partial class Lab02_Bai02
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
            Button_Read = new Button();
            Button_Exit = new Button();
            Label_FileName = new Label();
            Label_Size = new Label();
            Label_URL = new Label();
            Label_LineCount = new Label();
            Label_WordsCount = new Label();
            Label_CharacterCount = new Label();
            TextBox_CharacterCount = new TextBox();
            TextBox_FileName = new TextBox();
            TextBox_Size = new TextBox();
            TextBox_URL = new TextBox();
            TextBox_LineCount = new TextBox();
            TextBox_WordsCount = new TextBox();
            TextBox_Content = new TextBox();
            Label_Content = new Label();
            SuspendLayout();
            // 
            // Button_Read
            // 
            Button_Read.BackColor = Color.CornflowerBlue;
            Button_Read.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_Read.Location = new Point(12, 12);
            Button_Read.Name = "Button_Read";
            Button_Read.Size = new Size(313, 33);
            Button_Read.TabIndex = 1;
            Button_Read.Text = "Read from File";
            Button_Read.UseVisualStyleBackColor = false;
            Button_Read.Click += Button_Read_Click;
            // 
            // Button_Exit
            // 
            Button_Exit.BackColor = Color.CornflowerBlue;
            Button_Exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_Exit.Location = new Point(12, 405);
            Button_Exit.Name = "Button_Exit";
            Button_Exit.Size = new Size(313, 33);
            Button_Exit.TabIndex = 2;
            Button_Exit.Text = "Exit";
            Button_Exit.UseVisualStyleBackColor = false;
            Button_Exit.Click += Button_Exit_Click;
            // 
            // Label_FileName
            // 
            Label_FileName.AutoSize = true;
            Label_FileName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Label_FileName.ForeColor = Color.CornflowerBlue;
            Label_FileName.Location = new Point(12, 90);
            Label_FileName.Name = "Label_FileName";
            Label_FileName.Size = new Size(76, 20);
            Label_FileName.TabIndex = 3;
            Label_FileName.Text = "File name";
            // 
            // Label_Size
            // 
            Label_Size.AutoSize = true;
            Label_Size.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Label_Size.ForeColor = Color.CornflowerBlue;
            Label_Size.Location = new Point(12, 143);
            Label_Size.Name = "Label_Size";
            Label_Size.Size = new Size(36, 20);
            Label_Size.TabIndex = 4;
            Label_Size.Text = "Size";
            // 
            // Label_URL
            // 
            Label_URL.AutoSize = true;
            Label_URL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Label_URL.ForeColor = Color.CornflowerBlue;
            Label_URL.Location = new Point(13, 196);
            Label_URL.Name = "Label_URL";
            Label_URL.Size = new Size(38, 20);
            Label_URL.TabIndex = 5;
            Label_URL.Text = "URL";
            // 
            // Label_LineCount
            // 
            Label_LineCount.AutoSize = true;
            Label_LineCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Label_LineCount.ForeColor = Color.CornflowerBlue;
            Label_LineCount.Location = new Point(12, 249);
            Label_LineCount.Name = "Label_LineCount";
            Label_LineCount.Size = new Size(82, 20);
            Label_LineCount.TabIndex = 6;
            Label_LineCount.Text = "Line count";
            // 
            // Label_WordsCount
            // 
            Label_WordsCount.AutoSize = true;
            Label_WordsCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Label_WordsCount.ForeColor = Color.CornflowerBlue;
            Label_WordsCount.Location = new Point(12, 302);
            Label_WordsCount.Name = "Label_WordsCount";
            Label_WordsCount.Size = new Size(99, 20);
            Label_WordsCount.TabIndex = 7;
            Label_WordsCount.Text = "Words count";
            // 
            // Label_CharacterCount
            // 
            Label_CharacterCount.AutoSize = true;
            Label_CharacterCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Label_CharacterCount.ForeColor = Color.CornflowerBlue;
            Label_CharacterCount.Location = new Point(12, 355);
            Label_CharacterCount.Name = "Label_CharacterCount";
            Label_CharacterCount.Size = new Size(120, 20);
            Label_CharacterCount.TabIndex = 8;
            Label_CharacterCount.Text = "Character count";
            // 
            // TextBox_CharacterCount
            // 
            TextBox_CharacterCount.Location = new Point(138, 348);
            TextBox_CharacterCount.Name = "TextBox_CharacterCount";
            TextBox_CharacterCount.Size = new Size(187, 27);
            TextBox_CharacterCount.TabIndex = 9;
            // 
            // TextBox_FileName
            // 
            TextBox_FileName.Location = new Point(138, 83);
            TextBox_FileName.Name = "TextBox_FileName";
            TextBox_FileName.Size = new Size(187, 27);
            TextBox_FileName.TabIndex = 10;
            // 
            // TextBox_Size
            // 
            TextBox_Size.Location = new Point(138, 136);
            TextBox_Size.Name = "TextBox_Size";
            TextBox_Size.Size = new Size(187, 27);
            TextBox_Size.TabIndex = 11;
            // 
            // TextBox_URL
            // 
            TextBox_URL.Location = new Point(138, 189);
            TextBox_URL.Name = "TextBox_URL";
            TextBox_URL.Size = new Size(187, 27);
            TextBox_URL.TabIndex = 12;
            // 
            // TextBox_LineCount
            // 
            TextBox_LineCount.Location = new Point(138, 242);
            TextBox_LineCount.Name = "TextBox_LineCount";
            TextBox_LineCount.Size = new Size(187, 27);
            TextBox_LineCount.TabIndex = 13;
            // 
            // TextBox_WordsCount
            // 
            TextBox_WordsCount.Location = new Point(138, 295);
            TextBox_WordsCount.Name = "TextBox_WordsCount";
            TextBox_WordsCount.Size = new Size(187, 27);
            TextBox_WordsCount.TabIndex = 14;
            // 
            // TextBox_Content
            // 
            TextBox_Content.Location = new Point(345, 83);
            TextBox_Content.Multiline = true;
            TextBox_Content.Name = "TextBox_Content";
            TextBox_Content.ScrollBars = ScrollBars.Both;
            TextBox_Content.Size = new Size(432, 355);
            TextBox_Content.TabIndex = 15;
            TextBox_Content.WordWrap = false;
            // 
            // Label_Content
            // 
            Label_Content.AutoSize = true;
            Label_Content.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Label_Content.ForeColor = Color.CornflowerBlue;
            Label_Content.Location = new Point(345, 50);
            Label_Content.Name = "Label_Content";
            Label_Content.Size = new Size(96, 30);
            Label_Content.TabIndex = 16;
            Label_Content.Text = "Content";
            // 
            // Lab02_Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Label_Content);
            Controls.Add(TextBox_Content);
            Controls.Add(TextBox_WordsCount);
            Controls.Add(TextBox_LineCount);
            Controls.Add(TextBox_URL);
            Controls.Add(TextBox_Size);
            Controls.Add(TextBox_FileName);
            Controls.Add(TextBox_CharacterCount);
            Controls.Add(Label_CharacterCount);
            Controls.Add(Label_WordsCount);
            Controls.Add(Label_LineCount);
            Controls.Add(Label_URL);
            Controls.Add(Label_Size);
            Controls.Add(Label_FileName);
            Controls.Add(Button_Exit);
            Controls.Add(Button_Read);
            Name = "Lab02_Bai02";
            Text = "Bài 02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Read;
        private Button Button_Exit;
        private Label Label_FileName;
        private Label Label_Size;
        private Label Label_URL;
        private Label Label_LineCount;
        private Label Label_WordsCount;
        private Label Label_CharacterCount;
        private TextBox TextBox_CharacterCount;
        private TextBox TextBox_FileName;
        private TextBox TextBox_Size;
        private TextBox TextBox_URL;
        private TextBox TextBox_LineCount;
        private TextBox TextBox_WordsCount;
        private TextBox TextBox_Content;
        private Label Label_Content;
    }
}