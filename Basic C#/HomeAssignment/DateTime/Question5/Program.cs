using System;

namespace Question5;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date dd/mm/yyyy");
        DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        for (int i = 0; i <10; i++)
        {
            DateTime dates=date.AddYears(i);
            System.Console.WriteLine($"{dates.ToString("dd/MM/yyyy")}:day:{dates.DayOfYear} of{dates.Year}");
        }
    }
}
