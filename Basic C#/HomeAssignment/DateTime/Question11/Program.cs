using System;
namespace Question11;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date in dd/mm/yyyy format");
        DateTime date1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        DateTime date2=date1.AddYears(1);
        for (int i =0; i < 12; i++)
        {
           DateTime mon=date1.AddMonths(i);
           System.Console.WriteLine($"{mon.ToString("MMMM")}");
           
        }
    }
}