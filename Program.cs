namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library<Media> lib = new Library<Media>("afs", "ad", 2003, true);
            Media med1 = new Media("asdafs", "adasd", 2001, true);
            lib.Add(med1);
            lib.Remove(med1);
        }
    }
}
