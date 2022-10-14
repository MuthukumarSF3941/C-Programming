using System;

namespace Question10;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date in dd/mm/yyyy format");
        DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        DateTime yesterday=date.AddDays(-1);
        DateTime tomorrow=date.AddDays(1);
        System.Console.WriteLine($"yesterday={yesterday.ToShortDateString()}");
        System.Console.WriteLine($"tomorrow={tomorrow.ToShortDateString()}");
    }
}
