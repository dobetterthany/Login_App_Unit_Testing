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
    public partial class Signin : Form
    {
        List<string> Users = new List<string>();
        List<string> Passwords = new List<string>();
        List<string> Credentials = new List<string>();
        string[] credentials = { "Admin", "Checkout", "admin", "checkout" };
        
        private string m_Username;
        private string m_Password;
        private string m_Credential;

        public Signin(string Username, string Password, string Credential)
        {
            m_Username = Username;
            m_Password = Password;
            m_Credential = Credential;
        }

        public string userName
        {
            get { return m_Username; }
        }

        public string Password
        {
            get { return m_Password; }
        }

        public string Credential
        {
            get { return m_Credential; }
        }

        public Signin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            validation(tbUserName.Text, tbPassword.Text, tbCredential.Text);
        }
        public string validation(string Username,string Password,string credential)
        {
            tbUserName.Text =  Username ;
            tbPassword.Text = Password;
            tbCredential.Text = credential;

            bool UN1 = false;
            bool PN1 = false;
            bool C1 = false;

            if (tbUserName.Text != "")
            {
                if (Users.Contains(Username))
                {
                    lbUNstatus.Text = "Username must be unique";
                }
                else
                {
                    lbUNstatus.Text = "Username looks good";
                    UN1 = true;
                }
            }
            else
            {
                lbUNstatus.Text = "You must fill in the blank";
            }

            if (tbPassword.Text != "")
            {
                if (tbPassword.Text.Length >= 8)
                {
                    int count = 0;
                    for (int i = 0; i <= 9; i++)
                    {
                        string str1 = Convert.ToString(i);

                        if (tbPassword.Text.Contains(str1))
                            count = ++count ;

                    }
                    if (count >= 2)
                    {
                        lbPWstatus.Text = "Very Good";
                        PN1 = true;
                    }
                    else if (count == 1)
                    {
                        lbPWstatus.Text = "not enough numbers";
                    }
                    else
                    {
                        lbPWstatus.Text = "invalid password";
                    }
                }
                else if (tbPassword.Text.Length < 8)
                {
                    lbPWstatus.Text = "Password should be over 8 characters";
                }
            }
            else
            {
                lbPWstatus.Text = "You must fill in the blank";
            }

            if (tbCredential.Text != "")
            {   
                if (credentials.Contains(tbCredential.Text))
                {
                    lbCstatus.Text = "Nice";
                    C1 = true;
                }
                else
                {
                    lbCstatus.Text = "Wrong credential";
                }
            }
            else
            {
                lbCstatus.Text = "You must fill in the blank";
            }


            if (UN1 == true && PN1 == true && C1 == true)
            {
                MessageBox.Show("Signin Successfully!");
                return "Signin Successfully!";
            }
            else
            {
                MessageBox.Show("Sign in Failed. Please check what is wrong");
                return "Sign in Failed. Please check what is wrong";
            }
        }
        

        private void Signin_Load(object sender, EventArgs e)
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

        private void lbPWstatus_Click(object sender, EventArgs e)
        {

        }
    }
}
