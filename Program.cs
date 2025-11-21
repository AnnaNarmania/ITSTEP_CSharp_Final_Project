using System;

class Program
{
    static void Main(string[] args)
    {
        BookManager library = new BookManager();
        bool viewing = true;

        while (viewing)
        {
            Console.WriteLine("Library Menu Options:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Show All Books");
            Console.WriteLine("3. Search Book by Title");
            Console.WriteLine("4. Exit");
            Console.Write("Select a number from 1-4: ");

            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.Write("Enter Book Title: ");
                string title;

                do
                {
                    title = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(title))
                    {
                        Console.Write("Title cannot be empty. Please enter a valid title: ");
                    }
                } while (string.IsNullOrWhiteSpace(title));

                Console.Write("Enter Book Author: ");
                string author;

                do
                {
                    author = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(author))
                    {
                        Console.Write("Author cannot be empty. Please enter a valid author: ");
                    }
                } while (string.IsNullOrWhiteSpace(author));

                Console.Write("Enter Year Published: ");
                int yearPublished;

                while (!int.TryParse(Console.ReadLine(), out yearPublished))
                {
                    Console.Write("Invalid input. Please enter a valid year: ");
                }

                Book newBook = new Book(title, author, yearPublished);
                library.AddBook(newBook);
            }
            else if (option == "2")
            {
                library.ShowAllBooks();
            }
            else if (option == "3")
            {
                Console.Write("Enter the title to search: ");
                string searchTitle = Console.ReadLine();
                library.SearchByTitle(searchTitle);
            }
            else if (option == "4")
            {
                viewing = false;
                Console.WriteLine("Exiting the program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please select a number between 1 and 4.");
            }
            
            
        }
    }
}