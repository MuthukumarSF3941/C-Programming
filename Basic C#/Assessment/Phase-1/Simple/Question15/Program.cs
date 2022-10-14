using System;

namespace Question15;

class Program
{
    public static void Main(string[] args)
    {
        int count=0;
        System.Console.WriteLine("Enter the number");
        int number=int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            if(number%i==0 )
            {
                count++;
            }
        }
        if(count==2)
        {
            System.Console.WriteLine("It is a prime number");
        }
        else
        {
            System.Console.WriteLine("It is not a prime number");
        }
    }
}
