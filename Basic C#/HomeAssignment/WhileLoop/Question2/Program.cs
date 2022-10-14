using System;

namespace Question2;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input count");
        int input=int.Parse(Console.ReadLine());

        int i=1;
        int sum=0;
        while (i<=input)
        {
            System.Console.Write(i+" ");
            sum+=i*i;
            i++;
            
        }
        System.Console.WriteLine($"\nsum of the squares of the given series-{sum}");
    }
}

