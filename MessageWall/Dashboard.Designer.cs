namespace MessageWall
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.helloWorldButton = new System.Windows.Forms.Button();
            this.goodbyeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(140, 70);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(258, 55);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(425, 70);
            this.firstNameText.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(531, 62);
            this.firstNameText.TabIndex = 1;
            // 
            // helloWorldButton
            // 
            this.helloWorldButton.Location = new System.Drawing.Point(37, 229);
            this.helloWorldButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.helloWorldButton.Name = "helloWorldButton";
            this.helloWorldButton.Size = new System.Drawing.Size(443, 112);
            this.helloWorldButton.TabIndex = 2;
            this.helloWorldButton.Text = "Hello World";
            this.helloWorldButton.UseVisualStyleBackColor = true;
            this.helloWorldButton.Click += new System.EventHandler(this.HelloWorldButton_Click);
            // 
            // goodbyeButton
            // 
            this.goodbyeButton.Location = new System.Drawing.Point(553, 229);
            this.goodbyeButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.goodbyeButton.Name = "goodbyeButton";
            this.goodbyeButton.Size = new System.Drawing.Size(457, 112);
            this.goodbyeButton.TabIndex = 3;
            this.goodbyeButton.Text = "Goodbye";
            this.goodbyeButton.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 756);
            this.Controls.Add(this.goodbyeButton);
            this.Controls.Add(this.helloWorldButton);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Button helloWorldButton;
        private System.Windows.Forms.Button goodbyeButton;
    }
}

