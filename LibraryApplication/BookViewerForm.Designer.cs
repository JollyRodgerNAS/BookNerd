namespace LibraryApplication
{
    partial class BookViewerForm
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
            headerLabel = new Label();
            cardholderListBox = new ListBox();
            bookListBox = new ListBox();
            viewButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(776, 30);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Select cardholer on left and hit button to view books checked out to them on right";
            // 
            // cardholderListBox
            // 
            cardholderListBox.BorderStyle = BorderStyle.FixedSingle;
            cardholderListBox.FormattingEnabled = true;
            cardholderListBox.ItemHeight = 30;
            cardholderListBox.Location = new Point(12, 90);
            cardholderListBox.Name = "cardholderListBox";
            cardholderListBox.Size = new Size(273, 242);
            cardholderListBox.TabIndex = 1;
            // 
            // bookListBox
            // 
            bookListBox.BorderStyle = BorderStyle.FixedSingle;
            bookListBox.FormattingEnabled = true;
            bookListBox.ItemHeight = 30;
            bookListBox.Location = new Point(533, 90);
            bookListBox.Name = "bookListBox";
            bookListBox.Size = new Size(244, 242);
            bookListBox.TabIndex = 2;
            // 
            // viewButton
            // 
            viewButton.Location = new Point(339, 378);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(116, 54);
            viewButton.TabIndex = 3;
            viewButton.Text = "View";
            viewButton.UseVisualStyleBackColor = true;
            // 
            // BookViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(789, 474);
            Controls.Add(viewButton);
            Controls.Add(bookListBox);
            Controls.Add(cardholderListBox);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "BookViewerForm";
            Text = "Book Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ListBox cardholderListBox;
        private ListBox bookListBox;
        private Button viewButton;
    }
}