namespace Lab15{
    public partial class Book{
    public void IssueBook(){
        Console.WriteLine("Book issued successfully!");        
    }

    public void ReturnBook(){
        Console.WriteLine("Book returned successfully!");
    }

    public void BookDetails(){
        Console.WriteLine($"Book ID: {this.BookId}");
        Console.WriteLine($"Title: {this.Title}");
        Console.WriteLine($"Author: {this.Author}");
    }
    }
}