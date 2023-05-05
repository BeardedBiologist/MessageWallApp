﻿namespace MessageWall
{
    partial class Dashboard
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.TextBox();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.messageListBoxLabel = new System.Windows.Forms.Label();
            this.addMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(152, 105);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(171, 42);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Message";
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(330, 100);
            this.messageText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(331, 49);
            this.messageText.TabIndex = 1;
            // 
            // messageListBox
            // 
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 42;
            this.messageListBox.Location = new System.Drawing.Point(160, 266);
            this.messageListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(501, 298);
            this.messageListBox.TabIndex = 3;
            this.messageListBox.TabStop = false;
            // 
            // messageListBoxLabel
            // 
            this.messageListBoxLabel.AutoSize = true;
            this.messageListBoxLabel.Location = new System.Drawing.Point(152, 212);
            this.messageListBoxLabel.Name = "messageListBoxLabel";
            this.messageListBoxLabel.Size = new System.Drawing.Size(190, 42);
            this.messageListBoxLabel.TabIndex = 0;
            this.messageListBoxLabel.Text = "Messages";
            // 
            // addMessage
            // 
            this.addMessage.Location = new System.Drawing.Point(678, 98);
            this.addMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addMessage.Name = "addMessage";
            this.addMessage.Size = new System.Drawing.Size(98, 49);
            this.addMessage.TabIndex = 2;
            this.addMessage.Text = "Add";
            this.addMessage.UseVisualStyleBackColor = true;
            this.addMessage.Click += new System.EventHandler(this.AddMessage_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 658);
            this.Controls.Add(this.addMessage);
            this.Controls.Add(this.messageListBox);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.messageListBoxLabel);
            this.Controls.Add(this.messageLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.Label messageListBoxLabel;
        private System.Windows.Forms.Button addMessage;
    }
}

