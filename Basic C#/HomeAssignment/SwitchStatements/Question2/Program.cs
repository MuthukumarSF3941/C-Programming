using System;

namespace Question2;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter day number 1-7");
        int input=int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1:
            System.Console.WriteLine("Monday");
                break;
            case 2:
            System.Console.WriteLine("Tuesday");
                break;
            case 3:
            System.Console.WriteLine("Wedbesday");
                break;
            case 4:
            System.Console.WriteLine("Thursday");
                break;
            case 5:
            System.Console.WriteLine("Friday");
                break;
            case 6:
            System.Console.WriteLine("Satudurday");
                break;
                case 7:
            System.Console.WriteLine("Sunday");
                break;
            default:
                break;
        }
        
    }
}
