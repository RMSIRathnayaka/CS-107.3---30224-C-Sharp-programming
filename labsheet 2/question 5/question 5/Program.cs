using question_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_5
{
    public class LibraryBook
    {
        public string Title;
        public string Author;
        public bool Available;

        public LibraryBook(string title, string author)
        {
            Title = title;
            Author = author;
            Available = true;
        }

        public void BorrowBook()
        {
            if(Available)
            {
                Available = false;
                Console.WriteLine($"Book '{Title}' by {Author} has been borrowed.");
            }
            else 
            {
                Console.WriteLine($"Sorry, '{Title}' by {Author} is currently not available.");
            }
        }
    }
}
public class Program
{
    static void Main()
    {
        LibraryBook book1 = new LibraryBook("The village in the jungle", "J.D Romen");
        LibraryBook book2 = new LibraryBook("The Arthur", "Arthur peiris");
        LibraryBook book3 = new LibraryBook("1984", "George Orwell");

        DisplayLibraryStatus(book1, book2, book3);

        book1.BorrowBook();
        book2.BorrowBook();
        book3.BorrowBook();

        DisplayLibraryStatus(book1, book2, book3);

        Console.ReadLine();
    }

    static void DisplayLibraryStatus(params LibraryBook[] books)
    {
        Console.WriteLine("\nLibrary Status:");

        for (int i = 0; i < books.Length; i++) 
        {
            LibraryBook book = books[i];
            Console.WriteLine($"{book.Title} by {book.Author} - Available: {book.Available}");
        }
        Console.WriteLine();
    }
}
