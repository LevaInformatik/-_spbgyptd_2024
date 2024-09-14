using System;
using System.Collections.Specialized;
using System.Xml.Linq;

class Person
{
    private string Name;
    private int Age;

    public Person(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }

    public string GetPersonInfo()
    {
        return $"Имя: {Name}, Возраст: {Age}";
    }

    public bool IsAdult()
    {
        if (this.Age >= 18)
            return true;
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();

        int age;
        while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
        {
            Console.Write("Введите ваш возраст: ");
        }

        Person person = new Person(name, age);

        Console.WriteLine(person.GetPersonInfo());
        Console.WriteLine((person.IsAdult() ? "Взрослый" : "Не взрослый"));
    }
}
