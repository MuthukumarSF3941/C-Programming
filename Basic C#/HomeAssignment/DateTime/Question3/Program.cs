using System;

namespace Question3;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the date in dd/mm/yyyy HH:mm:ss");
        DateTime date=DateTime.Parse(Console.ReadLine());
        System.Console.WriteLine($"year={date.Year}\n month={date.Month}\n date={date.Day}\n hour={date.Hour}\n minutes={date.Minute}\n seconds={date.Second}\n millisecond={date.Millisecond}");
    }
}
