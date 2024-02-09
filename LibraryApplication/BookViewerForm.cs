using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApplication
{
    public partial class BookViewerForm : Form
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
            AddText();
        }
        public BookViewerForm()
        {
            InitializeComponent();
            Load += FormLoad;
            this.FormClosing += ExitApplication;
        }

        public void AddText()
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
                            cardholderListBox.Invoke((MethodInvoker)delegate
                            {
                                cardholderListBox.Items.Add(result);
                            });
                        }
                    }
                    else
                    {
                        MessageBox.Show("No records found.");
                    }
                }
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            string connectionString = str.ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            List<string> searchResults = [];

            bookListBox.Items.Clear();
            if (cardholderListBox.SelectedItem != null)
            {
                string selectedName = cardholderListBox.SelectedItem.ToString();

                string[] nameParts = selectedName.Split(' ');

                if (nameParts.Length >= 2)
                {
                    string firstName = nameParts[0];
                    string lastName = nameParts[1];

                    string query = "select book.title " +
                               "from checkouts " +
                               "inner join book on checkouts.bookId = book.id " +
                               "inner join cardholder on checkouts.cardholderId = cardholder.id " +
                               "where cardholder.firstName = @firstName and cardholder.lastName = @lastName";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show($"Books checked out to {firstName} {lastName}:");
                                while (reader.Read())
                                {
                                    string bookTitle = reader.GetString("title");
                                    searchResults.Add(bookTitle);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No books checked out");
                            }
                        }
                    }
                    for (int i = 0; i < searchResults.Count; i++)
                    {
                        bookListBox.Items.Add(searchResults[i]);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid name format");
                }
            }
            else
            {
                MessageBox.Show("No item selected");
            }
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
