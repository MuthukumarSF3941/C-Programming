using System;

namespace Question9;

class Program
{
    public static void Main(string[] args)
    {
        int sal=500;
        int days;
        int workDay;
        int salary;

        System.Console.WriteLine("Enter the month of the year in words\n january\n february\n march\n may\n june\n july\n agust\n september\n october\n november\n december");
        string month=Console.ReadLine().ToLower();
        System.Console.WriteLine("Enter tha number of leave taken");
        int leave=int.Parse(Console.ReadLine());

        if(month=="january" || month=="march" || month=="may" || month=="july" || month=="september" || month=="november")
        {
            days=31;
            workDay=days-leave;
            salary=workDay*sal;
            System.Console.WriteLine($"Total salary={salary}");
        }
        else if(month=="april" || month=="june" || month=="agust" || month=="october" || month=="december")
        {
            days=30;
            workDay=days-leave;
            salary=workDay*sal;
            System.Console.WriteLine($"Total salary={salary}");
        }
        else if(month=="february")
        {
                days=28;
            workDay=days-leave;
            salary=workDay*sal;
            System.Console.WriteLine($"Total salary={salary}");
        }
        else
        {
            System.Console.WriteLine("Invalid month");
        }
       
        
    }
}
