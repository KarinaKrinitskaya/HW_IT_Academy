using System;
using System.Xml.Linq;

namespace CSharpOOP2
{
    public static class BookAssistant
    {
        public static void GoldenFishLottery(int pages)
        {
            if (pages % 2 == 0)
            {
                Console.WriteLine("You win 1000$!");
            }

            Console.WriteLine("You win 1$!");
        }

        public static void CryItLoudToTheConsole(string name)
        {
            Console.WriteLine(name.ToUpper());
        }

        public static void PrintBookSummary(Book someBook)
        {
            Console.WriteLine("Book summary:");
            Console.WriteLine($"Name:\t{someBook.Name}");
            Console.WriteLine($"Genre:\t{someBook.Genre}");
            Console.WriteLine($"Is hard cover:\t{someBook.IsHardCover}");
            Console.WriteLine($"Price:\t{someBook.Price}");
        }

        public static void OooooopsMethod( string name, int pages)
        {
            pages = (30 * pages) / 100;
            Console.WriteLine($"Oooooops! Goblins has stolen pages from {name}. {name} has {pages} now, We probably wont recover your money");
        }
    }
}

