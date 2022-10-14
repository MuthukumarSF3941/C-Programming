using System;

namespace Question4;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date in dd/mm/yyyy format");
        DateTime date=DateTime.Parse(Console.ReadLine());
        System.Console.WriteLine(date.DayOfWeek);
    }
}
