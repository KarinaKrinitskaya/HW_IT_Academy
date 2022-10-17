// See https://aka.ms/new-console-template for more information

new Homework_2().Task_6();

Console.ReadLine();

class Homework_2
{
    public void Task_1()//использовался метод ReadValue (реализован ниже)
    {
        var b = ReadValue<byte>(Convert.ToByte);
        var f = ReadValue<float>(Convert.ToSingle);
        var n = ReadValue<int>(Convert.ToInt32);
        var myBool = ReadValue<bool>(Convert.ToBoolean);
        

        Console.WriteLine(String.Format("Your byte number: {0}", b));
        Console.WriteLine(String.Format("Your int number: {0}", n));
        Console.WriteLine(String.Format("Your float number: {0}f", f));
        Console.WriteLine(String.Format("Your boolean: {0}", myBool));
    }

    public void Task_2()//использовался метод ReadValue (реализован ниже)
    {
        var l = ReadValue<long>(long.Parse);
        var d = ReadValue<decimal>(decimal.Parse);

        Console.WriteLine(String.Format("Your long number: {0}", l));
        Console.WriteLine(String.Format("Your decimal number: {0}", d));
    }

    public void Task_3()
    {
        Console.WriteLine("Enter the value");
        string? myStr = Console.ReadLine();

        bool result = int.TryParse(myStr, out var number);//передаем аргумент по ссылке, без инициализации
        if (result == false)
        {
            Console.WriteLine("Incorrect value.Try again");
            new Homework_2().Task_3();//хоба! рекурсия
        }
        else
        Console.WriteLine($"Success! Your number: {number}");
    }

    //Реализация метода ReadValue
    private delegate T ConvertFromString<T>(string s);//delegate is a "template" of method, это дает возможность передать метод такого вида, как параметр метода
 
    private T ReadValue<T>(ConvertFromString<T> converter)
    {
        T val = default;// инициализируем в качестве значения по умолчанию для какого-то типа (T), чтобы не было ошибки cs0103
        var typeName = typeof(T).ToString(); //Оператор typeof получает экземпляр System.Type для указанного типа. 
        bool isOK = false;

        //ниже обработка в случае если было выброшено исключение(ввод некоректного значения)
        while (!isOK)
        {
            Console.WriteLine($"Enter the {typeName} number");

            try
            {
                val = converter(Console.ReadLine());
                isOK = true;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Incorrect {typeName} value was entered. Try again.");
            }
        }
        return val;
    }

    public void Task_4()
    {
        int a = 7;
        int b = a + 3;
        int c = a + b;
        Console.WriteLine($"Your result is {c}");
    }

    public void Task_5()
    {
        //можно было использовать боксинг, но мы этого избегаем используя структуру ValueTuple (значимый тип)
        var purchase = new Dictionary<string, ValueTuple<double, double>>()// cловарь со строкой-ключом и кортежем(структура) - значением
            {
                {"Apple", new ValueTuple<double, double>(3,5)},//первый double - кол-во, второй цена за штуку
                {"Flour", new ValueTuple<double, double>(2,1)},
                {"Sugar", new ValueTuple<double, double>(2,5)},
                {"Eggs", new ValueTuple<double, double>(10,6)},
                {"Milk", new ValueTuple<double, double>(2,4)}
            };

        var check = (purchase["Apple"].Item1 * purchase["Apple"].Item2) +
            (purchase["Flour"].Item1 * purchase["Apple"].Item2) +
            (purchase["Sugar"].Item1 * purchase["Apple"].Item2) +
            (purchase["Eggs"].Item1 * purchase["Apple"].Item2) +
            (purchase["Milk"].Item1 * purchase["Apple"].Item2);
        var discount15 = (check * 15) / 100;
        var finalPrice = check - discount15;

        Console.WriteLine($"Your price with discount: {finalPrice}");
    }

    public void Task_6()
    {
        double a = 5;
        double b = 2;
        double c = a++ + (((a + b) * b) - b); // result = 19
        //1) a++ = 5; a = 6;
        //2) (a + b) = 6 + 2 = 8
        //3) (a + b) * b) = 8 * 2 = 16
        //4) (((a + b) * b) - b) = 16 - 2 = 14
        //5) a + (((a + b) * b) - b) = 5 + 14 = 19 

        a = 2;
        b = 4;
        double z = --b * a-- / a - b; // result = 3
        //1) --b = 3;  b = 3;
        //2) a-- = 2; a = 1;
        //3) b * a = 3 * 2 = 6
        //4) b * a / a = 6 / 1 = 6
        //5) b * a/ a - b = 6 - 3 = 3

        Console.WriteLine($"The first result: {c}");
        Console.WriteLine($"The second result: {z}");
    }

    public void Task_7() // Для проверки работы метода нужно расскомметирвать строки, принадлежащие каждой части задания
    {
        ////7.1
        //int a = 2;
        //int b = 2;
        //Console.WriteLine(a == b); // для false:  a != b

        //7.2
        //int a = 2;
        //int b = 2;
        //int c = 2;
        //Console.WriteLine(a == c && b == c); // для false:  a != с

        //7.3
        //int a = 4;
        //int b = 2;
        //int c = 3;
        //Console.WriteLine(a > c || b > c); // для false:  a > c && b > c

        //7.4
        //int a = 5;
        //int b = 100;
        //Console.WriteLine(a != b); // для false: a == b

        //7.5
        //int a = 7;
        //int b = 50;
        //Console.WriteLine(a <= b); // для false: a > b

        //Дополнительные задания
        //7.6
        //int a = 90;
        //int b = 10;
        //Console.WriteLine(a >= b && a != 100);

        //7.7
        //int a = 70;
        //int b = 89;
        //int c = 8;
        //int d = 0;
        //Console.WriteLine((a != b || a >= c) && (b > d));

    }

    public void Task_8()
    {
        int i = 66;

        //Упаковка i (перемещение в кучу)
        object o = i;

        //Расспаковка o (перемещение в стэк)
        i = (int)o;
    }

    public void Task_9()
    {
        //явное преобразование (int > byte)
        try
        {
            int i1 = 77;
            byte b = checked((byte)i1);//проверяем можем преобразовать без потери данных или нет
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }

        //неявное преобразование(double > int)
        int i2 = 79;
        double d = i2;
    }
}

