using System;

namespace Question13;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter tha table value");
        int table=int.Parse(Console.ReadLine());

        for (int i = 0; i <= 20; i++)
        {
            System.Console.WriteLine($"{table}*{i}={table*i}");
        }
    }
}