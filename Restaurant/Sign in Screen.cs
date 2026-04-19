using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Sign_in_Screen : Form
    {
        public static Sign_in_Screen instance;
        public TextBox userS;
        public TextBox passS;
        public Sign_in_Screen()
        {
            InitializeComponent();
            instance = this;
            String User = textBox1.Text;
            String Pass = textBox2.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void Sign_in_Screen_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userS = textBox1;
            passS = textBox2;
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
