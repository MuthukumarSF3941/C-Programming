using System;

namespace Question4;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter value in indian currency");
        double india=double.Parse(Console.ReadLine());
        double usd=122/india;
        double eur=127/india;
        double cny=879/india;

        System.Console.WriteLine($"INDIA:{india}\n USD;{usd}\n EUR:{eur}\n CNY:{cny}" );
    }
}