using System;

namespace Question11;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the base value");
        int x=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the power value");
        int y=int.Parse(Console.ReadLine());
        int result=1;

        for (int i = 0; i < y; i++)
        {
            result*=x;
        }

         System.Console.WriteLine($"The value of x^y is:{result}");
    }
}