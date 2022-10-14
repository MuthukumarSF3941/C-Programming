using System;

namespace Question14;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the month");
        DateTime month=DateTime.ParseExact(Console.ReadLine(),"MM",null);
        
        System.Console.WriteLine("enter the salary per day");
        int salary=int.Parse(Console.ReadLine());

        System.Console.WriteLine("enter tha leave taken in days");
        int leave=int.Parse(Console.ReadLine());

     int work_days=DateTime.DaysInMonth(0001,month.Month)-leave;
        int total_salary=work_days*salary;
        System.Console.WriteLine(total_salary);
    }
}
