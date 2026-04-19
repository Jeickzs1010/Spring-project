namespace Restaurant
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_In_Screen log_In_Screen = new Log_In_Screen();
            log_In_Screen.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_in_Screen sign_In_Screen = new Sign_in_Screen();
            sign_In_Screen.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
