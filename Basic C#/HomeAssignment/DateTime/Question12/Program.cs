using System;

namespace Question12;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter month");
        DateTime month=DateTime.ParseExact(Console.ReadLine(),"MM",null);

        System.Console.WriteLine("enter year");
        DateTime year=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        int num=DateTime.DaysInMonth(year.Year,month.Month);
        System.Console.WriteLine($"the number of days in a month {month.ToString("MMMM")} is:{num}");

    }
}