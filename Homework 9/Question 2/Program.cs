class Book
{
    private string Title { get; set; }
    public string Author { get; }
    public int Year { get;}

    private string Publisher { get; set; }
    public Book(string title, string author, int year, string publisher)
    {
        Title = title;
        Author = author;
        Year = year;
        Publisher = publisher;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}, Publisher: {Publisher}");
    }

    public void Input()
    {
        Console.WriteLine("Enter title:");
        Title = Console.ReadLine();
        Console.WriteLine("Enter publisher:");
        Publisher = Console.ReadLine();
    }
}

class Program
{
    public static void Main()
    {
        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, "Scribner");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 1960, "J.B. Lippincott & Co.");
        Book book3 = new Book("1984", "George Orwell", 1949, "Secker & Warburg");
        Book book4 = new Book("Pride and Prejudice", "Jane Austen", 1813, "T. Egerton");
        Book book5 = new Book("The Catcher in the Rye", "J.D. Salinger", 1951, "Little, Brown and Company");
        Book book6 = new Book("The Hobbit", "J.R.R. Tolkien", 1937, "George Allen & Unwin");
        Book book7 = new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 2025, "Bloomsbury");

        Book[] books = { book1, book2, book3, book4, book5, book6, book7 };

        foreach (Book book in books)
        {
            if (book.Year >= 2024)
            {
                book.Display();
            }
        }

        foreach (Book book in books)
        {
            if (book.Author == "J.K. Rowling")
            {
                book.Display();
            }
        }
    }
}