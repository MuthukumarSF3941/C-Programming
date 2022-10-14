using System;
namespace Question13;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date in dd/MM/yyyy format");
        DateTime input=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        
    }
}