using System;

namespace Question8;

class Program
{
   public static void Main(string[] args)
   {
    Console.WriteLine("Enter the length in meter");
    double length=double.Parse(Console.ReadLine());

    double cm=length*100;
    double mm=cm*10;
    double foot=12*length;
    double inch=39.3*length;
    double mile=0.0006213715277778 *length;

    Console.WriteLine($"cm={cm}\n MM={mm}\n Foot={foot}\n Inch={inch}\n mile={mile}");

    Console.ReadLine();
    System.Console.WriteLine();
    

   }
}
