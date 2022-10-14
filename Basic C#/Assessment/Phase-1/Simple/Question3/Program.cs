using System;

namespace Question3;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the celsius");
        double celsius=double.Parse(Console.ReadLine());
        double fahrenheight=celsius*(double)9/5*32;
        System.Console.WriteLine($"Fahrenheigh{fahrenheight}");
    }
}