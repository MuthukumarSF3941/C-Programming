using System;

namespace Qustion1;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your grade\n E-Excellent\n V-VeryGoog\n G-Good\n A-average\n F-Fail");
        char grade=char.Parse(Console.ReadLine());

        switch (grade)
        {
            case 'E':
            System.Console.WriteLine("Excellent");
                break;
             case 'V':
            System.Console.WriteLine("Very good");
                break;
             case 'G':
            System.Console.WriteLine("Good");
                break;
             case 'A':
            System.Console.WriteLine("Average");
                break;
            case 'F':
            System.Console.WriteLine("Fail");
                break;
            default:
                break;
        }
        
    }
}



