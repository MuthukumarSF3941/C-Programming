using System;

namespace Question2;

class Program
{
    public static void Main(string[] args)
    {
        double sum=0;
        for (int i = 0; i <=10; i++)
        {
            sum+=i;
        }
        double average=sum/10;
        System.Console.WriteLine($"sum:{sum}");
        System.Console.WriteLine($"Average={average}");
    }
}
