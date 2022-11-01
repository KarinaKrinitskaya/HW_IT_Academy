using System;

namespace CSharpOOP2
{
    public class Book
    {
        #region Fields

        public string Name;
        public string Genre = "Romance ";
        public int Pages;
        public bool IsHardCover;
        public float Price;

        public static string Language = "English";

        //Fields for properties
        private double _id;
        private string _status = "In stock!";

        #endregion

        #region Construstors

        public Book() { }

        public Book(string name, string genre, int pages, bool hardCover, float price) : this(name)
        {
            Name = name;
            Pages = pages;
            IsHardCover = hardCover;
            Price = price;
        }

        public Book(string genre)
        {
            Genre = "Horror";
        }

        #endregion

        #region Property

        public double ID
        {
            set => _id = value; // only for write
        }

        public double Status
        {
            get; // only for read
        }

        public string Material { get; internal set; } = "newsprint";

        #endregion

        #region Methods

        public float GetDiscountedPrice()
        {
            if (!IsHardCover)
            {
                Console.WriteLine("Book has 20% discount");
                float disPrice = 0.8f * Price;
                Price = disPrice;
                return Price;
            }
            return Price;
        }

        private void PrintHasPresent(int pages)
        {
            if(pages >= 800)
            {
                Console.WriteLine("You have present!");
            }
            Console.WriteLine("You are loser!!!!");
        }

        internal void SetHardCover()
        {
            IsHardCover = true;
            Console.WriteLine("You chenged hard cover your book");
        }

        //static method
        public static void TryFindBook()
        {
            Console.WriteLine(@"Visit our site for search http/books.com");
        }

        //overload??? method
        public void TryFindBook(bool availability)
        {
            if(!availability)
            {
                Console.WriteLine("Sorry, this book is impossible to find");
            }
            else 
            Console.WriteLine(@"Visit our site for search http/books.com");
        }

        #endregion
    }
}

