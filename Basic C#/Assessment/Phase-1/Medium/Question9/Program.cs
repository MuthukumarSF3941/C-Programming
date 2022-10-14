using  System;

namespace Question9;
 class Program
 {
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input");
        int n=int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < i-1; i++)
            {
                System.Console.Write(" ");
            }
            for (int k = 0; k < n; k++)
            {
                System.Console.Write("*");
            }
            System.Console.Write("");
        }
    }
 }