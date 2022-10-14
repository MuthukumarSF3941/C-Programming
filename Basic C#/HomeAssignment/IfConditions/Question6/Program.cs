using System;

namespace Question6;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter temprature");
        int temprature=int.Parse(Console.ReadLine());

        if(temprature>0)
        {
            if(temprature>=0 && temprature<10)
            {
                System.Console.WriteLine("very cold weather");
            }
            else if (temprature>=10 && temprature<20)
            {
                System.Console.WriteLine("Cold weather");
            }
            else if (temprature>=20 && temprature<30)
            {
                System.Console.WriteLine("Normal in temp");
            }
            else if (temprature>=30 && temprature<40)
            {
                System.Console.WriteLine("its Hot");
            }
            else if(temprature>=40)
            {
                System.Console.WriteLine("its Very hot");
            }
        }
        else
        {
            System.Console.WriteLine("Freezing weather");
        }
    }
}
