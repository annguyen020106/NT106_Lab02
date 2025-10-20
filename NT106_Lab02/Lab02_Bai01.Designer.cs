namespace NT106_Lab02
{
    partial class Lab02_Bai01
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
            Button_Write = new Button();
            TextBox_Content = new TextBox();
            Label_Content = new Label();
            Button_Exit = new Button();
            SuspendLayout();
            // 
            // Button_Read
            // 
            Button_Read.BackColor = Color.CornflowerBlue;
            Button_Read.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Read.Location = new Point(40, 62);
            Button_Read.Name = "Button_Read";
            Button_Read.Size = new Size(176, 49);
            Button_Read.TabIndex = 0;
            Button_Read.Text = "READ FILE";
            Button_Read.UseVisualStyleBackColor = false;
            Button_Read.Click += Button_Read_Click;
            // 
            // Button_Write
            // 
            Button_Write.BackColor = Color.CornflowerBlue;
            Button_Write.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Button_Write.Location = new Point(40, 148);
            Button_Write.Name = "Button_Write";
            Button_Write.Size = new Size(176, 49);
            Button_Write.TabIndex = 1;
            Button_Write.Text = "WRITE FILE";
            Button_Write.UseVisualStyleBackColor = false;
            Button_Write.Click += Button_Write_Click;
            // 
            // TextBox_Content
            // 
            TextBox_Content.Location = new Point(256, 62);
            TextBox_Content.Multiline = true;
            TextBox_Content.Name = "TextBox_Content";
            TextBox_Content.ScrollBars = ScrollBars.Both;
            TextBox_Content.Size = new Size(497, 317);
            TextBox_Content.TabIndex = 2;
            // 
            // Label_Content
            // 
            Label_Content.AutoSize = true;
            Label_Content.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Label_Content.ForeColor = Color.CornflowerBlue;
            Label_Content.Location = new Point(256, 29);
            Label_Content.Name = "Label_Content";
            Label_Content.Size = new Size(96, 30);
            Label_Content.TabIndex = 3;
            Label_Content.Text = "Content";
            // 
            // Button_Exit
            // 
            Button_Exit.BackColor = Color.CornflowerBlue;
            Button_Exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_Exit.Location = new Point(40, 346);
            Button_Exit.Name = "Button_Exit";
            Button_Exit.Size = new Size(176, 33);
            Button_Exit.TabIndex = 4;
            Button_Exit.Text = "Exit";
            Button_Exit.UseVisualStyleBackColor = false;
            Button_Exit.Click += Button_Exit_Click;
            // 
            // Lab02_Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Button_Exit);
            Controls.Add(Label_Content);
            Controls.Add(TextBox_Content);
            Controls.Add(Button_Write);
            Controls.Add(Button_Read);
            Name = "Lab02_Bai01";
            Text = "Bài 01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Read;
        private Button Button_Write;
        private TextBox TextBox_Content;
        private Label Label_Content;
        private Button Button_Exit;
    }
}