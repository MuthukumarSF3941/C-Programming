using System;
namespace Question6;

class Program
{
    public static void Main(string[] args)
    {
        DateTime today=DateTime.Now;
        DateTime then=today.AddDays(40);
        System.Console.WriteLine($"Today={today.ToString("MM/dd/yyyy HH:mm:ss tt")}\n {then.DayOfWeek}");
    }
}