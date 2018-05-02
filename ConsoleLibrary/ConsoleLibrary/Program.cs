using System;

namespace ConsoleLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Library boiseLibrary = new Library("Boise Library", "123 fak str ");
            Book mobyDick = new Book("Moby dick", "d", 7.9);
            var batttlefeild1942 = new VideoGame()
            {
                Name = "BattleField 1942",
                Platform = "Pc"
            };
            boiseLibrary.Books.Add(mobyDick);
            boiseLibrary.ItemsForCheckout.Add(mobyDick);


            

        }
    }
}
