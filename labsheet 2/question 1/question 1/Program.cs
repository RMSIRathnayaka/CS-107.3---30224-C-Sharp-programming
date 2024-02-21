using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an object of the Book class
            Book myBook = new Book();

            // Set values for the properties
            myBook.Title = "The Great Gatsby";
            myBook.Author = "F. Scott Fitzgerald";

            // Display the information on the console
            Console.WriteLine("Title: " + myBook.Title);
            Console.WriteLine("Author: " + myBook.Author);

            Console.ReadLine();
        }

    }
}