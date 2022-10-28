// See https://aka.ms/new-console-template for more information

#region Task_1

var c = Homework_1.ReadValue<int>("count", int.TryParse);
var p = Homework_1.ReadValue<double>("price", double.TryParse);
var s = Homework_1.ReadValue<int>("discount", int.TryParse);
Console.WriteLine($"Our's total price is {Homework_1.CalculateFinalItemPrice(c, p, s)}");

#endregion

#region Task_2

Console.WriteLine("\nTask 2:");
int nProducts = 3;
var names = new string[nProducts];
var counts = new int[nProducts];
var prices = new double[nProducts];

for (int i = 0; i < nProducts; i++)
{
    Console.WriteLine("Enter the name of product:");
    names[i] = Console.ReadLine();
    counts[i] = Homework_1.ReadValue<int>("count", int.TryParse);
    prices[i] = Homework_1.ReadValue<double>("price", double.TryParse);
}
var discount = Homework_1.ReadValue<int>("discount", int.TryParse);
Console.WriteLine("Yours receipt:");
for (int i = 0; i < nProducts; i++)
{
    Homework_1.PrintProductCheckLine(names[i], prices[i], discount, counts[i]);
}

#endregion

#region Task_3

Console.WriteLine("\nTask 3:");
//Сall the method with optional parameter
Homework_1.PrintProductCheckLine("some product", 10, 5, 5);
//Сall the method without optional parameter
Homework_1.PrintProductCheckLine("some product", 10, 5);

#endregion

#region Task_4

var sides = new int[5];
for (int i = 0; i < sides.Length; i++)
{
    sides[i] = Homework_1.ReadValue<int>($"side {i+1}", int.TryParse);
}
Console.WriteLine($"Perameter of triangle is {Homework_1.GetPerimeter(sides[0], sides[1], sides[2])}");
Console.WriteLine($"Perameter of quadrilateral is {Homework_1.GetPerimeter(sides[0], sides[1], sides[2], sides[3])}");
Console.WriteLine($"Perameter of pentagon is {Homework_1.GetPerimeter(sides)}");

#endregion

#region Task_5

//int firstSidesOfTriangle = 4;
//int secondSidesOfTriangle = 6;
//double angleBetweenSides = 90;
//int r = 15;
//Console.WriteLine($"The Area of a Triangle is {Homework_1.theAreaOfaFigure(firstSidesOfTriangle, secondSidesOfTriangle, angleBetweenSides)}");
//Console.WriteLine($"The Area of a Circle is {Homework_1.theAreaOfaFigure(r)}");
//Console.ReadLine();

#endregion

#region Task_6

//Примеры OOP в реальной жизни
//Наследование - последний айфон, имеет кучу функций унаследованных от предыдущих моделей, но у него есть новые свойства, модуль камеры пересобран и тд
//Инкапсуляция - интерфейс любого приложения, мы можем пользоваться приложением используя функции которые явно предсатвлены в интерфейсе,
//но мы не можем влиять на устройство и работу самого приложения
//Полиморфизм - есть чувак, полный твой тезка, он грабит банк и оставляет свою подпись (ФИО) и скрывается, но садят тебя, потому что это Хабаровск и конец декады
//Абстракция - любые схемы, где выделены только главные функциональные части

#endregion


static class Homework_1
{
    static public double CalculateFinalItemPrice(int n, double price, int discount)
    {
        double basePrice = n * price;
        double finalPrice = basePrice - (basePrice * discount / 100);
        return finalPrice;
    }

    static public void PrintProductCheckLine(string nameOfProduct, double price, int discount, int count = 2)
    {
        Console.WriteLine($"{nameOfProduct}: total price is {Homework_1.CalculateFinalItemPrice(count, price, discount)}");
    }

    static public int GetPerimeter(params int[] sideLengths)
    {
        int perimeter = 0;
        foreach (int side in sideLengths)
        {
            perimeter += side;
        }
        return perimeter;
    }


    public delegate bool ParseDelegate<T>(string s, out T result);

    static public T ReadValue<T>(string lbl, ParseDelegate<T> parser)
    {
        bool result;
        T val;
        do
        {
            Console.WriteLine("Enter value for " + lbl);
            var a = Console.ReadLine();
            result = parser(a, out val);
            if (!result)
                Console.WriteLine("Incorrect value. Try again");
        }
        while (!result);
        return val;
    }





    //Overloading of methods

    static public double theAreaOfaFigure(int a, int b, double angleBetweenSidesAB)
    {
        double theAreaOfaTriangle = ((a * b) / 2) * Math.Sin(angleBetweenSidesAB);

        return theAreaOfaTriangle;
    }

    static public double theAreaOfaFigure(int radius)
    {
        double theAreaOfaCircle = Math.PI * (radius * radius);

        return theAreaOfaCircle;
    }
}

