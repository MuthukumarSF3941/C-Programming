using System;

namespace Question7;

 class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter input a:");
        int a=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter input b");
        int b=int.Parse(Console.ReadLine());


        int result=(a*a)+(2*a*b)+(b*b);

        Console.WriteLine($"output={result}");
        Console.ReadLine();
        
    }
}
