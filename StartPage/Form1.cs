using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.ShowDialog();
            this.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Signin Signin = new Signin();
            Signin.ShowDialog();
            this.Show();
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You must log in");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
