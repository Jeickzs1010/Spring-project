using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Log_In_Screen : Form
    {
        public static Log_In_Screen instace;
        public TextBox tb1;
        public Log_In_Screen()
        {
            InitializeComponent();
            instace = this;

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Log_In_Screen_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {


        }

        private void Create_Click_1(object sender, EventArgs e)
        {
            String evilUser = Sign_in_Screen.instance.userS.Text;
            String evilPassword = Sign_in_Screen.instance.passS.Text;
            String user = User.Text;
            String pass = Password.Text;
            if (evilUser.Equals(user) && evilPassword.Equals(pass))
            {
                this.Hide();
                Main_screen main_Screen = new Main_screen();
                main_Screen.Show();
            }
        }

        private void User_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
