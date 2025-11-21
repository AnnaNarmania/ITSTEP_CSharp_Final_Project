class Book
{
    private string Title { get; set; }
    private string Author { get; set; }
    private int YearPublished { get; set; } 

    public Book(string title, string author, int yearPublished)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Year Published: {YearPublished}");
    }

    public string GetTitle()
    {
        return Title;
    }
}