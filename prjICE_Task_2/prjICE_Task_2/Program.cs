namespace prjICE_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books book = new Books("Jeff Kinney", "Diary Of A Wimpy Kid", "Fiction", 213, 2015);

            book[1] = "Diary Of A Wimpy Kid";

            Console.WriteLine("Author Name: " + book[0]);
            Console.WriteLine("Book Title: " + book[1]);
            Console.WriteLine("Book Genre: " + book[2]);
            Console.WriteLine("Number of pages: " + book[3]);
            Console.WriteLine("Year book was published: " + book[4]);
            Console.WriteLine("\n");

            Books book2 = new Books("Stephan Pastis", "Timmy Failure", "Fiction", 202, 2017);
            book2["bookpublishyear"] = 2017;

            Console.WriteLine("Author Name: " + book2["author"]);
            Console.WriteLine("Book Title: " + book2["title"]);
            Console.WriteLine("Book Genre: " + book2["genre"]);
            Console.WriteLine("Number of pages: " + book2["pages"]);
            Console.WriteLine("Year book was published: " + book2["year"]);
        }
    }
}
