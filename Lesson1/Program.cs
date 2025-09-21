using System;

class Program
{
    static void Main()
    {
        // Labs

        // 1
        Console.WriteLine("Hello I learn C#");
        // 2
        Console.Write("Write your name: ");
        string name = Console.ReadLine();
        Console.Write("Write your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"Hello {name}, you are {age} years old");
        // 3
        Console.Write("input first nmuber: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("input second nmuber: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine($"Results - {firstNumber * secondNumber}");

        //Homework
        // 1
        Console.Write("Write your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Write your last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Write your city: ");
        string city = Console.ReadLine();
        Console.WriteLine($"I am {firstName} {lastName}, I live in {city}");

        Console.WriteLine("*****");
        Console.WriteLine("*   *");
        Console.WriteLine("*****");
    }
}


