using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatForms
{
    public partial class LoginBox : Form
    {
        User user;
        Client client;

        public LoginBox()
        {
            InitializeComponent();
        }

        public DialogResult ShowLoginForm(User user, Client client)
        {
            this.user = user;
            this.client = client;
            return ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text.Length > 1 && passwordBox.Text.Length > 3)
            {
                user.Username = usernameBox.Text;
                user.Password = passwordBox.Text;
                client.Login(user.Username, user.Password);
            }
            else
            {
                MessageBox.Show("Felaktigt användarnamn och/eller lösenord. Försök igen.!");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            client.QuitClient();
            Close();
            client.loginSucceeded = true;
        }
    }
}