using System;

namespace Question5;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the basic salary");
        double basic=double.Parse(Console.ReadLine());
         double da=basic*.10;
         double hra=basic*.10;
         double annualIncome=(basic+da+hra)*12;
         System.Console.WriteLine($"Annual income={annualIncome-annualIncome*0.05}");

    }
}
