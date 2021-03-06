﻿using System;
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
        private bool mouseDown = false;

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

                for (int i = 0; i < 50; i++)
                {
                    Thread.Sleep(1000);
                    if (client.createUserSucceeded == true)
                    {
                        this.Close();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Användarnamnet är upptaget.");
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Felaktigt användarnamn och/eller lösenord. Försök igen!");
            }
        }

        private void CloseButtonNewUser_Click(object sender, EventArgs e)
        {
            client.QuitClient();
            Close();
            client.loginSucceeded = true;
        }

        private void NewUser_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void NewUser_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void NewUser_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
                this.Location = MousePosition;
        }
    }
}
