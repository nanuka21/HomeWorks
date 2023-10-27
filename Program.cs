using System;
namespace LibrarySystemProject
{
    class program
    {

        static void Main(string[] args)
        {
            Library library = new Library();

            Book1 book1 = new Book1();
            book1.Author = "stephenie";
            book1.Title = "Twilight";
            book1.Year = 2000;


            Book1 book2 = new Book1();
            book2.Author = "Joanne";
            book2.Title = "Harry Poter";
            book2.Year = 1989;


            library.AddBook(book1);
            library.AddBook(book2);

            Console.WriteLine($"Books in the library:{library.Count}");

            library.PrintBookTitleAuthor(book1);

            List<Book1> foundbooks = library.FindBooks("Twilight");

            if (foundbooks.Count > 0)
            {
                Console.WriteLine("Books with title 'Book1':");
                foreach (var book in foundbooks)
                {
                    Console.WriteLine($"{book.Title}({book.Year}) published by {book.Author}");
                }
            }
            else
            {
                Console.WriteLine($"No books found");
            }
            }












        }


    }

