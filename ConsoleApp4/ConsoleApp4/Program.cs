namespace librarymanagementsystem

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[3];

            books[0] = new Book("J.K. Rowling");
            books[0].SetData(1, "Harry Potter");

            books[1] = new Book("George Orwell");
            books[1].SetData(2, "1984");

            books[2] = new Book("Mark Twain");
            books[2].SetData(3, "Tom Sawyer");

            Console.WriteLine("📚 Library Book List:\n");

            // Loop (foreach)
            foreach (Book b in books)
            {
                b.DisplayInfo();   // Polymorphism
            }

            Console.WriteLine("Total Books: " + books.Length);
        }
    }
    }

