using System;
using System.Linq.Expressions;

// 1
class Point
{
    public int X {get;}
    public int Y {get;}

    public Point(int x, int y) { X = x; Y = y;}

    public override bool Equals(object? obj)
    {
        if(obj is not Point other) return false;

        return X==other.X && Y ==other.Y;
    }

    public override string ToString()
    {
        return $"X = {X} Y = {Y}";
    }


    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
}


// 2

class Email
{
    private readonly string _address;

    public Email(string? address)
    {
        if(address is null)
            throw new ArgumentNullException("Email address can not be null");

        _address = Normalize(address);
        

        if(!IsValid(_address))
        {
            throw new ArgumentException("Email addres should be with @");
        }
    }

    private static bool IsValid(string address)
    {
        return address.Contains("@");
    }

    private static string Normalize(string address)
    {
        return address.Trim().ToLowerInvariant();
    }

    public override string ToString()
    {
        return _address;
    }
}


// 3

class LibraryBook
{
    public string Author { get; }
    public string Title {  get; }
    public int Year {  get; }

    public LibraryBook(): this("Unknown") { }
    public LibraryBook(string title) : this(title, "Unknown"){ }
    public LibraryBook(string title, string author) : this(title, author, DateTime.Now.Year) { }

    public LibraryBook(string title, string author, int year) 
    {
        Title = string.IsNullOrWhiteSpace(title) ? "Unknown" : title;
        Author = string.IsNullOrWhiteSpace(author) ? "Unknown" : author;

        if(year >= 500 && year <= DateTime.Now.Year)
        {
            Year = year;
        } else
        {
            Year = DateTime.Now.Year;
        }
    }

    public override string ToString()
    {
        return $"Title - {Title}, Author - {Author}, Year - {Year}";
    }
}


// 4

class AppSettings
{
    public string Environment { get; init; }
    public string Version {  get; init; }

    public override string ToString()
    {
        return $"Environment is {Environment} and Version is {Version}";
    }


    class Program
{
    static void Main()
    {
        // 1
        Point p1 = new Point(10, 15);
        Point p2 = new Point(15, 20);
        Point p3 = new Point(10, 15);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
        Console.WriteLine(p1==p2);
        Console.WriteLine(p1==p3);
        Console.WriteLine(p1.Equals(p2));
        Console.WriteLine(p1.Equals(p3));

        // 2
        try { var email1 = new Email(null); }
        
        catch (Exception ex) { Console.WriteLine($"{ex}"); }

        try { var email2 = new Email("artur-sahakyan#gmail.com"); }

        catch (Exception ex) { Console.WriteLine($"{ex}"); }

        try { var email3 = new Email("artur-sahakyan@gmail.com"); Console.WriteLine(email3); }

        catch (Exception ex) { Console.WriteLine($"{ex}"); }

        // 3
        var book1 = new LibraryBook();
        Console.WriteLine(book1);
        var book2 = new LibraryBook("C# fundamentals");
        Console.WriteLine(book2);
        var book3 = new LibraryBook("C# fundamentals", "Artur");
        Console.WriteLine(book3);
        var book4 = new LibraryBook("C# fundamentals", "Artur", 2022);
        Console.WriteLine(book4);
        var book5 = new LibraryBook("C# fundamentals", "Artur", 20);
        Console.WriteLine(book5);

            // 4
            var settings1 = new AppSettings
            {
                Environment = "Dev",
                Version = "1.0"
            };
            Console.WriteLine(settings1);
            var settings2 = new AppSettings
            {
                Environment = "Stage",
                Version = "2.0"
            };
            Console.WriteLine(settings2);
            var settings3 = new AppSettings
            {
                Environment = "Prod",
                Version = "3.0"
            };
            Console.WriteLine(settings3);

        }
}
}

