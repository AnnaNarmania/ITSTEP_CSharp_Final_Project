using System;

class Program
{
    static void Main(string[] args)
    {
        // შევქმნათ BookManager ობიექტი
        BookManager library = new BookManager();

        // boolean ცვლადი, რომელიც განსაზღვრავს ლუპის მოქმედებას
        bool viewing = true;

        while (viewing)
        {
            // ვპრინტავთ სხვადასხვა მოქმედების ვარიანტს
            Console.WriteLine("Library Menu Options:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Show All Books");
            Console.WriteLine("3. Search Book by Title");
            Console.WriteLine("4. Exit");
            Console.Write("Select a number from 1-4: ");

            // ვკითხულობთ მომხმარებლის მიერ არჩეულ ვარიანტს
            string option = Console.ReadLine();
 
            // წიგნის დამატება
            if (option == "1")
            {
                Console.Write("Enter Book Title: ");
                string title;
                
                // ჯერ ვანიჭებთ მნიშვნელობას, შემდეგ ვამოწმებთ ცარიელი არის თუ არა, თუ არის, თავიდან ვთხოვთ მომხმარებელს სათაურის შეყვანას
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

                // იგივე პროცედურა ავტორისთვის, რაც სათაურისთვის
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

                // სანამ int.TryParse არ დააბრუნებს true-ს, ვთხოვთ მომხმარებელს სწორი რიცხვის შეყვანას
                while (!int.TryParse(Console.ReadLine(), out yearPublished))
                {
                    Console.Write("Invalid input. Please enter a valid year: ");
                }
                
                // ვქმნით ახალ წიგნს
                Book newBook = new Book(title, author, yearPublished);

                // BookManager-ის წიგნის დამატების მეთოდით ვამატებთ წიგნს ბიბლიოთეკაში
                library.AddBook(newBook);
            }

            // ყველა წიგნის ჩვენება
            else if (option == "2")
            {
                library.ShowAllBooks();
            }

            // წიგნის ძებნა სათაურის მიხედვით
            else if (option == "3")
            {
                Console.Write("Enter the title to search: ");
                string searchTitle = Console.ReadLine();
                library.SearchByTitle(searchTitle);
            }

            // პროგრამიდან გამოსვლა
            else if (option == "4")
            {
                viewing = false;
                Console.WriteLine("Exiting the program. Goodbye!");
            }

            // არასწორი ვარიანტის შეყვანის შემთხვევაში
            else
            {
                Console.WriteLine("Invalid option. Please select a number between 1 and 4.");
            }
            
            
        }
    }
}