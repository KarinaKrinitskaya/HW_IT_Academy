//Task 1
//Приведите любой пример реализации интерфейса и абстрактного класса для объекта Dog или Car на выбор.  
//Необходимо иметь: класс Dog или Car, интерфейс, абстрактный класс

Dog dog = new Dog();
dog.Be();
Car car = new Car();
car.Move();

//Task2
//Объявите коллекцию городов из 4х на ваш выбор.
//Выберите из них те, которые имеют в себе четное количество символов,
//затем в них замените первую букву и выведите первые 3 буквы каждого как результирующую коллекцию.


List<string> towns = new List<string>() { "Warsaw", "Rome", "Porto", "Tokyo" };

var newTowns = towns.Where(n => n.Length % 2 == 0).Select(n => n[0]); //;( не помню как поменять местами

//Task 3
//Напишите дженерик метод, который будет выводить на консоль некоторый переданный ему параметр.

string color = "Scarlet";
GetFirstElemList(color);

static void GetFirstElemList<T>(T someColor)
{
    Console.WriteLine(someColor);
}


//решение к первой задаче
public class Dog : Thing
{
    public string name;
    public int age;
}

public abstract class Thing 
{
    public void Be()
    {
        Console.WriteLine("it exist!");
    }
}

public interface IMovable
{
    void Move();
}


public class Car : IMovable
{
    public void Move() => Console.WriteLine("I am walking!");
}

