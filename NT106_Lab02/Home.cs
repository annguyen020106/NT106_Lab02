namespace NT106_Lab02
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
            this.Size = size;
        }
        //Nhấn Bài 1
        private void Button_B1_Click(object sender, EventArgs e)
        {
            Lab02_Bai01 BT = new Lab02_Bai01(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 2
        private void Button_B2_Click(object sender, EventArgs e)
        {
            Lab02_Bai02 BT = new Lab02_Bai02(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 3
        private void Button_B3_Click(object sender, EventArgs e)
        {
            Lab02_Bai03 BT = new Lab02_Bai03(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 4
        private void Button_B4_Click(object sender, EventArgs e)
        {
            Lab02_Bai04 BT = new Lab02_Bai04(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 5
        private void Button_B5_Click(object sender, EventArgs e)
        {
            Lab02_Bai05 BT = new Lab02_Bai05(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 6
        private void Button_B6_Click(object sender, EventArgs e)
        {
            Lab02_Bai06 BT = new Lab02_Bai06(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
        //Nhấn Bài 7
        private void Button_B7_Click(object sender, EventArgs e)
        {
            Lab02_Bai07 BT = new Lab02_Bai07(this.Location, this.Size);
            BT.Show();
            this.Hide();
        }
    }
}
