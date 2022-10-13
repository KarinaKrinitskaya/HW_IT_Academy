// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

new Homework().Task_7();

//Специальное задание: для проверки его работы раскомметируйте строчку "new Homework().Task_special();"
//new Homework().Task_special();

Console.ReadLine();

class Homework
{
    public void Task_1()
    {
        int n = 500;
        float f = 3.14f;
        char c = 'g';
        bool b = true;
        string s = "Lacrimosa";

        Console.WriteLine(n);
        Console.WriteLine(f);
        Console.WriteLine(c);
        Console.WriteLine(b);
        Console.WriteLine(s);
    }

    public void Task_2()
    {
        int a = 5;
        long b = 5;

        float f1 = 3.14f;
        float f2 = 3.14f;

        string stringA = new string("Cantarella");
        dynamic stringB = new string("Cantarella");

        object o1 = 9999;
        object o2 = 9999;

        List<int> alist = new List<int>();
        List<int> blist = new List<int>();

        Console.WriteLine("Compare value type data items:");

        Console.WriteLine("Using Equality operator: {0}", a == b);
        Console.WriteLine("Using equals() method: {0}", a.Equals(b));

        Console.WriteLine("Using Equality operator: {0}", f1 == f2);
        Console.WriteLine("Using equals() method: {0}", f1.Equals(f2));

        Console.WriteLine("Compare for reference type data items:");

        Console.WriteLine("Using Equality operator: {0}", stringA == stringB);
        Console.WriteLine("Using equals() method: {0}", stringA.Equals(stringB));

        Console.WriteLine("Using Equality operator: {0}", o1 == o2);
        Console.WriteLine("Using equals() method: {0}", o1.Equals(o2));

        Console.WriteLine("Using Equality operator: {0}", alist == blist);
        Console.WriteLine("Using equals() method: {0}", alist.Equals(blist));
    }

    public void Task_3()
    {
        Console.WriteLine("Введите имя");
        string? name = Console.ReadLine();
        Console.WriteLine("Введите фамилию");
        string? lastName = Console.ReadLine();
        Console.WriteLine("Введите возраст");
        string? age = Console.ReadLine();
        Console.WriteLine($"{name}, {lastName}, {age}");

        Console.WriteLine("Диалог");
        Console.WriteLine("\"Где деньги, Лебовски\", - спросил Лебовски, глядя в зеркало. \n\"История становилаась все старнноватее и странноватее\",- подумала Алиса.");
    }

    public void Task_4()
    {
        //Errare humanum est - человеку свойственно ошибаться
        Console.WriteLine("Enter the first word");
        string? word1 = Console.ReadLine();
        Console.WriteLine("Enter the second word");
        string? word2 = Console.ReadLine();
        Console.WriteLine("Enter the third word");
        string? word3 = Console.ReadLine();
        Console.WriteLine("JOIN");
        Console.WriteLine(String.Join(" ", word1, word2, word3));
        Console.WriteLine("CONCAT");
        Console.WriteLine(String.Concat(word1, word2, word3));
    }

    public void Task_5()
    {
        //Docendo discimus  - Обучая мы учимся сами
        Console.WriteLine("Enter the string");
        string? myStr = Console.ReadLine();
        if (myStr == null) return;//проверка чтобы убрать предупрежление CS8602
        string? partOfStr1 = myStr.Substring(3);
        string? partOfStr2 = myStr.Substring(1,3);
        Console.WriteLine(String.Join(" ", partOfStr1,partOfStr2));//Надеюсь это сджойнила:)
    }

    public void Task_6()
    {
        //Сегодня пасмурно
        Console.WriteLine("Enter the string with epithet");
        string? myStr = Console.ReadLine();
        if (myStr == null) return;//проверка чтобы убрать предупрежление CS8602
        Console.WriteLine("Modified string:");
        Console.WriteLine(myStr.Replace("пасмурно","солнечно"));
    }

    public void Task_7()
    {
        Console.WriteLine("Enter a small letter");
        string? myLetterSmall = Console.ReadLine();
        
        Console.WriteLine("Modified letter:");
        if (myLetterSmall == null) return;//проверка чтобы убрать предупрежление CS8602
        Console.WriteLine(myLetterSmall.ToUpper());
    }

    public void Task_special()
    {
        Console.WriteLine("Enter the first string");
        string? sentence1 = Console.ReadLine();
        Console.WriteLine("Enter the second string");
        string? sentence2 = Console.ReadLine();
        Console.WriteLine("Enter the third string");
        string? sentence3 = Console.ReadLine();
        StringBuilder sb = new StringBuilder(100);
        Console.WriteLine(sb.AppendJoin(" ", sentence1, sentence2, sentence3));
    }
}

