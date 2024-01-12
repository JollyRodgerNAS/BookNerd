namespace LibraryApplication
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            welcomeLabel = new Label();
            enterLoginInfoLabel = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            loginButton = new Button();
            createNewLinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(234, 35);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(234, 30);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome to Book Nerd!";
            // 
            // enterLoginInfoLabel
            // 
            enterLoginInfoLabel.AutoSize = true;
            enterLoginInfoLabel.Location = new Point(108, 80);
            enterLoginInfoLabel.Name = "enterLoginInfoLabel";
            enterLoginInfoLabel.Size = new Size(295, 30);
            enterLoginInfoLabel.TabIndex = 1;
            enterLoginInfoLabel.Text = "Enter your library login info or:";
            enterLoginInfoLabel.Click += enterLoginInfoLabel_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(29, 135);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(210, 30);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Enter your username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(29, 176);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(206, 30);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Enter your password:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(247, 132);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(106, 35);
            firstNameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(247, 176);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(106, 35);
            lastNameTextBox.TabIndex = 6;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(299, 246);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(104, 48);
            loginButton.TabIndex = 8;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // createNewLinkLabel
            // 
            createNewLinkLabel.AutoSize = true;
            createNewLinkLabel.Location = new Point(409, 80);
            createNewLinkLabel.Name = "createNewLinkLabel";
            createNewLinkLabel.Size = new Size(114, 30);
            createNewLinkLabel.TabIndex = 9;
            createNewLinkLabel.TabStop = true;
            createNewLinkLabel.Text = "create new";
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(726, 386);
            Controls.Add(createNewLinkLabel);
            Controls.Add(loginButton);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(enterLoginInfoLabel);
            Controls.Add(welcomeLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "WelcomeForm";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private Label enterLoginInfoLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Button loginButton;
        private LinkLabel createNewLinkLabel;
    }
}
