using CSharpOOP2;

#region Task 4

Book book001 = new Book();

book001.Name = "Dune";
book001.Genre = "Science-fiction";
book001.Pages = 704;
book001.IsHardCover = false;
book001.Price = 12;

#endregion

#region Task 5

Book book002 = new Book { Name = "A Game of Thrones", Genre = "Fantasy", Pages = 764, IsHardCover = true, Price = 14 };

#endregion

#region Task 9

Book book003 = new Book("Dracula", "Horror", 409, false, 13);

#endregion

#region Task 10

book001.GetDiscountedPrice();

#endregion

#region Task 11

book003.SetHardCover();
//book002.HasPresent(200);//error line

#endregion

#region Task 12

Book book004 = new Book { Name = "Against All Odds: A True Story of Ultimate Courage and Survival in World War II", Genre = "History", Pages = 368, Price = 20 };
//Console.WriteLine($"The book {book004.Name}, genre is {book004.Genre}, have {book004.Pages} pages, and hard cover is {book004.IsHardCover}, price is {book004.Price}.");//hardcover - false, becouse flase is default value for bool type
//I think to use this methods will be better:
BookAssistant.PrintBookSummary(book004);
#endregion

#region Task 13

Book book005 = new Book
{
    Name = "IT",
    Pages = 1184,
    IsHardCover = true,
    Price = 19
};
//Console.WriteLine($"The book {book005.Name}, genre is {book005.Genre}, have {book005.Pages} pages, and hard cover is {book005.IsHardCover}, price is {book005.Price}.");
//I think to use this methods will be better:
BookAssistant.PrintBookSummary(book005);
#endregion

#region Task 15

//property without get
book002.ID = 12331223.12;
//var id = book002.ID; //error line

//property without set
//book002.Status = "Ha-ha, I stole your book!"; // error line
var status = book001.Status;
#endregion

#region Task 17

var lang = Book.Language;

#endregion

#region Task 18

Book.TryFindBook();
book001.TryFindBook(false);

#endregion

#region Task 20

BookAssistant.GoldenFishLottery(book003.Pages);
BookAssistant.OooooopsMethod(book005.Name, book005.Pages);
BookAssistant.CryItLoudToTheConsole(book002.Name);
BookAssistant.PrintBookSummary(book002);

#endregion

Console.ReadLine();