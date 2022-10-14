using System;

namespace Question6;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the radius");
        double radius=double.Parse(Console.ReadLine());

        System.Console.WriteLine("Choose operation\n 1.Area\n 2.Perimeter\n 3.Diameter");
        int option=int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
            System.Console.WriteLine("Area="+(3.14*radius*radius));
                break;
            case 2:
            System.Console.WriteLine("Perimeter="+(2*3.14*radius));
                break;
            case 3:
            System.Console.WriteLine("Diameter="+(2*radius));
                break;
            default:
            System.Console.WriteLine("invalid option");
                break;
        }
        
    }
}
