using System;

namespace Question2;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date and time in dd/mm/yyyy hh:mm:ss am/pm");
        DateTime date=DateTime.Parse(Console.ReadLine());
        System.Console.WriteLine($"complte date:{date.ToString("dd/MM/yyyy hh:mm:ss tt")}");
        System.Console.WriteLine($"{date.ToShortDateString()}");
        System.Console.WriteLine($"{date.ToLongDateString()}");
        System.Console.WriteLine($"{date.ToString("dd/MM/yyyy hh:mm:ss tt")}");
        System.Console.WriteLine($"{date.ToString("dd/MM/yyyy")}");
        System.Console.WriteLine($"{date.ToString("hh:mm:ss tt")}");


    }
}
