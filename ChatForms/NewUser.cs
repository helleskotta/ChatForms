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
    public partial class NewUser : Form
    {
        User user;
        Client client;

        public NewUser()
        {
            InitializeComponent();
        }

        public DialogResult ShowLoginForm(User user, Client client)
        {
            this.user = user;
            this.client = client;
            return ShowDialog();
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text.Length > 1 && passwordBox.Text.Length > 3 && passwordBox.Text == passwordBox2.Text)
            {
                user.Username = usernameBox.Text;
                user.Password = passwordBox.Text;
                //client.Create(user.Username, user.Password);
            }
            else
            {
                // Validering??? 
            }
        }
    }
}
