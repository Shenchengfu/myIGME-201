using System;


public struct employee
{
    public string sName;
    public double dSalary;

    public employee(string name, double salary)
    {
        sName = name;
        dSalary = salary;
    }

}

public class HelloWorld
{
    employee david = new employee("David", 30000);

    public static void Main(string[] args)
    {

        string inputName = "";

        Console.WriteLine("Please input the user's name: ");
        inputName = Console.ReadLine();

        if (GiveRaise(david))
        {
            Console.WriteLine("Congratuations " + sName + "!");
        }
    }

    public static bool GiveRaise(employee e)
    {
        if (e.sName == sName)
        {
            e.dSalary += 19999.99;
        }
        return e.sName == sName;
    }
}
