using System;

namespace Question2;

class Program
{
    public static void Main(string[] args)
    {
        int sum=0;
        int number;

        do
        {
            System.Console.WriteLine("Enter the number");
             number=int.Parse(Console.ReadLine());

            if (number>0)
            {
                sum+=number;
            }
            
        } while (number>0);
        System.Console.WriteLine($"The sum is:{sum}");
    }
}
