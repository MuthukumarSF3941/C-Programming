using System;

namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter the celcius value");
        int celsius=int.Parse(Console.ReadLine());
         int kelvin=celsius+273;

         int fahrenheit=(celsius*9/5)+32;

         Console.WriteLine($"Kelvin={kelvin}");
         Console.WriteLine($"fahrenheit={fahrenheit}");


         Console.ReadLine();


    }
}

