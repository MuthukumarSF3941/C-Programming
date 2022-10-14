using System;

namespace Question2;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your age");
        int age=int.Parse(Console.ReadLine());

        if (age>18)
        {
            System.Console.WriteLine("Congradulation you are eligible for castig your vote");
        }
        else
        
        {
            System.Console.WriteLine("you are not eligible for vote");
        }
    }
}
