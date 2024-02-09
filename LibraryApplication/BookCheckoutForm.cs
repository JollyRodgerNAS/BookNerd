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
            this.FormClosing += ExitApplication;
        }

        private void createBookButton_Click(object sender, EventArgs e)
        {
            string connectionString = str.ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            List<string> textBoxValues = new List<string>
            {
                bookNameTextBox.Text,
                authorNameTextBox.Text,
            };

            string tableName = "book";
            CRUD oh = new CRUD();

            string query = "select title, author from book where title = @title and author = @author;";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("title", textBoxValues[0]);
                command.Parameters.AddWithValue("author", textBoxValues[1]);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Book already exists!");
                    }
                    else
                    {
                        oh.Create(tableName, textBoxValues);
                    }
                }
            }
            connection.Close();
        }

        private void createCardholerButton_Click(object sender, EventArgs e)
        {
            string connectionString = str.ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            List<string> textBoxValues = new List<string>
            {
                firstNameTextBox.Text,
                lastNameTextBox.Text,
            };

            string tableName = "cardholder";
            CRUD oh = new CRUD();

            string query = "select firstName, lastName from cardholder where " +
                "firstName = @firstName and lastName = @lastName;";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@firstName", textBoxValues[0]);
                command.Parameters.AddWithValue("@lastName", textBoxValues[1]);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Cardholder already exists!");
                    }
                    else
                    {
                        oh.Create(tableName, textBoxValues);
                    }
                }
            }
            connection.Close();
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
                            });
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

            string query = "select * from book where isCheckedOut = 0;";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string data = reader.GetString(1);
                            bookComboBox.Invoke((MethodInvoker)delegate
                            {
                                bookComboBox.Items.Add(data);
                            });
                        }
                    }
                    else
                    {

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
                                   "values ((select id from cardholder where " +
                                   "firstName = @cardholderFirstName and lastName = @cardholderLastName), " +
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
            connection.Close();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            string connectionString = str.ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string selectedCardholder = cardholderComboBox.SelectedItem.ToString();
            string selectedBook = bookComboBox.SelectedItem.ToString();

            bookComboBox.Items.Remove(selectedBook);
            bookComboBox.ResetText();

            CheckoutBook(selectedCardholder, selectedBook);
        }

        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnOrCheckoutForm frm = new ReturnOrCheckoutForm();
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
