namespace ungdungdatlichvathanhtoantructuyen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void tHÔNGTINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thông tin ứng dụng");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        // Menu Thông tin
        private void thÔNGTINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ứng dụng đặt lịch và thanh toán trực tuyến");
        }

        // Menu Thoát
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Menu Mở file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
        }

        private void homeToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }

}