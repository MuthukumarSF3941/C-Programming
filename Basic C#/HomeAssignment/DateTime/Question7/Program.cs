using System;
namespace Question7;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter first date dd/mm/yyyy hh:mm:ss format");
        DateTime date1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
        
        System.Console.WriteLine("Enter second date dd/mm/yyyy hh:mm:ss format");
        DateTime date2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);

        int temp=DateTime.Compare(date1,date2);
        if(temp==-1)
        {
                System.Console.WriteLine($"{date1.ToString("dd/MM/yyyy HH:mm:ss tt")} is earlier than {date2.ToString("dd/MM/yyyy HH:mm:ss tt")}");
        }
        else if(temp==0)
        {
            System.Console.WriteLine("same date and time");
        }
        else
        {
                System.Console.WriteLine($"{date1.ToString("dd/MM/yyyy HH:mm:ss tt")} is later than {date2.ToString("dd/MM/yyyy HH:mm:ss tt")}");
        }
    }
}

