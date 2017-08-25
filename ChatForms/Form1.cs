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
    public partial class ChatForms : Form
    {
        User user = new User();
        Client client;
        List<string> contactList = new List<string>();
        public bool ifPrivate = false;
        public string privateName = "";

        public ChatForms()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; // lyssnar på alla trådar
            client = new Client(this);
            client.Start();
        }
        private void ChatForms_Load(object sender, EventArgs e)
        {
            LoginBox lb = new LoginBox();
            do
            {
                lb.ShowLoginForm(user, client);

                for (int i = 0; i < 50; i++)
                {
                    Thread.Sleep(100);
                    if (client.loginSucceeded == true)
                    {
                        break;
                    }
                }

            } while (client.loginSucceeded == false);
            if (client.server.Connected == false)
            {
                this.Close();
            }
        }

        // Skicka-knapp
        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (ifPrivate)
            {
                string temp = $"{privateName};{inputBox.Text}";
                client.SendPrivate(user.Username, temp);
                ifPrivate = false;
            }
            else
            {
                client.Send(user.Username, inputBox.Text);
            }
            inputBox.Clear();
        }

        // Chattruta
        public void WriteToChatBox(string name, string message)
        {
            chatBox.Items.Add($"{name}: {message}");
        }

        private void ChatForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.QuitClient();
        }
        // Kontaktruta
        public void DisplayContacts(string[] contactList)
        {
            contactsBox.Items.Clear();

            if (contactList != null && contactList.Length > 0)
            {
                foreach (var name in contactList)
                {
                    if (name.Length > 0)
                    {
                        contactsBox.Items.Add($"{name}");
                    }
                }
            }
        }

        private void contactsBox_MouseClick(object sender, MouseEventArgs e)
        {
            privateName = contactsBox.SelectedItem.ToString();
            ifPrivate = true;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            client.QuitClient();
            this.Visible = false;
            ShowDialog();
        }
    }
}
