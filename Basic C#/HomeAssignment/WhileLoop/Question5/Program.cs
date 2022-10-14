using System;

namespace Question5;

class Program
{
    public static void Main(string[] args)
    {
       System.Console.WriteLine("Enter the number");
       int number=int.Parse(Console.ReadLine());
       int temp=number;
       int sum=0,n;

       while (temp>0)
       {
        n=temp%10;
        temp=temp/10;
        sum+=n;
       }
       System.Console.WriteLine($"the sum of {number}={sum}");
    }
}
