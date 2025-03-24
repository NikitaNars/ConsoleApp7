namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library<Media> lib = new Library<Media>();
            Media med1 = new Media("asdafs", "adasd", 2001, true);
            Media med2 = new Media("as", "xc", 2003, true);
            Media med3 = new Media("zxc", "s", 2002, true);

            lib.Add(med1);
            lib.FindByTitle(med1.Title);
            lib.Add(med2);
            lib.Remove(med2.Title);
            //lib.Remove(med3.Title);
            lib.PrintAll();
        }
    }
}
