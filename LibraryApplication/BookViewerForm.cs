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
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (cardholderListBox.SelectedItem != null)
            {
                string selectedName = cardholderListBox.SelectedItem.ToString();

                string[] nameParts = selectedName.Split(' ');

                if (nameParts.Length >= 2)
                {
                    string firstName = nameParts[0];
                    string lastName = nameParts[1];

                    string tableName = "cardholder";
                    CRUD oh = new CRUD();
                    //oh.Read(tableName, firstName, lastName);
                    bookListBox.Items.Add(oh.Read(tableName,firstName,lastName));

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
    }
}
