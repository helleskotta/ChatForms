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
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(31, 550);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(544, 22);
            this.inputBox.TabIndex = 0;
            // 
            // chatBox
            // 
            this.chatBox.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatBox.FormattingEnabled = true;
            this.chatBox.ItemHeight = 18;
            this.chatBox.Location = new System.Drawing.Point(31, 96);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(626, 418);
            this.chatBox.TabIndex = 1;
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.White;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendBtn.Font = new System.Drawing.Font("Open Sans Extrabold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(581, 550);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(76, 22);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // contactsBox
            // 
            this.contactsBox.FormattingEnabled = true;
            this.contactsBox.ItemHeight = 16;
            this.contactsBox.Location = new System.Drawing.Point(667, 94);
            this.contactsBox.Name = "contactsBox";
            this.contactsBox.Size = new System.Drawing.Size(161, 420);
            this.contactsBox.TabIndex = 3;
            this.contactsBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contactsBox_MouseClick);
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(662, 63);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(146, 27);
            this.contactLabel.TabIndex = 4;
            this.contactLabel.Text = "Who is online?";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(34, 524);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(147, 23);
            this.messageLabel.TabIndex = 7;
            this.messageLabel.Text = "Write a message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome to ChatForms!";
            // 
            // CloseButtonNewUser
            // 
            this.CloseButtonNewUser.BackColor = System.Drawing.Color.DarkRed;
            this.CloseButtonNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButtonNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButtonNewUser.ForeColor = System.Drawing.Color.White;
            this.CloseButtonNewUser.Location = new System.Drawing.Point(861, 12);
            this.CloseButtonNewUser.Name = "CloseButtonNewUser";
            this.CloseButtonNewUser.Size = new System.Drawing.Size(24, 26);
            this.CloseButtonNewUser.TabIndex = 16;
            this.CloseButtonNewUser.Text = "X";
            this.CloseButtonNewUser.UseVisualStyleBackColor = false;
            // 
            // ChatForms
            // 
            this.AcceptButton = this.sendBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(897, 590);
            this.Controls.Add(this.CloseButtonNewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.contactsBox);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.inputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatForms";
            this.Text = "ChatForms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForms_FormClosing);
            this.Load += new System.EventHandler(this.ChatForms_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseButtonNewUser;
    }
}

