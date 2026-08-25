// Create a Library management program using Partial Classes. Split the Book class into two files. In the first file,
// declare the properties Book ID, Title, and Author, and in the second file, implement methods to issue a book, return
// a book, and display book details. Demonstrate the functionality by creating objects and calling the appropriate methods.

using System;

namespace ConsoleApp15{
    public partial class Book{
        public int BookId;
        public string Title;
        public string Author;

        public Book(int bookId, string title, string author){
            this.BookId= bookId;
            this.Title = title;
            this.Author = author;
        }
    }

    public class Program{
        static void Main(string[] args){
            Book b1 = new Book(101, "The Riddler", "Paul Dano");
            b1.IssueBook();
            b1.ReturnBook();
            b1.BookDetails();
        }
    }
}