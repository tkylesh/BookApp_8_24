using System;
using System.Collections.Generic;

namespace BookApp_8_24
{
    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Kurt Vonnegut jr.", "slaughterhouse five", new DateTime(1, 12, 1999), 275);

            Book book2 = new("James Clear", "atomic habits", new DateTime(10, 16, 2018), 319);

            Book book3 = new Book("Kurt Vonnegut jr.", "Cats Cradle", new DateTime(12, 12, 1999), 179);

            List<Book> bookList = new();

            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);

            foreach (Book book in bookList)
            {
                Console.WriteLine(book.ListTitleAuthor);
            }
        }
    }

    public class Book
    {
        public Book(string author, string title, DateTime publishDate, int numberOfPages)
        {
            Author = author;
            Title = title;
            PublishDate = publishDate;
            NumberOfPages = numberOfPages;
        }
        public string Author { get; set; }

        public string Title { get; set; }

        public DateTime PublishDate { get; set; }

        public int NumberOfPages { get; set; }

        public string ListTitleAuthor
        {
            get
            {
                return $"{Title} - by {Author}";
            }
        }
    }
}
