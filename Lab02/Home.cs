namespace Lab02
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public Home(Point location, Size size)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
        }
        //Nhấn Bài 1
        private void Button_B1_Click(object sender, EventArgs e)
        {
            Bai01 BT = new Bai01(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 2
        private void Button_B2_Click(object sender, EventArgs e)
        {
            Bai02 BT = new Bai02(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 3
        private void Button_B3_Click(object sender, EventArgs e)
        {
            Bai03 BT = new Bai03(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 4
        private void Button_B4_Click(object sender, EventArgs e)
        {
            Bai04 BT = new Bai04(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 5
        private void Button_B5_Click(object sender, EventArgs e)
        {
            Bai05 BT = new Bai05(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 6
        private void Button_B6_Click(object sender, EventArgs e)
        {
            Bai06 BT = new Bai06(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 7
        private void Button_B7_Click(object sender, EventArgs e)
        {
            Bai07 BT = new Bai07(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        private void MSSV_24520054_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
