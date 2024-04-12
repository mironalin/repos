using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST02_2_1071_Miron_Alin.Entities
{
    [Serializable]
    public class Book : IComparable<Book>
    {
        public string BookTitle { get; set; }
        public int BookPages { get; set; }
        public DateTime BookReleaseDate { get; set; }

        public Book()
        {
            BookReleaseDate = DateTime.Now;
        }

        public Book(string bookTitle, int bookPages, DateTime bookReleaseDate) : this()
        {
            BookTitle = bookTitle;
            BookPages = bookPages;
            BookReleaseDate = bookReleaseDate;
        }

        public int CompareTo(Book other)
        {
            return BookPages.CompareTo(other.BookPages);
        }
    }
}
