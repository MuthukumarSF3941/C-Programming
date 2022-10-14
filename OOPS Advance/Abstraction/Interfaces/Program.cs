using System;

namespace Interfaces;

class Program
{
    public static void Main(string[] args)
    {
         Draw rectangle=new Draw();

        System.Console.WriteLine("enter length");
        rectangle.Length=int.Parse(Console.ReadLine());

        System.Console.WriteLine("enter breadth");
        rectangle.Breadth=int.Parse(Console.ReadLine());

        rectangle.caluculateArea();

    }
}
