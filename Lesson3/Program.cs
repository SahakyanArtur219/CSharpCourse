using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        // Labs

        // 1
        Console.Write("Write number: ");
        int number = int.Parse(Console.ReadLine());
        if (number == 0)
        {
            Console.WriteLine("Number is equal to 0");
        } else if(number > 0)
        {
            Console.WriteLine("Number is positive");
        }
        else
        {
            Console.WriteLine("Number is negative");
        }

        // 2
        Console.Write("Write first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Write second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Write operation code: 1(+) 2(-) 3(*) 4(/): ");
        int operationCode = int.Parse(Console.ReadLine());

        switch(operationCode)
        {
            case 1:
                Console.WriteLine($"{firstNumber + secondNumber}");
                break;
            case 2:
                Console.WriteLine($"{firstNumber - secondNumber}");
                break;
            case 3:
                Console.WriteLine($"{firstNumber * secondNumber}");
                break;
            case 4:
                Console.WriteLine($"{firstNumber / secondNumber}");
                break;
            default:
                Console.WriteLine("Wrong operation code");
                break;

            
        }

        for (int i = 1; i <= 20; i++)
        {
            if(i%2 == 0)
            {
                Console.WriteLine($"{i}");
            }
            
        }

        string name = "User";
        do
        {
            Console.WriteLine($"Hello {name}");
            Console.Write("Write your name, for exit write 'exit': ");
            name = Console.ReadLine();
        } while (name != "exit");

        // Homework

        Console.Write("Write the number: ");
        int customNumber = int.Parse(Console.ReadLine());
        double squareRootOfCustomNumber = Math.Sqrt(customNumber);
        bool isPrime = true;
        for(int i = 2;i <= squareRootOfCustomNumber;i++)
        {
            if(customNumber % i == 0)
            {
                Console.WriteLine("Number is not Prime");
                isPrime = false;
            }
        }
        if (isPrime)
        {
            Console.WriteLine("Number is prime");
        }

        // 2
        Console.Write("Write N: ");
        int N = int.Parse(Console.ReadLine());
        long sum = 0;
        for(int i = 1; i<=N; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine(sum);

        Console.WriteLine("Write month by number 1-12: ");

        int monthNumber = int.Parse(Console.ReadLine());
        switch (monthNumber)
        {
            case 1: Console.WriteLine("January");
                break;
            case 2: Console.WriteLine("February");
                break;
            case 3: Console.WriteLine("March");
                break;
            case 4: Console.WriteLine("April");
                break;
            case 5: Console.WriteLine("May");
                break;
            case 6: Console.WriteLine("June");
                break;
            case 7: Console.WriteLine("July");
                break;
            case 8: Console.WriteLine("August");
                break;
            case 9: Console.WriteLine("September");
                break;
            case 10: Console.WriteLine("October");
                break;
            case 11: Console.WriteLine("November");
                break;
            case 12: Console.WriteLine("December");
                break;
            default: Console.WriteLine("Wrong input");
                break;
        }

        // 4

        Random rand = new Random();
        int randomNumber = rand.Next(1,101);
        int guessableNumber = 0;
        Console.WriteLine("You need to find the number between 1-101");

        do
        {
            Console.Write("Guess the number: ");
            guessableNumber = int.Parse(Console.ReadLine());
            if(guessableNumber < randomNumber)
            {
                Console.WriteLine("Try big one");
            } else if(guessableNumber > randomNumber)
            {
                Console.WriteLine("Try small one");
            } else
            {
                Console.WriteLine("Correct");
            }

        } while (guessableNumber != randomNumber);
        
    }
}

