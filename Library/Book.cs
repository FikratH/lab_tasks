using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{

    internal class Book
    {
        public string? Name { get; set; }
        public string? Genre { get; set; }
        public string? Author { get; set; }

        public Book(string? name, string? genre, string? author)
        {
            Name = name;
            Genre = genre;
            Author = author;
            Library.AddBook(this);
        }
        public override string ToString()
        {
            return $"{Name}, {Genre}, {Author}";
        }
    }
}
