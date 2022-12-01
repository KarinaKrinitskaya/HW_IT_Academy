using System.Text.RegularExpressions;
using CSharpAdvanced;


#region Task_1

List<string> flowers = new List<string>() { "Lycoris", "Rose", "Violet", "Daisy", "Cornflower", "Peony" };

GetFirstElemList(flowers);

static T GetFirstElemList<T>(List<T> someList)
{
    return someList.First();
}

#endregion

#region Task_2

Rose whiteRose = new Rose("Tea", "White", 15);
Lycoris redLycoris = new Lycoris("Radiata", "Red", 30);

int qRose = InputFlowersQuantity<Rose>();
int qLycoris = InputFlowersQuantity<Lycoris>();

Console.WriteLine("\nYour receipt:");
PrintHeapPriceLine<Rose>(whiteRose, qRose);
PrintHeapPriceLine<Lycoris>(redLycoris, qLycoris);

static double GetHeapPriceLine<T>(T flower, int q) where T : Flower
{
    return flower.Price * q;
}

static void PrintHeapPriceLine<T>(T flower, int q) where T : Flower
{
    double totalPrice = GetHeapPriceLine<T>(flower, q);
    Console.WriteLine($"{flower.Name} in quantity {q}, unit price {flower.Price}, total price {totalPrice}");
}

#endregion

#region Task_3

Console.WriteLine("\nNow we will repaint our flowers");
FlowerRepainter<Flower>.RepaintFlower(whiteRose);
whiteRose.PrintInfo();

FlowerRepainter<Flower>.RepaintFlower(redLycoris);
redLycoris.PrintInfo();

Console.WriteLine("\nNew receipt:");
PrintHeapPriceLine<Rose>(whiteRose, qRose);
PrintHeapPriceLine<Lycoris>(redLycoris, qRose);

#endregion

#region Task_4

Console.WriteLine("\nNow we will play with books");

Book book005 = new Book
{
    Name = "IT",
    Pages = 1184,
    IsHardCover = true,
    Price = 19
};

book005.GoldenFishLottery();
book005.CryItLoudToTheConsole();
book005.PrintBookSummary();
book005.OooooopsMethod(30);

//New method
book005.ToHelloKitty();

#endregion

static int InputFlowersQuantity<T>()
{
    Console.WriteLine($"Enter the quantity of {GetClassName<T>()}:");
    string qStr = Console.ReadLine();
    bool res = int.TryParse(qStr, out var result);
    return result;
}

static string GetClassName<T>()
{
    var typeName = typeof(T).ToString();
    string output = Regex.Replace(typeName, @"[.\w]+\.(\w+)", "$1");
    return output;
}
Console.ReadLine();