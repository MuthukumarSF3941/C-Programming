using System;

namespace Question4;

class Program
{
    public static void Main(string[] args)
    { 
        System.Console.WriteLine("enter first number");
        double input1=double.Parse(Console.ReadLine());

        System.Console.WriteLine("enter second number");
        double input2=double.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter your Choice\n 1-Addition\n 2-Subtraction\n 3-multiplication\n 4-Division\n 5-Exit");
        int choice=int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
            System.Console.WriteLine(input1+input2);
                break;
            case 2:
            System.Console.WriteLine(input1-input2);
                break;
            case 3:
            System.Console.WriteLine(input1*input2);
                break;
            case 4:
            System.Console.WriteLine(input1/input2);
                break;
            case 5:
            System.Console.WriteLine("excited");
                break;
            default:
            System.Console.WriteLine("Invalid operation");
                break;
        }
        
    }
}
