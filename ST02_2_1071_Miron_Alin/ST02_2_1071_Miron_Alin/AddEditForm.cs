using ST02_2_1071_Miron_Alin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST02_2_1071_Miron_Alin
{
    public partial class AddEditForm : Form
    {
        public Book Book { get; set; }
        public AddEditForm()
        {
            InitializeComponent();
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            if (Book != null)
            {
                tbBookTitle.Text = Book.BookTitle;
                nudBookPages.Value = Book.BookPages;
                dtpBookReleaseDate.Value = Book.BookReleaseDate;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Book != null)
            {
                Book.BookTitle = tbBookTitle.Text;
                Book.BookPages = (int)nudBookPages.Value;
                Book.BookReleaseDate = dtpBookReleaseDate.Value;
            }
        }

        private void tbBookTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbBookTitle.Text.Trim()))
            {
                e.Cancel = true;
                epBookTitile.SetError((Control)sender, "Name is empty!");
            }
        }

        private void tbBookTitle_Validated(object sender, EventArgs e)
        {
            epBookTitile.SetError((Control)sender, string.Empty);
        }
        private void nudBookPages_Validating(object sender, CancelEventArgs e)
        {
            if (nudBookPages.Value == 0)
            {
                e.Cancel = true;
                epBookPages.SetError((Control)sender, "Pages can't be 0");
            }
        }
        private void nudBookPages_Validated(object sender, EventArgs e)
        {
            epBookPages.SetError((Control)sender, string.Empty);
        }


    }
}
