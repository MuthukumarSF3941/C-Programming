using System;

namespace Question8;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your sugar level");
        int input=int.Parse(Console.ReadLine());

        if (input<90)
        {
            System.Console.WriteLine("Low sugar");
        }
        else if(input>=90 && input<130)
        {
            System.Console.WriteLine("Normal");
        }
        else if (input>=130 && input<140)
        {
            System.Console.WriteLine("Medium");
        }
         else if (input>=140 && input<170)
        {
            System.Console.WriteLine("High sugar-try to reduce it from now");
        }
        else
        {
            System.Console.WriteLine("You are a very high sugar patient");
        }
    }
}
