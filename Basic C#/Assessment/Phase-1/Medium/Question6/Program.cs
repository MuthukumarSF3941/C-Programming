using System;

namespace Question6;

class Program
{
    public static void Main(string[] args)
    {
        int[,] array1=new int[3,3];
        int[,] array2=new int[3,3];
        int[,] final=new int[3,3];
        int n=3;
        System.Console.WriteLine("Enter the values of first array");
        for (int i = 0; i <n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                System.Console.WriteLine($"$Enter array1[{i},{j}] value");
                array1[i,j]=int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("Enter the values of second array");
        for (int i = 0; i <n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                System.Console.WriteLine($"$Enter array2[{i},{j}] value");
                array2[i,j]=int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i <n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                final[i,j]=array1[i,j]+array2[i,j];
                System.Console.Write(final[i,j]+" ");
            }
            System.Console.WriteLine();
        }
    }
}