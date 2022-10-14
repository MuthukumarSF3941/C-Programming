using System;

namespace Question8;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the speed");
        decimal speed=decimal.Parse(Console.ReadLine());
        if (speed>=0 && speed<=10)
        {
            System.Console.WriteLine("slow");
        }
        else if (speed>10 && speed<50)
        {
            System.Console.WriteLine("Average");
        }
        if (speed>=50 && speed<150)
        {
            System.Console.WriteLine("fast");
        }
        else if (speed>=150 && speed<1000)
        {
            System.Console.WriteLine("Ultra Fast");
        }
        else if(speed>1000)
        {
            System.Console.WriteLine("Extremly fast");
        }
        else{
            System.Console.WriteLine("Not valid");
        }

    }
}