using System;

namespace Question5;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the physics marks");
        int physics=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the chemistry marks");
        int chemistry=int.Parse(Console.ReadLine());

        System.Console.WriteLine("enter the maths marks");
        int maths=int.Parse(Console.ReadLine());

        int total=maths+physics+chemistry;

        double percentage=(total)*100/300;
        System.Console.WriteLine($"percentage={percentage}");

        if (percentage>=75)
        {
            System.Console.WriteLine("Eligible for admission");
        }
        else
        {
            System.Console.WriteLine("Not eligible for admission");
        }
        Console.ReadLine();
        
    }
}
