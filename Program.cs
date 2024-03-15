namespace bookStoreRecord
{
    internal class Program
    {
        public record Bookstore(int ID, string Title, string Author, double Price);
        static void Main(string[] args)
        {
            Bookstore book1 = new Bookstore(1, "Harry Potter and the Sorcerer's Stone", "J. K. Rowling", 19.71);
            Bookstore book2 = new Bookstore(2, "It", "Stephen King", 14.36);
            Bookstore book3 = new Bookstore(3, "Never Let Me Go", "Kazuo Ishiguro", 11.39);

            Console.WriteLine(book1);
            Console.WriteLine(book2);
            Console.WriteLine(book3);
        }
    }
}
