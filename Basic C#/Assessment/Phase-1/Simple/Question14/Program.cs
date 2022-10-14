using System;

namespace Question14;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number");
        int n=int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j =i; j < n; j++)
            {
                System.Console.Write(j+" ");
            }
            System.Console.WriteLine();
        }    
    }
}
