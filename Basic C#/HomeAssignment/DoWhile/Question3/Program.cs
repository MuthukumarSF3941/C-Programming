using System;

namespace Question3;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the num");
        int limit=int.Parse(Console.ReadLine());
        int a=-1,b=1,c;
        int i=0;
        System.Console.WriteLine("The Fibonacci series is:");

        do
        {
            c=a+b;
            a=b;
            b=c;
            System.Console.Write(c+" ");
           i++;
        } while (i<limit);

    }
}