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
        Client client;
        public ChatForms()
        {
            InitializeComponent();
            client = new Client(this);
            client.Start();
        }

        // Skicka-knapp
        private void sendBtn_Click(object sender, EventArgs e)
        {
            client.Send(textBox1.Text , inputBox.Text);
            inputBox.Clear();
        }

        // Chattruta
        public void WriteToChatBox(string name, string message)
        {
            chatBox.Items.Add($"{name}: {message}");
        }

    }
}
