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
        }

        private void checkoutChoiceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookCheckoutForm frm = new BookCheckoutForm();
            frm.ShowDialog();
        }
    }
}
