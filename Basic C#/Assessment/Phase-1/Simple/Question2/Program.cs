using System;
namespace Question2;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the radius");
        double radius=double.Parse(Console.ReadLine());
        double area=3.14*(radius*radius);
        double periMeter=2*3.14*radius;
        System.Console.WriteLine($"Area:{area}");
        System.Console.WriteLine($"PeriMeter:{periMeter}");
    }
}