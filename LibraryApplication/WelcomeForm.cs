using MySql.Data.MySqlClient;

namespace LibraryApplication
{
    public partial class WelcomeForm : Form
    {
        MySqlConnectionStringBuilder str = new MySqlConnectionStringBuilder()
        {
            Server = "localhost",
            Port = 3306,
            Database = "library_database",
            UserID = "test",
            Password = "test123",
            SslMode = MySqlSslMode.Disabled
        };
        public WelcomeForm()
        {
            InitializeComponent();
            this.FormClosing += ExitApplication;

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string connectionString = str.ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            try
            {
                if (usernameTextBox.Text != "" && passwordTextBox.Text != "")
                {
                    string userName = usernameTextBox.Text;
                    string password = passwordTextBox.Text;

                    string query = "select userName, password from librarian where " +
                        "userName = @userName and password = @password;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userName", userName);
                        command.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Login successful!");
                                this.Hide();
                                ReturnOrCheckoutForm frm = new ReturnOrCheckoutForm();
                                frm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Username or password is incorrect!");
                            }
                        }
                    }
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
        }

        private void createNewLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateNewLibrarianForm frm = new CreateNewLibrarianForm();
            frm.ShowDialog();
        }

        private void ExitApplication(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
