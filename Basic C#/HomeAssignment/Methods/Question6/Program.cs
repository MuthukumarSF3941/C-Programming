using System;

namespace Question6;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number");
        int number=int.Parse(Console.ReadLine());
        int fact=1;
        int output=factorial(number);
        System.Console.WriteLine($"The factorial of number{number} is :{output}");

        int factorial(int number)
        {
          for (int i = 1; i <=number; i++)        
          {
            fact*=i;
          }
          return fact;
        }
    }
}
