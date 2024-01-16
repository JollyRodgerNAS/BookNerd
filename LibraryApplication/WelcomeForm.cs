using MySql.Data.MySqlClient;

namespace LibraryApplication
{
    public partial class WelcomeForm : Form
    {
        /*MySqlConnectionStringBuilder str = new MySqlConnectionStringBuilder()
        {
            Server = "localhost",
            Port = 3306,
            Database = "library_database",
            UserID = "test",
            Password = "test123",
            SslMode = MySqlSslMode.None
        };*/


        public WelcomeForm()
        {
            InitializeComponent();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //string connectionString = str.ConnectionString;
            //MySqlConnection connection = new MySqlConnection(connectionString);
            /*MySqlDataReader reader;
            string query = "select * from data where username = '" + usernameTextBox.Text + "'and password = '" + passwordTextBox.Text + "'";
            MySqlCommand command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();*/
            try
            {
                //connection.Open();

                if (usernameTextBox.Text != "" && passwordTextBox.Text != "")
                {
                    MessageBox.Show("worked");
                    /*if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string first = reader["firstName"].ToString();

                            MessageBox.Show($"{first}");
                        }
                    }*/
                }
                else
                {
                    MessageBox.Show("Enter username and password into fields");
                }
                //connection.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            /*this.Hide();
            ReturnOrCheckoutForm frm = new ReturnOrCheckoutForm();
            frm.ShowDialog();*/
        }

        private void createNewLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateNewLibrarianForm frm = new CreateNewLibrarianForm();
            frm.ShowDialog();
        }
    }
}
