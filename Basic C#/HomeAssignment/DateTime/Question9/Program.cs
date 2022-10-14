using System;

namespace Question9;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first input in yyyy format");
        DateTime date1=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        
        System.Console.WriteLine("Enter the second input in yyyy format");
        DateTime date2=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        for (int i =date1.Year; i <=date2.Year; i++)
        {
            if(DateTime.IsLeapYear(i))
            {
                System.Console.WriteLine($"{i} is a Leap year\n one year from 02/29/{i} is 02/28/{i+1}");
            }
        }
       
    }
}