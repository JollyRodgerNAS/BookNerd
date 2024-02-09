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
    public partial class ReturnOrCheckoutForm : Form
    {
        public ReturnOrCheckoutForm()
        {
            InitializeComponent();
            this.FormClosing += ExitApplication;
        }

        private void checkoutChoiceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookCheckoutForm frm = new BookCheckoutForm();
            frm.ShowDialog();
        }

        private void bookViewerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookViewerForm frm = new BookViewerForm();
            frm.ShowDialog();
        }

        private void returnChoiceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookReturnForm frm = new BookReturnForm();
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
