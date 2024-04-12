using ST02_2_1071_Miron_Alin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST02_2_1071_Miron_Alin
{
    public partial class MainForm : Form
    {
        private Library Library { get; set; }
        public MainForm()
        {
            Library = new Library();
            InitializeComponent();
        }
        private void DisplayBooks()
        {
            lvLibary.Items.Clear();
            Library.Books.Sort();
            foreach (var book in Library.Books)
            {
                ListViewItem lvi = new ListViewItem(book.BookTitle);
                lvi.SubItems.Add(book.BookPages.ToString());
                lvi.SubItems.Add(book.BookReleaseDate.ToString());
                lvi.Tag = book;
                lvLibary.Items.Add(lvi);
            }
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddEditForm form = new AddEditForm();
            Book book = new Book();
            form.Book = book;

            if (form.ShowDialog() == DialogResult.OK)
            {
                Library.Books.Add(book);
                DisplayBooks();
            }
        }

        private void lvLibrary_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddEditForm form = new AddEditForm();
            if (lvLibary.SelectedItems.Count == 1)
            {
                Book book = lvLibary.SelectedItems[0].Tag as Book;
                form.Book = book;
                
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DisplayBooks();
                }
            }
        }

        private void serializeBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Create(sfd.FileName))
                {
                    bf.Serialize(fs, Library);
                }
            }
        }

        private void deserializeBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            OpenFileDialog ofd = new OpenFileDialog();
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using(FileStream fs = File.OpenRead(ofd.FileName))
                {
                    Library = (Library)bf.Deserialize(fs);
                    DisplayBooks();
                }
            }
        }
    }
}
