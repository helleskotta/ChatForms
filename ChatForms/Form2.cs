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
    public partial class Form2 : Form
    {
        Client client;
        public Form2()
        {
            InitializeComponent();
            client = new Client(this);
            client.Start();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var form2 = new ChatForms();
            client.Send(loginBox.Text, passwordBox.Text);
            form2.Show();
            this.Visible = false;
        }
    }
}
