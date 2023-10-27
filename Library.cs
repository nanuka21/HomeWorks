using System;
namespace LibrarySystemProject
{
	public class Library
	{
		public Library()
		{
		}

		private List<Book1> books = new List<Book1>();

		public void AddBook(Book1 book)
		{

			books.Add(book);

		}

		public void RemoveBook(Book1 book)
		{

			books.Remove(book);

		}

		public int Count
		{
			get { return books.Count; }
		}


		public List<Book1> FindBooks(string Title)
		{
			var matchingBooks = books.Where(b => b.Title == Title).ToList();
			return matchingBooks;
		}


		public void PrintBookTitleAuthor(Book1 book)
		{
			Console.WriteLine($"{book.Author}+{book.Title}");
		}

	}
}

