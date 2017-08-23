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
        public ChatForms()
        {
            InitializeComponent();
            client = new Client(this);
            this.Tag = "YYY";
            client.Start();
        }
        private void ChatForms_Load(object sender, EventArgs e)
        {
            LoginBox lb = new LoginBox();
            lb.ShowLoginForm(user, this);
        }
        // Skicka-knapp
        private void sendBtn_Click(object sender, EventArgs e)
        {
            client.Send(user.Username, inputBox.Text);
            inputBox.Clear();
        }

        // Chattruta
        public void WriteToChatBox(string name, string message)
        {
            chatBox.Items.Add($"{name}: {message}");
        }

        private void ChatForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
        }
    }
}
