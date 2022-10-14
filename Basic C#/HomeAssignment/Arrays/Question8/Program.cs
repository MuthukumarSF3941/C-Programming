using System;

namespace Question8;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the size of array");
        int n=int.Parse(Console.ReadLine());
    
        int[,] array1=new int[n,n];
        int[,] array2=new int[n,n];
        int[,] array3=new int[n,n];
        System.Console.WriteLine("Enter first array values");
        for (int i = 0; i <n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                 System.Console.WriteLine($"Enter the values of {array1[i,j]}");
                array1[i,j]=int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("");
        }
        System.Console.WriteLine("Enter second array values");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                System.Console.WriteLine($"Enter the values of {array2[i,j]}");
                array2[i,j]=int.Parse(Console.ReadLine());
            }
            System.Console.Write("");
        }
        System.Console.WriteLine("The Addition of two Matrix is");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array3[i,j]=array1[i,j]+array2[i,j];
                System.Console.Write(array3[i,j]+" ");
            }
            System.Console.WriteLine("");
        }
    }
}