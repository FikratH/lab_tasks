using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Library
    {
        public static Book[] books = new Book[0];
        public static void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
            Console.WriteLine("The book was successfully added to the library!\n");

        }
        public static void RemoveBook()
        {
            Console.WriteLine("Please, select a book to remove:");
            foreach (Book book in books)
            {
                int index = Array.IndexOf(books, book)+1;
                Console.WriteLine($"{index}. {book}");
            }
            int indexToRemove = Convert.ToInt32(Console.ReadLine()) - 1;
            Array.Clear(books, indexToRemove, 1);
            foreach (Book book in books) //{0,--,2,3}
            {
                if (indexToRemove<Array.IndexOf(books,book))
                {
                    books[Array.IndexOf(books,book)-1] = book;
                }
            }
            Array.Resize(ref books, books.Length- 1);
            Console.WriteLine("\n");
        }

        public static void getBooks()
        {
            Console.WriteLine("Library:");
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("\n");
        }
    }
}
