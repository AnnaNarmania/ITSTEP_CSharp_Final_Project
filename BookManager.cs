class BookManager
{
    private List<Book> books;

    public BookManager()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Book added successfully.");
    }

    public void ShowAllBooks()
    {
        if (books.Count==0)
        {
            Console.WriteLine("No books available.");
            return;
        }

        for(int i = 0; i<books.Count; i++)
        {
            Console.Write($"Book{i+1}: ");
            books[i].ShowInfo();
        }

    }

    public void SearchByTitle(string title)
    {
       var foundBooks = books.Where(b => b.GetTitle().Equals(title, StringComparison.OrdinalIgnoreCase)).ToList();
       
       if(foundBooks.Count == 0)
        {
            Console.WriteLine("No books found with the given title.");
            return;
        }

        Console.WriteLine($"Found {foundBooks.Count} with the title '{title}':");
        foreach(var book in foundBooks)
        {
             book.ShowInfo();
        }  

    }




}