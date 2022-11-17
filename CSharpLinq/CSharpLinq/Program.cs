using CSharpOOP2;
using System;
using System.Collections.Generic;
//using System.Text.RegularExpressions;
//using static System.Net.Mime.MediaTypeNames;

#region Task_1

List<dynamic> numbers = new List<dynamic>() { 545, 4, 2, 32, 8, 99, 7, 5, 7, 9 };

var divideby3 = from n in numbers
                where n % 3 == 0
                select n;

Console.WriteLine("\u001b[34mConsole output task 1:\u001b[35m");
PrintCollection(divideby3);

#endregion

#region Task_2

List<dynamic> collection2 = new List<dynamic>() { -7, 9, 11, -15, 13, -9, -10, 12, 14, -8 };

var negativeNumbers = collection2.Where(n => n < 0 || n <= 10);

Console.WriteLine("\n\u001b[34mConsole output task 2:\u001b[35m");

PrintCollection(negativeNumbers);

#endregion

#region Task_3

List<dynamic> collection3 = new List<dynamic>() { "Kitten", "Elephant", "Duckling", "Puppy", "Foal" };

var sortAnimal = from animal in collection3
                 where animal.Length % 2 == 0
                 orderby animal ascending
                 select animal;

Console.WriteLine("\n\u001b[34mConsole output task 3:\u001b[35m");

PrintCollection(sortAnimal);

#endregion

#region Task_4

List<dynamic> cities = new List<dynamic>() { "Minsk", "Warsaw", "Lisbon", "Porto", "Barselona", "Rome" };

//var resultCities = cities.Where(city => city.Equals('P') && city[city.Length - 1].Equals('o'));

var resultCities = cities.Where(city => city.StartsWith('P') && city.EndsWith('o'));

Console.WriteLine("\n\u001b[34mConsole output task 4:\u001b[35m");

PrintCollection(resultCities);

#endregion

#region Task_5

Console.WriteLine("Enter the long string:");

//LACRIMOSA dies illa QUA resurget ex favilla JUDICANDUS homo reus

var someStr = Console.ReadLine();

//EXPERIMENT
//regular Expressions for //"LacrimosaDiesIlla"
//string[] split = Regex.Split(someStr, @"(?<!^)(?=[A-Z])");

var resultString = someStr.Split(' ').Where(s => s.Equals(s.ToUpper()));

Console.WriteLine("\n\u001b[34mConsole output task 5:\u001b[35m");

PrintCollection(resultString);

#endregion

#region Task_6

List<dynamic> collections4 = new List<dynamic>() { 7, 9, 11, 15, 13, 9, 9, 12, 14, 9 };

//var result4 = collections4.Distinct().OrderByDescending(c => c);

var result4 = collections4.Distinct().Reverse();

Console.WriteLine("\n\u001b[34mConsole output task 6:\u001b[35m");

PrintCollection(result4);

#endregion

#region Task_7

List<int> collections5 = new List<int>() { 100, 7, 110, 0, 15, 90, 87, 33, 1, 54 };

var someNumber = ReadValue<int>(int.TryParse);

bool has = collections5.Contains(someNumber);

if (has)
{
    Console.WriteLine("The collection has a number");
}
else
{
    Console.WriteLine("The collection hasn't a number");
}

#endregion

#region Task_8

List<string> collections6 = new List<string>() { "Pupum", "Lalala", "Patapon", "Chaka-Chaka" };

int sumSymbols = collections6.Sum(s => s.Length);

Console.WriteLine("\n\u001b[34mConsole output task 8:\u001b[35m");

if (sumSymbols > 5)
{
    var firstElem = collections6.First();
    var lastElem = collections6.Last();
    Console.WriteLine($"The first element of collections is {firstElem} and the last element of collection is {lastElem}.");
}
else
{
    Console.WriteLine($"Sum of symbols in your collection not enough and equals is {sumSymbols}");
}

#endregion

#region Task_9/10

Book book100 = new Book("Harry Potter and the Philosopher's Stone", "Fantasy", 223, true, 29.7f);
Book book200 = new Book("Harry Potter and the Chamber of Secrets", "Fantasy", 251, true, 22.9f);
Book book300 = new Book("Harry Potter and the Prisoner of Azkaban", "Fantasy", 317, true, 35.5f);

List<Book> books = new List<Book>() { book100, book200, book300 };

var bookNames = books.Select(b => b.Name);

Console.WriteLine("\n\u001b[34mConsole output task 9:\u001b[35m");

Console.WriteLine("The collection of Book name:");
PrintCollection(bookNames);

var newCollectionObj = from objectbook in bookNames
                       select new Book { Name = objectbook, Genre = "Some Genre", Pages = 400, IsHardCover = false, Price = 400.50f };


//Create the collection with a new objects for task 10
var newCollectionObj2 = from objectbook in bookNames
                   select new Book { Name = objectbook };

#endregion

void PrintCollection(IEnumerable<dynamic> someList)
{
    foreach (dynamic n in someList)
    {
        Console.WriteLine(n);
    }
}

Console.ReadLine();

static T ReadValue<T>(ParseDelegate<T> parser)
{
    bool result;
    T val;

    do
    {
        Console.WriteLine("\n\u001b[34mEnter the value:\u001b[35m");
        var v = Console.ReadLine();
        result = parser(v, out val);
        if (!result)
            Console.WriteLine("Incorrect value. Try again");
    }
    while (!result);
    return val;
}

public delegate bool ParseDelegate<T>(string s, out T result);



