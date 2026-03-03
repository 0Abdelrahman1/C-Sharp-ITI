namespace Task
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        public override string ToString() => $"[ ISBN:{ISBN}, Title:{Title}, Authors:{Authors}, PublicationDate:{PublicationDate}, Price:{Price} ]";
    }

    public class BookFunctions
    {
        public static string GetTitle(Book B) => B.Title;

        public static string GetAuthors(Book B) => string.Join(", ", B.Authors);

        public static string GetPrice(Book B) => B.Price.ToString();
    }

    public class LibraryEngine
    {
        public delegate string ShowDel(Book B);

        public static void ProcessBooks(List<Book> bList , ShowDel fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
        public static void ProcessBooks<T>(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> bks = [new("ISBN1", "TITLE1", ["Authors11", "Authors12"], new DateTime(2026, 1, 1), 1.1m), new("ISBN2", "TITLE2", ["Authors21", "Authors22"], DateTime.Now, 2.2m)];
            LibraryEngine.ShowDel fptr = BookFunctions.GetTitle;

            LibraryEngine.ProcessBooks(bks, fptr);
            LibraryEngine.ProcessBooks<int>(bks, BookFunctions.GetAuthors);
            LibraryEngine.ProcessBooks(bks, delegate (Book b) { return b.ISBN; });
            LibraryEngine.ProcessBooks<int>(bks, b => $"[ Year:{b.PublicationDate.Year}, Month:{b.PublicationDate.Month}, Day:{b.PublicationDate.Day} ]");

        }
    }


}
