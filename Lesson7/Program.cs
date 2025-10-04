using System;
using System.ComponentModel.DataAnnotations;


// 1
class Employees
{
    public string Name { get; init; }
    public int Salary { get; set; }

    public Employees(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }

    public virtual void Work()
    {
        Console.WriteLine("(Employees) - work statrs");
    }


}


class Menegers : Employees
{
    public Menegers(string name, int salary): base(name, salary) { }

    public override void Work()
    {
        Console.WriteLine("(Meneger) - work statrs");
    }

}

class Developer : Employees
{
    public Developer(string name, int salary) : base(name, salary) { }

    public override void Work()
    {
        Console.WriteLine("(Developer) - work statrs");
    }
}

class Designer : Employees
{
    public Designer(string name, int salary) : base(name, salary) { }

    public override void Work()
    {
        Console.WriteLine("(Designer) - work statrs");
    }
}

// 2
    
abstract class Appliance
{
    public abstract void TurnOff();
    public abstract void TurnOn();

}

class TV : Appliance
{
    public override void TurnOff()
    {
        Console.WriteLine("TV turned off");
    }

    public override void TurnOn() 
    {
        Console.WriteLine("TV turn on");
    }
}


class WashingMachine : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("WashingMachine turned on");
    }
    public override void TurnOff()
    {
        Console.WriteLine("WashingMachine turned off");
    }

}

// 3 
interface IPayable
{
    void PaySalary();
}


class Employee : IPayable
{
    public void PaySalary()
    {
        Console.WriteLine("(Employee) - Pay Salary");
    }
}


class Freelancer : IPayable
{
    public void PaySalary()
    {
        Console.WriteLine("(Freelancer) - Pay Salary");
    }
}
class Program
{
    static void Main()
    {
        // 1
        List<Employees> emp = new List<Employees>
        {
            new Menegers("Artur", 500),
            new Designer("Artur", 500),
            new Developer("Artur", 500)
        };

        foreach(var employee in emp)
        {
            employee.Work();
        }

        // 2
        List<Appliance> appliances = new List<Appliance>
        {
            new WashingMachine(),
            new TV()
        };

        foreach (var appliance in appliances)
        {
            appliance.TurnOn();
            appliance.TurnOff();
        }

        // 3 
        List<IPayable> ipayables = new List<IPayable>
        {
            new Employee(),
            new Freelancer()
        };

        foreach (var ipayable in ipayables)
        {
            ipayable.PaySalary();
        }
    }
}