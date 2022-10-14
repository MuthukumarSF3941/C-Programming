using System;

namespace Question3;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input");
        int input=int.Parse(Console.ReadLine());

        for (int i = 1; i <=input; i++)
        {
            int cube=i*i*i;
            System.Console.WriteLine($"The number is:{i} and the cube of the {i} is:{cube}");
        }
    }
}
