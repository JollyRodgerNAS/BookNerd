using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApplication
{
    public class CRUD : Form
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

        public async void Create(string tableName, List<string> textBoxValues)
        {

            string connectionString = str.ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            if (tableName == "librarian")
            {
                if (textBoxValues.Count > 0)
                {
                    MessageBox.Show(textBoxValues[0]);
                }
                else
                {
                    MessageBox.Show("No data entered");
                }


                string query = "insert into librarian (firstName, lastName, email, phoneNumber, userName, password) values (@firstName, @lastName, @email, @phoneNumber, @userName, @password);";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", textBoxValues[0]);
                    command.Parameters.AddWithValue("@lastName", textBoxValues[1]);
                    command.Parameters.AddWithValue("@email", textBoxValues[2]);
                    command.Parameters.AddWithValue("@phoneNumber", textBoxValues[3]);
                    command.Parameters.AddWithValue("@userName", textBoxValues[4]);
                    command.Parameters.AddWithValue("@password", textBoxValues[5]);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Success");
                    }
                    else
                    {
                        MessageBox.Show("Fail");
                    }
                }
                
            }
            else if (tableName == "book")
            {
                if (textBoxValues.Count > 0)
                {
                    MessageBox.Show(textBoxValues[0]);
                }
                else
                {
                    MessageBox.Show("No data entered");
                }

                string query = "insert into book (title, author, isCheckedOut) values (@title, @author, @isCheckedOut);";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@title", textBoxValues[0]);
                    command.Parameters.AddWithValue("@author", textBoxValues[1]);
                    command.Parameters.AddWithValue("@isCheckedOut", false);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Success");
                    }
                    else
                    {
                        MessageBox.Show("Fail");
                    }
                }



            }
            else if (tableName == "cardholder")
            {
                if (textBoxValues.Count > 0)
                {
                    MessageBox.Show(textBoxValues[0]);
                }
                else
                {
                    MessageBox.Show("No data entered");
                }

                string query = "insert into cardholder (firstName, lastName) values (@firstName, @lastName);";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", textBoxValues[0]);
                    command.Parameters.AddWithValue("@lastName", textBoxValues[1]);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Success");
                    }
                    else
                    {
                        MessageBox.Show("Fail");
                    }
                }
            }
            else
            {
                MessageBox.Show("No tablename matches");
            }
            connection.Close();

        }
    }
}
