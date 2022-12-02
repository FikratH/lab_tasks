namespace Library
{
    internal class Program
    {
        public static bool isContinuing;
        static void Main(string[] args)
        {
            do
            {
                Actions();
            } while (isContinuing);
        }
        public static void Actions()
        {
            Console.WriteLine("Please, select an action: \n");
            Console.WriteLine("1. Add a book\n2. Remove a book\n3. Show all books\n4. Exit the application");
            char action = Console.ReadKey().KeyChar;
            if (action == '1')
            {
                isContinuing = true;
                Console.WriteLine("\n");
                Console.WriteLine("Please, enter a book's name:");
                string? bookName = Console.ReadLine();
                Console.WriteLine("Please, enter a book's jenre:");
                string? bookJenre = Console.ReadLine();
                Console.WriteLine("Please, enter a book's author:");
                string? bookAuthor = Console.ReadLine();
                Book book = new Book(bookName, bookJenre, bookAuthor);
            }
            else if (action == '2')
            {
                isContinuing = true;
                Console.WriteLine("\n");
                Library.RemoveBook();
            }
            else if (action == '3')
            {
                Console.WriteLine("\n");
                Library.getBooks();
            }
            else if (action == '4')
            {
                Console.WriteLine("\n");
                Console.WriteLine("Good bye!");
                isContinuing = false;
            }

        }
    }
}