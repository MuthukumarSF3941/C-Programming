using System;

namespace SwitchStatement;

class Program
{
    public static void Main(string[] args)
    {

        System.Console.WriteLine("Enter first number");
        double a=double.Parse(Console.ReadLine());

        System.Console.WriteLine("enter second number");
        double b=double.Parse(Console.ReadLine());

        System.Console.WriteLine("enter your choice");
        System.Console.WriteLine("'+' for Addition\n '-' for Subtraction\n '*' for multiplication\n '/' for Division\n '%' for modulus ");
        char choice=char.Parse(Console.ReadLine());

        switch (choice)
        {
            case '+':
            System.Console.WriteLine("Result="+(a+b));
                break;
             case '-':
            System.Console.WriteLine("Result="+(a-b));
                break;
             case '*':
            System.Console.WriteLine("Result="+(a*b));
                break;
             case '/':
            System.Console.WriteLine("Result="+(a/b));
                break;
             case '%':
            System.Console.WriteLine("Result="+(a%b));
                break;
            default:
            System.Console.WriteLine("Operation invalid");
                break;
        }
        

    }
}