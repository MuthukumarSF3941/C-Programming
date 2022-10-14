using System;

namespace Question1;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the inches");
        float inch=float.Parse(Console.ReadLine());
        float centiMeter=inch*(float)2.54;
        System.Console.WriteLine($"CentiMeter={centiMeter}");

    }
}