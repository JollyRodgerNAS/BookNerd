namespace LibraryApplication
{
    partial class BookReturnForm
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
            selectBookLabel = new Label();
            selectBookComboBox = new ComboBox();
            returnButton = new Button();
            returnToMainMenuButton = new Button();
            SuspendLayout();
            // 
            // selectBookLabel
            // 
            selectBookLabel.AutoSize = true;
            selectBookLabel.Location = new Point(24, 32);
            selectBookLabel.Name = "selectBookLabel";
            selectBookLabel.Size = new Size(248, 30);
            selectBookLabel.TabIndex = 0;
            selectBookLabel.Text = "Select the book to return:";
            // 
            // selectBookComboBox
            // 
            selectBookComboBox.FormattingEnabled = true;
            selectBookComboBox.Location = new Point(278, 29);
            selectBookComboBox.Name = "selectBookComboBox";
            selectBookComboBox.Size = new Size(103, 38);
            selectBookComboBox.TabIndex = 1;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(210, 115);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(108, 55);
            returnButton.TabIndex = 2;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // returnToMainMenuButton
            // 
            returnToMainMenuButton.Location = new Point(24, 210);
            returnToMainMenuButton.Name = "returnToMainMenuButton";
            returnToMainMenuButton.Size = new Size(256, 56);
            returnToMainMenuButton.TabIndex = 8;
            returnToMainMenuButton.Text = "Return to Main Menu";
            returnToMainMenuButton.UseVisualStyleBackColor = true;
            returnToMainMenuButton.Click += returnToMainMenuButton_Click;
            // 
            // BookReturnForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(553, 278);
            Controls.Add(returnToMainMenuButton);
            Controls.Add(returnButton);
            Controls.Add(selectBookComboBox);
            Controls.Add(selectBookLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "BookReturnForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Return Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selectBookLabel;
        private ComboBox selectBookComboBox;
        private Button returnButton;
        private Button returnToMainMenuButton;
    }
}