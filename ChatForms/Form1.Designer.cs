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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(89, 435);
            this.inputBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(404, 36);
            this.inputBox.TabIndex = 0;
            // 
            // chatBox
            // 
            this.chatBox.FormattingEnabled = true;
            this.chatBox.Location = new System.Drawing.Point(9, 10);
            this.chatBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(484, 407);
            this.chatBox.TabIndex = 1;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(497, 452);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(56, 19);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // contactsBox
            // 
            this.contactsBox.FormattingEnabled = true;
            this.contactsBox.Location = new System.Drawing.Point(555, 36);
            this.contactsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contactsBox.Name = "contactsBox";
            this.contactsBox.Size = new System.Drawing.Size(158, 407);
            this.contactsBox.TabIndex = 3;
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(553, 10);
            this.contactLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(49, 13);
            this.contactLabel.TabIndex = 4;
            this.contactLabel.Text = "Contacts";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 452);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 433);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(87, 418);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(86, 13);
            this.messageLabel.TabIndex = 7;
            this.messageLabel.Text = "Write a message";
            // 
            // ChatForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 479);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.contactsBox);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.inputBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChatForms";
            this.Text = "ChatForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.ListBox chatBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.ListBox contactsBox;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label messageLabel;
    }
}

