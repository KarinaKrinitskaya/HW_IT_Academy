// See https://aka.ms/new-console-template for more information
Homework_3.Tutti_frutti3();
Console.ReadLine();

static class Homework_3
{
    static public void Tutti_frutti()
    {
        Console.WriteLine("Enter the number");
        string val = Console.ReadLine();
        bool result = int.TryParse(val, out var n);//out - помни, в n что-то определенно положили (0)

        if (!result)
        {
            Console.WriteLine("Incorrect value. Try again");
            Tutti_frutti();
            return;
        }

        CheckNumbers(n);
    }
    static void CheckNumbers(int n)
    {
        if (n % 2 == 0)
        {
            Console.WriteLine("tutti");
        }
        else if (n % 5 == 0)
        {
            Console.WriteLine("frutti");
        }
        else if (n % 2 == 0 && n % 5 == 0)
        {
            Console.WriteLine("tutti-frutti");
        }
        else
        {
            Console.WriteLine($"{n} is not divite by 2 and by 5.");
        }
    }

    static public void Tutti_frutti2()
    {
        Console.WriteLine("Enter the first number.");
        string val = Console.ReadLine();
        Console.WriteLine("Enter the second number. Second number must be bigger then the first number");
        string val2 = Console.ReadLine();
        bool result = int.TryParse(val, out var n);
        bool result2 = int.TryParse(val2, out var n2);

        if (!result && !result2 || n >= n2)
        {
            Console.WriteLine("Incorrect values. Try again");
            Tutti_frutti2();
            return;
        }

        while (n <= n2)
        {
            CheckNumbers(n);
            n++;
        }
    }

    static public void Tutti_frutti3()
    {
        Console.WriteLine("Enter the first number");
        string val = Console.ReadLine();
        Console.WriteLine("Enter the second number");
        string val2 = Console.ReadLine();
        bool result = int.TryParse(val, out var n);
        bool result2 = int.TryParse(val2, out var n2);
        var startRange = 0;
        var endRange = 0;
        if (!result)
        {
            Console.WriteLine("Incorrect values. Try again");
            Tutti_frutti3();
            return;
        }

        if (n > n2)
        {
            startRange = n2;
            endRange = n;
        }
        else
        {
            startRange = n;
            endRange = n2;
        }

        for (int i = startRange; i <= endRange; i++)
        {
            CheckNumbers(i);
        }
    }
}