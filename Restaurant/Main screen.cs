using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Main_screen : Form
    {
        public Main_screen()
        {
            InitializeComponent();
        }

        private void Main_screen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tables tables = new Tables();
            tables.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders orders = new Orders();
            orders.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff staff = new Staff();
            staff.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
