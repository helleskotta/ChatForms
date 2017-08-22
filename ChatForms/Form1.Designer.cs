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
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(12, 556);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(644, 22);
            this.inputBox.TabIndex = 0;
            // 
            // chatBox
            // 
            this.chatBox.FormattingEnabled = true;
            this.chatBox.ItemHeight = 16;
            this.chatBox.Location = new System.Drawing.Point(12, 12);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(644, 532);
            this.chatBox.TabIndex = 1;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(663, 556);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            // 
            // contactsBox
            // 
            this.contactsBox.FormattingEnabled = true;
            this.contactsBox.ItemHeight = 16;
            this.contactsBox.Location = new System.Drawing.Point(740, 44);
            this.contactsBox.Name = "contactsBox";
            this.contactsBox.Size = new System.Drawing.Size(210, 500);
            this.contactsBox.TabIndex = 3;
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(737, 12);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(63, 17);
            this.contactLabel.TabIndex = 4;
            this.contactLabel.Text = "Contacts";
            // 
            // appNameLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 590);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.contactsBox);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.inputBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "appNameLabel";
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
    }
}

