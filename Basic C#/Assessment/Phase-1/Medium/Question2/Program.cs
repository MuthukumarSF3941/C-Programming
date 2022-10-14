using System;

namespace Question2;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input number of terms");
        int input=int.Parse(Console.ReadLine());
        System.Console.WriteLine($"Here is the fibonacci series upto {input} series");

    int a=-1,b=1,c;
    for (int i = 0; i < input; i++)
    {
        c=a+b;
        a=b;
        b=c;
        System.Console.Write(c+" ");
    }
    }
}
