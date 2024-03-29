﻿using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class BookReturnForm : Form
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
            AddBookText();
        }
        public BookReturnForm()
        {
            InitializeComponent();
            Load += FormLoad;
            this.FormClosing += ExitApplication;
        }

        public void AddBookText()
        {
            string connectionString = str.ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            List<string> search = [];

            string query = "select title from book where isCheckedOut = 1;";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string results = reader.GetString("title");
                            search.Add(results);
                        }
                    }
                }
            }

            for (int i = 0; i < search.Count; i++)
            {
                selectBookComboBox.Items.Add(search[i]);
            }

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            string tablename = "book";
            string book = selectBookComboBox.SelectedItem.ToString();
            CRUD oh = new CRUD();
            oh.Delete(tablename, book);
            oh.Update(tablename, book, "");

            selectBookComboBox.Items.Remove(selectBookComboBox.SelectedItem);
            selectBookComboBox.ResetText();
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
