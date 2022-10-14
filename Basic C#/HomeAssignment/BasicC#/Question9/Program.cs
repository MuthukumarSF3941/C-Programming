using System;

namespace Question9;

class Program
{
   public static void Main(string[] args)
   {
    System.Console.WriteLine("Enter the speed per km/h");
   int speed=int.Parse(Console.ReadLine());

    System.Console.WriteLine("Enter the time in seconds");
    int seconds=int.Parse(Console.ReadLine());

    //Distance travelled = Speed in km/hr *seconds * 5/18

     double result=(double)(speed*seconds)*(double)5/18;
     int distance = (int)result;

     System.Console.WriteLine($"Distance travelled= {distance} meters");


   }
}
