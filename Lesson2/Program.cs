using System;

class Program
{
    static void Main()
    {
        // Labs 

        // 1
        Console.Write("Write first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Write second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine($"Sum = {firstNumber + secondNumber}, Difference = {firstNumber - secondNumber}");
        Console.WriteLine($"Product = {firstNumber * secondNumber}, Quotient = {firstNumber / secondNumber} Remainder {firstNumber % secondNumber}");
        // 2
        Console.Write("Write your age: ");
        int age = int.Parse(Console.ReadLine());

        if(age > 17)
        {
            Console.WriteLine("Your are adult");
        }
        else
        {
            Console.WriteLine("You are child");
        }

        // 3
        Console.Write("Have you ID card, write 'yes' if you have, write 'no' if haven't: ");
        string clientAnswer = Console.ReadLine();

        switch (clientAnswer)
        {
            case "yes":
                Console.WriteLine("Access suqsesfully");
                break;
            case "no":
                Console.WriteLine("Access rejected");
                break;
            default:
                Console.WriteLine("Wrong answer");
                break;

        }

        // Homework

        // 1
        Console.Write("Write width of rectangle: ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("Write length of rectangle: ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine($"The area is equal to {width * length}");
        // 2
        Console.Write("Write diameter of rectangle: ");
        int diameter = int.Parse(Console.ReadLine());
        Console.WriteLine($"The area is equal to {2 * diameter * 3.14}");
        // 3
        Console.Write("Write some number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine("Number is odd");
        }
    }
}


