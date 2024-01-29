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
    public partial class BookCheckoutForm : Form
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

        private void FormLoad(object sender, EventArgs e)
        {
            AddCardholderText();
            AddBookText();
        }

        public BookCheckoutForm()
        {
            InitializeComponent();
            Load += FormLoad;
        }

        private void createBookButton_Click(object sender, EventArgs e)
        {
            List<string> textBoxValues = new List<string>
            {
                bookNameTextBox.Text,
                authorNameTextBox.Text,
            };

            string tableName = "book";
            CRUD oh = new CRUD();
            oh.Create(tableName, textBoxValues);
        }

        private void createCardholerButton_Click(object sender, EventArgs e)
        {
            List<string> textBoxValues = new List<string>
            {
                firstNameTextBox.Text,
                lastNameTextBox.Text,
            };

            string tableName = "cardholder";
            CRUD oh = new CRUD();
            oh.Create(tableName, textBoxValues);
        }

        public void AddCardholderText()
        {
            string connectionString = str.ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "select * from cardholder";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {

                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            string data = reader.GetString(1);
                            string dataDouble = reader.GetString(2);
                            string result = data + " " + dataDouble;
                            cardholderComboBox.Invoke((MethodInvoker)delegate
                            {
                                cardholderComboBox.Items.Add(result);
                                //cardholderListBox.Items.Add(dataDouble);
                            });

                            //cardholderListBox.Items.Add(data);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No records found.");
                    }
                }
            }
            connection.Close();
        }

        public void AddBookText()
        {
            string connectionString = str.ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "select * from book";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {

                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            string data = reader.GetString(1);
                            //string dataDouble = reader.GetString(2);
                            //string result = data + " " + dataDouble;
                            bookComboBox.Invoke((MethodInvoker)delegate
                            {
                                bookComboBox.Items.Add(data);
                                //cardholderListBox.Items.Add(dataDouble);
                            });

                            //cardholderListBox.Items.Add(data);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No records found.");
                    }
                }
            }
            connection.Close();
        }

        public void CheckoutBook(string cardholderFullName, string bookTitle)
        {
            string connectionString = str.ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string[] cardholderNames = cardholderFullName.Split(' ');
            string cardholderFirstName = cardholderNames[0];
            string cardholderLastName = cardholderNames.Length > 1 ? cardholderNames[1] : "";


            string query = "insert into checkouts (cardholderId, bookId) " +
                                   "values ((select id from cardholder where firstName = @cardholderFirstName and lastName = @cardholderLastName), " +
                                   "(select id from book where title = @bookTitle))";

            using (MySqlCommand checkoutCommand = new MySqlCommand(query, connection))
            {
                checkoutCommand.Parameters.AddWithValue("@cardholderFirstName", cardholderFirstName);
                checkoutCommand.Parameters.AddWithValue("@cardholderLastName", cardholderLastName);
                checkoutCommand.Parameters.AddWithValue("@bookTitle", bookTitle);

                int rowsAffected = checkoutCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book checked out successfully.");

                    
                    string updateQuery = "update book set isCheckedOut = true where title = @bookTitle";

                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@bookTitle", bookTitle);

                        int updateRowsAffected = updateCommand.ExecuteNonQuery();

                        if (updateRowsAffected > 0)
                        {
                            MessageBox.Show("Book status updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Error updating book status.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error checking out the book.");
                }
            }
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            string selectedCardholder = cardholderComboBox.SelectedItem.ToString();
            string selectedBook = bookComboBox.SelectedItem.ToString();

            
            CheckoutBook(selectedCardholder, selectedBook);
        }
    }
}
