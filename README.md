# Library Console Application

## Overview
This is a **C# console application** that allows users to manage a list of books. The application demonstrates basic **object-oriented programming (OOP)** concepts such as classes, objects, and encapsulation.  

This project was completed as the **final project** of IT STEP Academy's course **"Programming: C# and Unity"**, concluding the C# part of the course.

---

## Features
The program allows users to:

1. **Add a new book**  
   - Enter the book’s title, author, and publication year.  
   - Validates that the title and author are not empty, and that the year is a number.

2. **View all books**  
   - Displays all books in the library with their details.

3. **Search a book by title**  
   - Searches books case-insensitively by title and displays matching results.

4. **Exit the program**  

---

## Classes

### `Book`
- Represents a book with the following private properties:
  - `Title`  
  - `Author`  
  - `YearPublished`  
- Methods:
  - `ShowInfo()` → displays book details  
  - `GetTitle()` → returns the title (used for searching)

### `BookManager`
- Manages the list of books.
- Methods:
  - `AddBook(Book book)` → adds a book to the library  
  - `ShowAllBooks()` → displays all books  
  - `SearchByTitle(string title)` → searches books by title  

---

## How to Run
1. Open the solution in Visual Studio.  
2. Build and run the project.  
3. Use the console menu to:
   - Add books  
   - View all books  
   - Search books by title  
   - Exit the application  
