namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library<Book> lib = new Library<Book>();
            Book book1 = new Book("asdafs", "adasd", 2001, true, 4, "sa");
            
            s
            lib.Add(book1);
            lib.SortByDurationMin();   


            lib.PrintAll();
        }
    }
}
