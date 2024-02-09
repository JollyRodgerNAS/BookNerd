namespace LibraryApplication
{
    partial class CreateNewLibrarianForm
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
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            emailLabel = new Label();
            phoneNumberLabel = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            emailTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            createNewButton = new Button();
            returnToMainMenuButton = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(50, 38);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(212, 30);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "Enter your first name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(50, 83);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(209, 30);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Enter your last name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(50, 128);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(169, 30);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Enter your email:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(50, 173);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(262, 30);
            phoneNumberLabel.TabIndex = 3;
            phoneNumberLabel.Text = "Enter your phone number: ";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(50, 218);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(216, 30);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "Enter your username: ";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(50, 263);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(206, 30);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Enter your password:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(322, 33);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(88, 35);
            firstNameTextBox.TabIndex = 6;
            firstNameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(322, 78);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(88, 35);
            lastNameTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(322, 123);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(88, 35);
            emailTextBox.TabIndex = 8;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(322, 168);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(88, 35);
            phoneNumberTextBox.TabIndex = 9;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(322, 213);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(88, 35);
            usernameTextBox.TabIndex = 10;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(322, 258);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(88, 35);
            passwordTextBox.TabIndex = 11;
            // 
            // createNewButton
            // 
            createNewButton.Location = new Point(272, 347);
            createNewButton.Name = "createNewButton";
            createNewButton.Size = new Size(107, 51);
            createNewButton.TabIndex = 12;
            createNewButton.Text = "Create";
            createNewButton.UseVisualStyleBackColor = true;
            createNewButton.Click += createNewButton_Click;
            // 
            // returnToMainMenuButton
            // 
            returnToMainMenuButton.Location = new Point(6, 386);
            returnToMainMenuButton.Name = "returnToMainMenuButton";
            returnToMainMenuButton.Size = new Size(256, 56);
            returnToMainMenuButton.TabIndex = 13;
            returnToMainMenuButton.Text = "Return to Main Menu";
            returnToMainMenuButton.UseVisualStyleBackColor = true;
            returnToMainMenuButton.Click += returnToMainMenuButton_Click;
            // 
            // CreateNewLibrarianForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(645, 454);
            Controls.Add(returnToMainMenuButton);
            Controls.Add(createNewButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(emailLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateNewLibrarianForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create New Librarian";
            Load += CreateNewLibrarianForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private Label phoneNumberLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox emailTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button createNewButton;
        private Button returnToMainMenuButton;
    }
}