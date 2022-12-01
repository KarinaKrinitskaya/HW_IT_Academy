using System;
namespace CSharpAdvanced
{
    public static class BookExtensions
    {
        public static void GoldenFishLottery(this Book book)
        {
            if (book.Pages % 2 == 0)
            {
                Console.WriteLine("You win 1000$!");
            }
            else
            {
                Console.WriteLine("You win 1$!");
            }
        }

        public static void CryItLoudToTheConsole(this Book book)
        {
            Console.WriteLine(book.Name.ToUpper());
        }

        public static void PrintBookSummary(this Book someBook)
        {
            Console.WriteLine("Book summary:");
            Console.WriteLine($"Name:\t{someBook.Name}");
            Console.WriteLine($"Genre:\t{someBook.Genre}");
            Console.WriteLine($"Is hard cover:\t{someBook.IsHardCover}");
            Console.WriteLine($"Price:\t{someBook.Price}");
            Console.WriteLine($"Pages:\t{someBook.Pages}");

        }

        public static void OooooopsMethod(this Book book, int oopsCoef)
        {
            book.Pages = book.Pages * oopsCoef / 100;
            Console.WriteLine($"Oooooops! Goblins has stolen pages from {book.Name}. {book.Name} has {book.Pages} pages now, We probably wont recover your money");
        }

        public static void ToHelloKitty(this Book book)
        {
            var oldName = book.Name;
            book.Name = "Hello Kitty";
            Console.WriteLine($"Your book is now Hello Kitty! Forget {oldName}");
        }
    }
}


