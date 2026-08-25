// Create a BookCollection class that stores details of multiple books using an array or list. Implement an Indexer to
// access book titles by their index position. Display all stored book titles and allow the user to search for a book using
// its index.

using System;

namespace ConsoleApp21
{
    class BookCollection
    {
        private string[] books;

        public BookCollection(string[] bookTitles)
        {
            books = bookTitles;
        }

        public string this[int index]
        {
            get
            {
                return books[index];
            }
            set
            {
                books[index] = value;
            }
        }
        public void DisplayBooks()
        {
            Console.WriteLine("Book List:");

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{books[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating book collection
            string[] bookTitles =
            {
                "The Alchemist",
                "Harry Potter",
                "The Hobbit",
                "Atomic Habits",
                "Clean Code"
            };

            BookCollection collection = new BookCollection(bookTitles);
            collection.DisplayBooks();
            Console.Write("\nEnter book index to search: ");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index >= 0 && index < bookTitles.Length)
            {
                Console.WriteLine($"Book at index {index}: {collection[index]}");
            }
            else
            {
                Console.WriteLine("Invalid index!");
            }
        }
    }
}