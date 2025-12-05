class BookManager
{ 
    // წიგნების სია, რომელიც შეიცავს Book ობიექტებს
    private List<Book> books;

    // კონსტრუქტორი, რომლითაც ვქმნით ცარიელ წიგნების სიას
    public BookManager()
    {
        books = new List<Book>();
    }

    // მეთოდი წიგნის დამატებისთვის
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Book added successfully.");
    }

    public void ShowAllBooks()
    {
        // თუ წიგნების სია ცარიელია, ვაჩვენებთ შეტყობინებას და ვასრულებთ მეთოდს და if ბლოკის შემდეგ დაწერილი კოდი აღარ შესრულდება
        if (books.Count==0)
        {
            Console.WriteLine("No books available.");
            return;
        }
        
        // თუ წიგნების სია არ არის ცარიელი, ვპრინტავთ ყვეკლა წიგნს
        for(int i = 0; i<books.Count; i++)
        {
            Console.Write($"Book{i+1}: ");

            // ვიძახებთ Book კლასის ShowInfo მეთოდს, რომელიც პრინტავს წიგნის ინფორმაციას
            books[i].ShowInfo();
        }

    }

    public void SearchByTitle(string title)
    {
       // ვეძებთ წიგნებს სათაურის მიხედვით და გადავაქცევთ ლისტად, OriginalIgnoreCase საშუალებას გვაძლევს, რომ დავაიგნოროთ დიდი და პატარა ასოები, გავამარტივოთ ძებნა
       var foundBooks = books.Where(b => b.GetTitle().Equals(title, StringComparison.OrdinalIgnoreCase)).ToList();
       
       // თუ ნაპოვნი წიგნების სია არის ცარიელი, ვაჩვენებთ შეტყობინებას და ვასრულებთ მეთოდს და if ბლოკის შემდეგ დაწერილი კოდი აღარ შესრულდება
       if(foundBooks.Count == 0)
        {
            Console.WriteLine("No books found with the given title.");
            return;
        }
 
        // თუ ნაპოვნი წიგნების სია არ არის ცარიელი, ვპრინტავთ ყველა ნაპოვნ წიგნს
        Console.WriteLine($"Found {foundBooks.Count} with the title '{title}':");
        foreach(var book in foundBooks)
        {
             book.ShowInfo();
        }  

    }




}