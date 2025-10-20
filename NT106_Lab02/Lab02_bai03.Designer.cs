namespace NT106_Lab02
{
    partial class Lab02_Bai03
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

        private void InitializeComponent()
        {
            Label_Operation = new Label();
            TextBox_Operation = new TextBox();
            Label_Result = new Label();
            TextBox_Result = new TextBox();
            Button_Exit = new Button();
            Button_ReadIn = new Button();
            button_ReadOut = new Button();
            SuspendLayout();
            // 
            // Label_Operation
            // 
            Label_Operation.AutoSize = true;
            Label_Operation.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Label_Operation.ForeColor = Color.CornflowerBlue;
            Label_Operation.Location = new Point(12, 79);
            Label_Operation.Name = "Label_Operation";
            Label_Operation.Size = new Size(118, 30);
            Label_Operation.TabIndex = 18;
            Label_Operation.Text = "Operation";
            // 
            // TextBox_Operation
            // 
            TextBox_Operation.Location = new Point(12, 112);
            TextBox_Operation.Multiline = true;
            TextBox_Operation.Name = "TextBox_Operation";
            TextBox_Operation.ScrollBars = ScrollBars.Vertical;
            TextBox_Operation.Size = new Size(369, 284);
            TextBox_Operation.TabIndex = 17;
            // 
            // Label_Result
            // 
            Label_Result.AutoSize = true;
            Label_Result.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Label_Result.ForeColor = Color.CornflowerBlue;
            Label_Result.Location = new Point(421, 79);
            Label_Result.Name = "Label_Result";
            Label_Result.Size = new Size(76, 30);
            Label_Result.TabIndex = 20;
            Label_Result.Text = "Result";
            // 
            // TextBox_Result
            // 
            TextBox_Result.Location = new Point(421, 112);
            TextBox_Result.Multiline = true;
            TextBox_Result.Name = "TextBox_Result";
            TextBox_Result.ScrollBars = ScrollBars.Vertical;
            TextBox_Result.Size = new Size(369, 284);
            TextBox_Result.TabIndex = 19;
            // 
            // Button_Exit
            // 
            Button_Exit.BackColor = Color.CornflowerBlue;
            Button_Exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_Exit.Location = new Point(12, 402);
            Button_Exit.Name = "Button_Exit";
            Button_Exit.Size = new Size(113, 33);
            Button_Exit.TabIndex = 21;
            Button_Exit.Text = "Exit";
            Button_Exit.UseVisualStyleBackColor = false;
            Button_Exit.Click += Button_Exit_Click;
            // 
            // Button_ReadIn
            // 
            Button_ReadIn.BackColor = Color.CornflowerBlue;
            Button_ReadIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Button_ReadIn.Location = new Point(12, 25);
            Button_ReadIn.Name = "Button_ReadIn";
            Button_ReadIn.Size = new Size(183, 39);
            Button_ReadIn.TabIndex = 22;
            Button_ReadIn.Text = "Read File Input";
            Button_ReadIn.UseVisualStyleBackColor = false;
            Button_ReadIn.Click += Button_ReadIn_Click;
            // 
            // button_ReadOut
            // 
            button_ReadOut.BackColor = Color.CornflowerBlue;
            button_ReadOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_ReadOut.Location = new Point(421, 25);
            button_ReadOut.Name = "button_ReadOut";
            button_ReadOut.Size = new Size(183, 39);
            button_ReadOut.TabIndex = 23;
            button_ReadOut.Text = "Read File Output";
            button_ReadOut.UseVisualStyleBackColor = false;
            button_ReadOut.Click += Button_ReadOut_Click;
            // 
            // Lab02_Bai03
            // 
            ClientSize = new Size(802, 441);
            Controls.Add(button_ReadOut);
            Controls.Add(Button_ReadIn);
            Controls.Add(Button_Exit);
            Controls.Add(Label_Result);
            Controls.Add(TextBox_Result);
            Controls.Add(Label_Operation);
            Controls.Add(TextBox_Operation);
            Font = new Font("Segoe UI", 9F);
            Name = "Lab02_Bai03";
            Text = "Bài 03";
            ResumeLayout(false);
            PerformLayout();

        }
        private Label Label_Operation;
        private TextBox TextBox_Operation;
        private Label Label_Result;
        private TextBox TextBox_Result;
        private Button Button_Exit;
        private Button Button_ReadIn;
        private Button button_ReadOut;
    }
}