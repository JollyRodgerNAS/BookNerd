namespace LibraryApplication
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void enterLoginInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnOrCheckoutForm frm = new ReturnOrCheckoutForm();
            frm.ShowDialog();
        }
    }
}
