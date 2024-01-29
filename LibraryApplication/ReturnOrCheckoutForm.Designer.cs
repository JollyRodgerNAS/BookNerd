namespace LibraryApplication
{
    partial class ReturnOrCheckoutForm
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
            optionLabel = new Label();
            checkoutChoiceButton = new Button();
            returnChoiceButton = new Button();
            bookViewerButton = new Button();
            SuspendLayout();
            // 
            // optionLabel
            // 
            optionLabel.AutoSize = true;
            optionLabel.Location = new Point(39, 23);
            optionLabel.Name = "optionLabel";
            optionLabel.Size = new Size(508, 30);
            optionLabel.TabIndex = 0;
            optionLabel.Text = "Choose whether to return a book or checkout a book:";
            // 
            // checkoutChoiceButton
            // 
            checkoutChoiceButton.Location = new Point(169, 84);
            checkoutChoiceButton.Name = "checkoutChoiceButton";
            checkoutChoiceButton.Size = new Size(237, 61);
            checkoutChoiceButton.TabIndex = 1;
            checkoutChoiceButton.Text = "Checkout";
            checkoutChoiceButton.UseVisualStyleBackColor = true;
            checkoutChoiceButton.Click += checkoutChoiceButton_Click;
            // 
            // returnChoiceButton
            // 
            returnChoiceButton.Location = new Point(169, 161);
            returnChoiceButton.Name = "returnChoiceButton";
            returnChoiceButton.Size = new Size(237, 66);
            returnChoiceButton.TabIndex = 2;
            returnChoiceButton.Text = "Return";
            returnChoiceButton.UseVisualStyleBackColor = true;
            returnChoiceButton.Click += returnChoiceButton_Click;
            // 
            // bookViewerButton
            // 
            bookViewerButton.Location = new Point(169, 242);
            bookViewerButton.Name = "bookViewerButton";
            bookViewerButton.Size = new Size(237, 69);
            bookViewerButton.TabIndex = 3;
            bookViewerButton.Text = "View";
            bookViewerButton.UseVisualStyleBackColor = true;
            bookViewerButton.Click += bookViewerButton_Click;
            // 
            // ReturnOrCheckoutForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(608, 343);
            Controls.Add(bookViewerButton);
            Controls.Add(returnChoiceButton);
            Controls.Add(checkoutChoiceButton);
            Controls.Add(optionLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ReturnOrCheckoutForm";
            Text = "Return or Checkout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label optionLabel;
        private Button checkoutChoiceButton;
        private Button returnChoiceButton;
        private Button bookViewerButton;
    }
}