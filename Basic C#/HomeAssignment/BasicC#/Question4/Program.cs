using System;
namespace Question5;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter the radius");
        double radius=double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height");
        double height=double.Parse(Console.ReadLine());
        double pi=3.14;

        //3.14* r2 h
        double volume=pi*(radius*radius)*height;

        Console.WriteLine($"Volume : {volume}");
         Console.ReadLine();
         
    }
}
