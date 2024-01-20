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
        public BookCheckoutForm()
        {
            InitializeComponent();
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
    }
}
