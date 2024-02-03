using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApplication
{
    public partial class CreateNewLibrarianForm : Form
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
        public CreateNewLibrarianForm()
        {
            InitializeComponent();
        }

        private void CreateNewLibrarianForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createNewButton_Click(object sender, EventArgs e)
        {
            string connectionString = str.ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            List<string> textBoxValues = new List<string>
            {
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                emailTextBox.Text,
                phoneNumberTextBox.Text,
                usernameTextBox.Text,
                passwordTextBox.Text
            };

            string tableName = "librarian";
            CRUD oh = new CRUD();

            string query = "select userName, password from librarian where " +
                "userName = @userName and password = @password;";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userName", textBoxValues[4]);
                command.Parameters.AddWithValue("@password", textBoxValues[5]);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Username already exists!");
                    }
                    else
                    {
                        oh.Create(tableName, textBoxValues);
                    }
                }
            }
        }
    }
}
