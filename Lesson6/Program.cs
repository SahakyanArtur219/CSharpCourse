using System;
using System.Security.Cryptography.X509Certificates;

// 1
class Student
{
    public string Name { get; }
    public int StudentId { get; }
    public int Age { get; }

    public static int Count
    {
        get;
        private set;
    } = 0; // karox enq chgrel qani vor by default Count = 0

    public Student() : this("Undifind"){ }
    public Student(string name) : this(name, 18) { }
    public Student(string name, int age): this(name, age, 10) { }
    public Student(string name, int age, int id)
    {
        Name = string.IsNullOrWhiteSpace(name)? "undefind" : name;
        if(age >= 18 && age <= 99)
        {
            Age = age;
        } else
        {
            age = 18;
        }

        StudentId = id <= 0 ? new Random().Next(100,999) : id;

        Count++;
    }

    public override string ToString()
    {
        return $"{StudentId} - {Name} - {Age}";
    }
}

// 2
class Car
{
    public string Model { get; }
    public int Year {  get; }
    public int Speed { get; private set; } // Couse we need to change value using class method

    private int MaxSpeed { get; }

    public Car(string model, int year) 
    {
        if((year < 1900 || year > 2025)&& year !=2050)
        {
            throw new ArgumentException("Car year can not be less than 1900");
        }
        Model = model;
        Year = year;
        Speed = 0;
        MaxSpeed = year / 10;
    }

    public void Accelerate()
    {
        if(Speed<=MaxSpeed-5) // We use step size 5
        {
            Speed+=5;
            Console.WriteLine($"{Model} current speed is {Speed}");
        }
        else 
        {
            Console.WriteLine($"{Model} can not go more than {MaxSpeed}");
        }
    }

    public void Brake()
    {
        if (Speed == 0) // We use step size 5 and initial value for speed is 0, so we can compare using (==)
        {
            Console.WriteLine($"{Model} does not move");
        } 
        else
        {
            Speed -= 5;
            Console.WriteLine($"{Model} current speed is {Speed}");
        }

    }
}

// 3 

class Logger
{
    public static readonly DateTime AppStart;
    static Logger()
    {
        AppStart = DateTime.Now;
        Console.WriteLine("Logger initialized");
    }

    public void Log(string msg)
    {
        Console.WriteLine($"{DateTime.Now} {msg}");
    }
}

// 4

class FileWrapper: IDisposable
{
    private StreamReader reader;

    public FileWrapper(string file_path)
    {
        reader = new StreamReader(file_path);
        Console.WriteLine($"{file_path} file opened succesfully");
    }

    public void Dispose()
    {
        reader.Dispose();
        Console.WriteLine($"File closed succesfully");
    }
}
class Program
{
    static void Main()
    {
        //1
        var student1 = new Student();
        Console.WriteLine(student1);
        var student2 = new Student("Artur");
        Console.WriteLine(student2);
        var student3 = new Student("Artur", 21);
        Console.WriteLine(student3);    
        var student4 = new Student("Artur", 21, 1105);
        Console.WriteLine(student4);

        // 2
        var car1 = new Car("Bentley", 2025);
        var car2 = new Car("BMW", 2000);
        var car3 = new Car("M.Benz", 2010);
        var futureCar = new Car("Future car", 2050);
        try
        {
            var car4 = new Car("Suzuki", 1800);
        }
        catch (Exception ex) { Console.WriteLine(ex); }
        for(int i = 0; i<42; i++)
        {
            car1.Accelerate();
            car2.Accelerate();
            car3.Accelerate();
            futureCar.Accelerate();
        }

        for (int i = 0; i < 43; i++)
        {
            car1.Brake();
            car2.Brake();
            car3.Brake();
            futureCar.Brake();
        }

        // 3
        var logger1 = new Logger();
        var logger2 = new Logger(); // We will not see the constrictor message becouse it is static and will work once
        logger1.Log("First log from logger1");
        logger2.Log("First log from logger2");

        //4
        using (var file1 = new FileWrapper("C:/user/user1/test/test.txt")) //test file path
        {
            //Work with file read/write/...
        }

    }
}

