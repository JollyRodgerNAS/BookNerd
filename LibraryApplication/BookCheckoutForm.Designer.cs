namespace LibraryApplication
{
    partial class BookCheckoutForm
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
            chooseCardholderLabel = new Label();
            chooseBookLabel = new Label();
            cardholderComboBox = new ComboBox();
            bookComboBox = new ComboBox();
            createNewCardholderGroupBox = new GroupBox();
            createCardholerButton = new Button();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            createNewBookGroupBox = new GroupBox();
            createBookButton = new Button();
            authorNameTextBox = new TextBox();
            bookNameTextBox = new TextBox();
            authorNameLabel = new Label();
            bookNameLabel = new Label();
            checkoutButton = new Button();
            returnToMainMenuButton = new Button();
            createNewCardholderGroupBox.SuspendLayout();
            createNewBookGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // chooseCardholderLabel
            // 
            chooseCardholderLabel.AutoSize = true;
            chooseCardholderLabel.Location = new Point(20, 24);
            chooseCardholderLabel.Name = "chooseCardholderLabel";
            chooseCardholderLabel.Size = new Size(396, 30);
            chooseCardholderLabel.TabIndex = 0;
            chooseCardholderLabel.Text = "Choose cardholder that is recieving book:";
            // 
            // chooseBookLabel
            // 
            chooseBookLabel.AutoSize = true;
            chooseBookLabel.Location = new Point(20, 94);
            chooseBookLabel.Name = "chooseBookLabel";
            chooseBookLabel.Size = new Size(379, 30);
            chooseBookLabel.TabIndex = 1;
            chooseBookLabel.Text = "Choose book that is being checked out:";
            // 
            // cardholderComboBox
            // 
            cardholderComboBox.FormattingEnabled = true;
            cardholderComboBox.Location = new Point(422, 21);
            cardholderComboBox.Name = "cardholderComboBox";
            cardholderComboBox.Size = new Size(113, 38);
            cardholderComboBox.TabIndex = 2;
            // 
            // bookComboBox
            // 
            bookComboBox.FormattingEnabled = true;
            bookComboBox.Location = new Point(422, 91);
            bookComboBox.Name = "bookComboBox";
            bookComboBox.Size = new Size(114, 38);
            bookComboBox.TabIndex = 3;
            // 
            // createNewCardholderGroupBox
            // 
            createNewCardholderGroupBox.Controls.Add(createCardholerButton);
            createNewCardholderGroupBox.Controls.Add(lastNameTextBox);
            createNewCardholderGroupBox.Controls.Add(firstNameTextBox);
            createNewCardholderGroupBox.Controls.Add(lastNameLabel);
            createNewCardholderGroupBox.Controls.Add(firstNameLabel);
            createNewCardholderGroupBox.Location = new Point(20, 231);
            createNewCardholderGroupBox.Name = "createNewCardholderGroupBox";
            createNewCardholderGroupBox.Size = new Size(256, 193);
            createNewCardholderGroupBox.TabIndex = 4;
            createNewCardholderGroupBox.TabStop = false;
            createNewCardholderGroupBox.Text = "Create cardholder";
            // 
            // createCardholerButton
            // 
            createCardholerButton.Location = new Point(85, 119);
            createCardholerButton.Name = "createCardholerButton";
            createCardholerButton.Size = new Size(86, 43);
            createCardholerButton.TabIndex = 4;
            createCardholerButton.Text = "Create";
            createCardholerButton.UseVisualStyleBackColor = true;
            createCardholerButton.Click += createCardholerButton_Click;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(177, 68);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(70, 35);
            lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(177, 26);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(70, 35);
            firstNameTextBox.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(6, 73);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(162, 30);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Enter last name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(6, 31);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(165, 30);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "Enter first name:";
            // 
            // createNewBookGroupBox
            // 
            createNewBookGroupBox.Controls.Add(createBookButton);
            createNewBookGroupBox.Controls.Add(authorNameTextBox);
            createNewBookGroupBox.Controls.Add(bookNameTextBox);
            createNewBookGroupBox.Controls.Add(authorNameLabel);
            createNewBookGroupBox.Controls.Add(bookNameLabel);
            createNewBookGroupBox.Location = new Point(322, 231);
            createNewBookGroupBox.Name = "createNewBookGroupBox";
            createNewBookGroupBox.Size = new Size(289, 193);
            createNewBookGroupBox.TabIndex = 5;
            createNewBookGroupBox.TabStop = false;
            createNewBookGroupBox.Text = "Create book";
            // 
            // createBookButton
            // 
            createBookButton.Location = new Point(106, 119);
            createBookButton.Name = "createBookButton";
            createBookButton.Size = new Size(94, 43);
            createBookButton.TabIndex = 4;
            createBookButton.Text = "Create";
            createBookButton.UseVisualStyleBackColor = true;
            createBookButton.Click += createBookButton_Click;
            // 
            // authorNameTextBox
            // 
            authorNameTextBox.Location = new Point(209, 70);
            authorNameTextBox.Name = "authorNameTextBox";
            authorNameTextBox.Size = new Size(74, 35);
            authorNameTextBox.TabIndex = 3;
            // 
            // bookNameTextBox
            // 
            bookNameTextBox.Location = new Point(209, 26);
            bookNameTextBox.Name = "bookNameTextBox";
            bookNameTextBox.Size = new Size(74, 35);
            bookNameTextBox.TabIndex = 2;
            // 
            // authorNameLabel
            // 
            authorNameLabel.AutoSize = true;
            authorNameLabel.Location = new Point(9, 73);
            authorNameLabel.Name = "authorNameLabel";
            authorNameLabel.Size = new Size(191, 30);
            authorNameLabel.TabIndex = 1;
            authorNameLabel.Text = "Enter author name:";
            // 
            // bookNameLabel
            // 
            bookNameLabel.AutoSize = true;
            bookNameLabel.Location = new Point(9, 31);
            bookNameLabel.Name = "bookNameLabel";
            bookNameLabel.Size = new Size(176, 30);
            bookNameLabel.TabIndex = 0;
            bookNameLabel.Text = "Enter book name:";
            // 
            // checkoutButton
            // 
            checkoutButton.Location = new Point(223, 145);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(140, 59);
            checkoutButton.TabIndex = 6;
            checkoutButton.Text = "Checkout";
            checkoutButton.UseVisualStyleBackColor = true;
            checkoutButton.Click += checkoutButton_Click;
            // 
            // returnToMainMenuButton
            // 
            returnToMainMenuButton.Location = new Point(20, 430);
            returnToMainMenuButton.Name = "returnToMainMenuButton";
            returnToMainMenuButton.Size = new Size(256, 56);
            returnToMainMenuButton.TabIndex = 7;
            returnToMainMenuButton.Text = "Return to Main Menu";
            returnToMainMenuButton.UseVisualStyleBackColor = true;
            returnToMainMenuButton.Click += returnToMainMenuButton_Click;
            // 
            // BookCheckoutForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(655, 541);
            Controls.Add(returnToMainMenuButton);
            Controls.Add(checkoutButton);
            Controls.Add(createNewBookGroupBox);
            Controls.Add(createNewCardholderGroupBox);
            Controls.Add(bookComboBox);
            Controls.Add(cardholderComboBox);
            Controls.Add(chooseBookLabel);
            Controls.Add(chooseCardholderLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "BookCheckoutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Checkout Book";
            createNewCardholderGroupBox.ResumeLayout(false);
            createNewCardholderGroupBox.PerformLayout();
            createNewBookGroupBox.ResumeLayout(false);
            createNewBookGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label chooseCardholderLabel;
        private Label chooseBookLabel;
        private ComboBox cardholderComboBox;
        private ComboBox bookComboBox;
        private GroupBox createNewCardholderGroupBox;
        private GroupBox createNewBookGroupBox;
        private Button checkoutButton;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private Button createCardholerButton;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label authorNameLabel;
        private Label bookNameLabel;
        private Button createBookButton;
        private TextBox authorNameTextBox;
        private TextBox bookNameTextBox;
        private Button returnToMainMenuButton;
    }
}