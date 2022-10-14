using System;

namespace Question6;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input");
        int input=int.Parse(Console.ReadLine());

        for (int i = 0; i <input; i++)
        {
            
            for (int j = 0; j <=i; j++)
            {
                System.Console.Write("* ");
            }
            System.Console.WriteLine(" ");
        }
    }
}
