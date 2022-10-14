using System;

namespace Question4;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the limit of the series");
        int limit=int.Parse(Console.ReadLine());
        int a,b;
        fibonacci(limit);

        void fibonacci(int n)
        {
            int a=-1,b=1;
            System.Console.WriteLine("Fibonacci series");
            for (int i = 0; i < limit; i++)
            {
                int c=a+b;
                a=b;
                b=c;

                System.Console.Write(c+" ");
            }
        }
    }
}
