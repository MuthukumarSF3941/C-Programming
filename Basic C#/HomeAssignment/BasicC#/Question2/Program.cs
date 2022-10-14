using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter first number");
        int num1=int.Parse(Console.ReadLine());

        Console.WriteLine("enter the second number");
        int num2=int.Parse(Console.ReadLine());

        Console.WriteLine($"Addition:{num1}+{num2}="+(num1+num2));
        Console.WriteLine($"substraction:{num1}-{num2}="+(num1-num2));
        Console.WriteLine($"multiplication:{num1}x{num2}="+(num1*num2));
        Console.WriteLine($"division:{num1}/{num2}="+(num1/num2));
        Console.WriteLine($"modulo:{num1}%{num2}="+(num1%num2));


        Console.ReadLine();
        
    }
}
