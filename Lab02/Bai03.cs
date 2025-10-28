using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai03 : Form
    {
        private string inputPath;
        private string outputPath;

        public Bai03()
        {
            InitializeComponent();
            InitializeFilePaths();
            SetupTextBoxes();
        }
        public Bai03(Point location, Size size)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
            InitializeFilePaths();
            SetupTextBoxes();
        }
        // Set up
        private void SetupTextBoxes()
        {
            TextBox_Operation.Multiline = true;
            TextBox_Operation.ScrollBars = ScrollBars.Both;
            TextBox_Operation.WordWrap = false;

            TextBox_Result.Multiline = true;
            TextBox_Result.ScrollBars = ScrollBars.Both;
            TextBox_Result.WordWrap = false;
        }
        // Khởi tạo
        private void InitializeFilePaths()
        {
            string folderPath = Application.StartupPath;
            inputPath = Path.Combine(folderPath, "input3.txt");
            outputPath = Path.Combine(folderPath, "output3.txt");

            if (!File.Exists(inputPath))
            {
                string sample = "1 + 2 + 3 + 4\n" +
                                "12 - 7 - 5 + 2 - 3\n" +
                                "2024 - 1 - 2 + 3\n" +
                                "222 + 333 - 444 + 1\n" +
                                "(2 + 3) * 4\n" +
                                "10 / (5 - 3)";
                File.WriteAllText(inputPath, sample);
            }
        }
        // Nhấn Exit
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Home BT = new Home(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        // Nhấn Read In
        private void Button_ReadIn_Click(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText(inputPath);
                TextBox_Operation.Text = content;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Nhấn Read Out
        private void Button_ReadOut_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines(inputPath);
                List<string> outputLines = new List<string>();

                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    double result = EvaluateExpression(line);
                    outputLines.Add($"{line} = {result}");
                }

                File.WriteAllLines(outputPath, outputLines);
                TextBox_Result.Text = string.Join(Environment.NewLine, outputLines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Tính toán
        private double EvaluateExpression(string expression)
        {
            try
            {
                var tokens = Regex.Split(expression.Replace(" ", ""), @"([+\-*/()])");
                Stack<double> values = new Stack<double>();
                Stack<char> ops = new Stack<char>();

                foreach (var token in tokens)
                {
                    if (string.IsNullOrWhiteSpace(token)) continue;

                    if (double.TryParse(token, out double num))
                    {
                        values.Push(num);
                    }
                    else if (token == "(")
                    {
                        ops.Push('(');
                    }
                    else if (token == ")")
                    {
                        while (ops.Peek() != '(')
                            values.Push(ApplyOperator(ops.Pop(), values.Pop(), values.Pop()));
                        ops.Pop();
                    }
                    else if ("+-*/".Contains(token))
                    {
                        char op = token[0];
                        while (ops.Count > 0 && Precedence(ops.Peek()) >= Precedence(op))
                            values.Push(ApplyOperator(ops.Pop(), values.Pop(), values.Pop()));
                        ops.Push(op);
                    }
                }

                while (ops.Count > 0)
                    values.Push(ApplyOperator(ops.Pop(), values.Pop(), values.Pop()));

                return values.Pop();
            }
            catch
            {
                return double.NaN;
            }
        }
        // Độ ưu tiên
        private int Precedence(char op)
        {
            if (op == '+' || op == '-') return 1;
            if (op == '*' || op == '/') return 2;
            return 0;
        }
        // Toán tử
        private double ApplyOperator(char op, double b, double a)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return b == 0 ? double.NaN : a / b;
                default: return 0;
            }
        }
    }
}
