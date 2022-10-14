using System;

namespace Questiom5;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number");
        int number=int.Parse(Console.ReadLine());
        int count;
        prime(number);

        void prime(int number)
        {
          count=0;
          for (int i = 1; i <=number; i++)
          {
            if (number%i==0)
            {
                count++;
            }
          }
          if (count==2)
          {
            System.Console.WriteLine($"{number} is a prime number");
          }
          else
          {
             System.Console.WriteLine($"{number} is not  a prime number");
          }
          count=0;
        }
    }
}
