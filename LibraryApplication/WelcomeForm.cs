using MySql.Data.MySqlClient;

namespace LibraryApplication
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (usernameTextBox.Text != "" && passwordTextBox.Text != "")
                {
                    MessageBox.Show("worked");
                }
                else
                {
                    MessageBox.Show("Enter username and password into fields");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            this.Hide();
            ReturnOrCheckoutForm frm = new ReturnOrCheckoutForm();
            frm.ShowDialog();
        }

        private void createNewLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateNewLibrarianForm frm = new CreateNewLibrarianForm();
            frm.ShowDialog();
        }
    }
}
