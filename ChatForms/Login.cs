﻿using System;
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
        private bool mouseDown { get; set; } = false;

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

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            NewUser registerUserForm = new NewUser();
            registerUserForm.ShowLoginForm(client, user);
            this.Visible = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            client.QuitClient();
            Close();
            client.loginSucceeded = true;
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
            }
        }

        private void usernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
            }
        }

        private void LoginBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void LoginBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void LoginBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
                this.Location = MousePosition;
        }
    }
}