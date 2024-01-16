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

        public void Create(string tableName)
        {
            string connectionString = str.ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            if (tableName == "librarian")
            {
                List<string> list = new List<string>();

                foreach (Control control in Controls)
                {
                    if (control is TextBox textbox)
                    {
                        string data = textbox.Text;
                        list.Add(data.ToString());
                    }
                }
                MessageBox.Show(list[0], list[1]);
                string query = $"insert into librarian (firstName, lastName, userName, password, email, phoneNumber) values (@firstName, @lastName, @userName, @password, @email, @phoneNumber);";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", list[0]);
                    command.Parameters.AddWithValue("@lastName", list[1]);
                    command.Parameters.AddWithValue("@userName", list[2]);
                    command.Parameters.AddWithValue("@password", list[3]);
                    command.Parameters.AddWithValue("@email", list[4]);
                    command.Parameters.AddWithValue("@phoneNumber", list[5]);

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
                List<string> list = new List<string>();

                foreach (Control control in Controls)
                {
                    if (control is TextBox textbox)
                    {
                        string data = textbox.Text;
                        list.Add(data);
                    }
                }

            }
            else if (tableName == "cardholder")
            {
                List<string> list = new List<string>();

                foreach (Control control in Controls)
                {
                    if (control is TextBox textbox)
                    {
                        string data = textbox.Text;
                        list.Add(data);
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
