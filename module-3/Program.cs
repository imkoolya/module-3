using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        var name = Console.ReadLine();
        Console.Write("Enter your age: ");
        var age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your name is {0} and age is {1} ", name, age);      
        Console.Write("Enter your birthdate: ");
        var birthdate = Console.ReadLine();
        Console.WriteLine("Your birthdate: {0}", birthdate);
        Console.Write("What is your favorite day of week? ");
        weekdays day = (weekdays)int.Parse(Console.ReadLine());
        Console.WriteLine("Your favorite day is {0}", day);
        Console.ReadKey();
    }
    enum weekdays : byte
    {
        monday = 1,
        tuesday = 2,
        wednesday = 3,
        friday = 4,
        saturday = 5,
        sunday = 6,
    }
}

