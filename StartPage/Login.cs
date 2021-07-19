using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StartPage
{
    public partial class Login : Form
    {
        List<string> Users = new List<string>();
        List<string> Passwords = new List<string>();
        List<string> Credentials = new List<string>();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("UserInfos.txt");

            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] UserInfo = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                Users.Add(UserInfo[0]);
                Passwords.Add(UserInfo[1]);
                Credentials.Add(UserInfo[2]);
            }
            tbUserName.Text = "Username";
            tbPassword.Text = "Password";
            tbCredential.Text = "Credential";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            int indexOfUser = Array.IndexOf(Users.ToArray(), tbUserName.Text);
            int indexOfPassword = Array.IndexOf(Passwords.ToArray(), tbPassword.Text);


            if(Users.Contains(tbUserName.Text) && Passwords.Contains(tbPassword.Text) && indexOfUser == indexOfPassword)
            {
                if (Credentials[indexOfUser] == tbCredential.Text)
                {
                    MessageBox.Show("Login Successfully");
                    ViewButton ViewButton = new ViewButton();
                    ViewButton.ShowDialog();
                    this.Show();
                }else
                {
                    MessageBox.Show("incorrect credential");
                }
            }else
            {
                MessageBox.Show("No User found");
            }

        }



        private void btnViewCart_Click(object sender, EventArgs e)
        {
            ViewCart ViewCart = new ViewCart();
            ViewCart.ShowDialog();
            this.Show();
        }
    }
}
