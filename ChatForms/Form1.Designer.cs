namespace ChatForms
{
    partial class ChatForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForms));
            this.inputBox = new System.Windows.Forms.TextBox();
            this.chatBox = new System.Windows.Forms.ListBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.contactsBox = new System.Windows.Forms.ListBox();
            this.contactLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButtonNewUser = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(41, 626);
            this.inputBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(580, 27);
            this.inputBox.TabIndex = 0;
            // 
            // chatBox
            // 
            this.chatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatBox.FormattingEnabled = true;
            this.chatBox.ItemHeight = 22;
            this.chatBox.Location = new System.Drawing.Point(41, 118);
            this.chatBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(832, 466);
            this.chatBox.TabIndex = 1;
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.White;
            this.sendBtn.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.sendBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sendBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(687, 626);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(101, 34);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // contactsBox
            // 
            this.contactsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactsBox.FormattingEnabled = true;
            this.contactsBox.ItemHeight = 20;
            this.contactsBox.Location = new System.Drawing.Point(889, 116);
            this.contactsBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.contactsBox.Name = "contactsBox";
            this.contactsBox.Size = new System.Drawing.Size(161, 464);
            this.contactsBox.TabIndex = 3;
            this.contactsBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contactsBox_MouseClick);
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(881, 78);
            this.contactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(141, 25);
            this.contactLabel.TabIndex = 4;
            this.contactLabel.Text = "Who is online?";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(37, 604);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(151, 20);
            this.messageLabel.TabIndex = 7;
            this.messageLabel.Text = "Write a message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome to ChatBox!";
            // 
            // CloseButtonNewUser
            // 
            this.CloseButtonNewUser.BackColor = System.Drawing.Color.Transparent;
            this.CloseButtonNewUser.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.CloseButtonNewUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.CloseButtonNewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseButtonNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButtonNewUser.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold);
            this.CloseButtonNewUser.ForeColor = System.Drawing.Color.DarkRed;
            this.CloseButtonNewUser.Location = new System.Drawing.Point(1070, -3);
            this.CloseButtonNewUser.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CloseButtonNewUser.Name = "CloseButtonNewUser";
            this.CloseButtonNewUser.Size = new System.Drawing.Size(33, 42);
            this.CloseButtonNewUser.TabIndex = 16;
            this.CloseButtonNewUser.Text = "X";
            this.CloseButtonNewUser.UseVisualStyleBackColor = false;
            this.CloseButtonNewUser.Click += new System.EventHandler(this.CloseButtonNewUser_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Maroon;
            this.LogOutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LogOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LogOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogOutButton.Location = new System.Drawing.Point(881, 623);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(5);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(169, 34);
            this.LogOutButton.TabIndex = 8;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // ChatForms
            // 
            this.AcceptButton = this.sendBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1103, 691);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.CloseButtonNewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.contactsBox);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.inputBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "ChatForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatForms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForms_FormClosing);
            this.Load += new System.EventHandler(this.ChatForms_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChatForms_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChatForms_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChatForms_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.ListBox chatBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.ListBox contactsBox;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseButtonNewUser;
    }
}

