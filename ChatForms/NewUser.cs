using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatForms
{
    public partial class NewUser : Form
    {
        User user;
        Client client;

        public NewUser()
        {
            InitializeComponent();
        }

        public DialogResult ShowLoginForm(Client client, User user)
        {
            this.client = client;
            this.user = user;
            return ShowDialog();
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {

            if (usernameBox.Text.Length > 1 && passwordBox.Text.Length > 3 && passwordBox.Text == passwordBox2.Text)
            {
                user.Username = usernameBox.Text;
                user.Password = passwordBox.Text;
                client.Create(user.Username, user.Password);
                Thread.Sleep(600);

                if (client.createUserSucceeded == true)
                {
                    this.Close();

                }

                else
                {
                    MessageBox.Show("Användarnamnet är upptaget.");
                }
            }
            else
            {
                MessageBox.Show("Felaktigt användarnamn och/eller lösenord. Försök igen!");
            }
        }
    }
}
