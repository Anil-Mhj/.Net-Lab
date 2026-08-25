// Create a Library Management System using the Dictionary<TKey, TValue> collection. Store
// the Book ID as the key and the Book Title as the value. Implement features to add books, search
// for a book using its ID, update book information, remove a book, and display all available books.

using System;

namespace ConsoleApp5
{
    class Program
    {
        static void DisplayBooks(Dictionary<int, string> books)
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            Console.WriteLine("\nAvailable Books:");
            foreach (KeyValuePair<int, string> book in books)
            {
                Console.WriteLine($"Book ID: {book.Key}, Title: {book.Value}");
            }
        }

        static void AddBook(Dictionary<int, string> books)
        {
            Console.Write("Enter Book ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (books.ContainsKey(id))
            {
                Console.WriteLine("Book ID already exists.");
                return;
            }

            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();

            books.Add(id, title);
            Console.WriteLine("Book added successfully.");
        }

        static void SearchBook(Dictionary<int, string> books)
        {
            Console.Write("Enter Book ID to search: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (books.ContainsKey(id))
            {
                Console.WriteLine($"Book Found");
                Console.WriteLine($"Book ID: {id}");
                Console.WriteLine($"Title: {books[id]}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        static void UpdateBook(Dictionary<int, string> books)
        {
            Console.Write("Enter Book ID to update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (books.ContainsKey(id))
            {
                Console.Write("Enter New Book Title: ");
                books[id] = Console.ReadLine();

                Console.WriteLine("Book updated successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        static void RemoveBook(Dictionary<int, string> books)
        {
            Console.Write("Enter Book ID to remove: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (books.ContainsKey(id))
            {
                books.Remove(id);
                Console.WriteLine("Book removed successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        static void Main(string[] args)
        {
            Dictionary<int, string> books = new Dictionary<int, string>();
            books.Add(101, "C# Programming");
            books.Add(102, "Data Structures");
            books.Add(103, "Database Management");
            books.Add(104, "Operating Systems");
            books.Add(105, "Computer Networks");
            int choice;
            do
            {
                Console.WriteLine("\n===== Library Management System =====");
                Console.WriteLine("1. Display All Books");
                Console.WriteLine("2. Add Book");
                Console.WriteLine("3. Search Book");
                Console.WriteLine("4. Update Book");
                Console.WriteLine("5. Remove Book");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayBooks(books);
                        break;

                    case 2:
                        AddBook(books);
                        break;

                    case 3:
                        SearchBook(books);
                        break;

                    case 4:
                        UpdateBook(books);
                        break;

                    case 5:
                        RemoveBook(books);
                        break;

                    case 6:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

            } while (choice != 6);
        }
    }
}