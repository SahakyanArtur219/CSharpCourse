using System;


// Homework

// 4
class MiniCalculator
{
    public static int Add(int a, int b) { return a + b; }
    public static int Subtract(int a, int b) { return a - b; }
    public static int Multiply(int a, int b) { return a * b; }
    public static int Divide(int a, int b) { return a / b; }


}

class Program
{
    // Labs

    // 1
    static double Add(double x, double y) { return x + y; }

    // 2
    static int CountLetters(string text)
    {
        int count = 0;
        foreach (char c in text) { count++; }
        return count;
    }

    // 3
   static void Increase(ref int x, out int results)
    {
        x++;
        results = x;
    }

    static int Fibonacci(int n)
    {
        if (n == 0) { return 0; }
        if (n == 1) { return 1; }
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    // Homework 

    // 1
    static bool IsPrime(int number)
    {
        double squareRootOfCustomNumber = Math.Sqrt(number);

        for (int i = 2; i <= squareRootOfCustomNumber; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    // 2

    static string ReverseString(string text)
    {
        string reversedString = "";
        for(int  i = text.Length - 1; i >= 0; i--)
        {
            reversedString += text[i];
        }
        return reversedString;
    }

    // 3
    static int Power(int number, int power)
    {
        int results = 1;
        if (power == 0) { return 1; }
        while(power > 0)
        {
            results *= number;
            power--;
        }
        return results;
    }
    static void Main()
    {
        // Labs

        // 1
        Console.WriteLine(Add(1, 2));
        Console.WriteLine(Add(2, 3));
        Console.WriteLine(Add(3, 4));

        // 2
        string text = "Hello C#";
        int count = CountLetters(text);
        Console.WriteLine(count);

        // 3
        int number = 15;
        int results;
        Increase(ref number,out results);
        Console.WriteLine(results);
        Console.WriteLine(Fibonacci(14));

        // Homework 

        // 1
        int customNumber = 116;
        if (IsPrime(customNumber))
        {
            Console.WriteLine("Is prime");
        } else
        {
            Console.WriteLine("Is not Prime");
        }

        // 2
        string reversingText = "Hello World";
        string ReversedText = ReverseString(reversingText);
        Console.WriteLine(ReversedText);
        // 3
        int poweredNumber = Power(17, 0);
        Console.WriteLine(poweredNumber);
        // 4
        Console.Write("Write first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Write second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Write operation code: 1(+) 2(-) 3(*) 4(/): ");
        int operationCode = int.Parse(Console.ReadLine());

        switch (operationCode)
        {
            case 1:
                Console.WriteLine(MiniCalculator.Add(firstNumber, secondNumber));
                break;
            case 2:
                Console.WriteLine(MiniCalculator.Subtract(firstNumber, secondNumber)); 
                break;
            case 3:
                Console.WriteLine(MiniCalculator.Multiply(firstNumber, secondNumber));
                break;
            case 4:
                Console.WriteLine(MiniCalculator.Divide(firstNumber, secondNumber));  
                break;
            default:
                Console.WriteLine("Wrong operation code");
                break;
        }
    }
  
}

