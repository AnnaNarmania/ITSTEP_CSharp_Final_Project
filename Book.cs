class Book
{
    // წიგნის properties
    private string Title { get; set; }
    private string Author { get; set; }
    private int YearPublished { get; set; } 

    // კონსტრუქტორი, რომლითაც ვქმნით წიგნის ობიექტს
    public Book(string title, string author, int yearPublished)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
    }

    // მეთოდი, რომელიც პრინტავს წიგნის ინფორმაციას
    public void ShowInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Year Published: {YearPublished}");
    }

    // მეთოდი, რომელიც აბრუნებს წიგნის სათაურს, BookManager-ში Linq-ისთვის გვჭირდება
    public string GetTitle()
    {
        return Title;
    }
}