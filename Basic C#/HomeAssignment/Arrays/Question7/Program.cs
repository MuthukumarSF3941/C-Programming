using System;

namespace Question5;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the array value");
        int a=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the array size");
        int l=int.Parse(Console.ReadLine());

        int[,] nums=new int[a,l];   
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < l; j++)
            {
                System.Console.WriteLine($"Enter the value[{i}],[{j}]");
                nums[i,j]=int.Parse(Console.ReadLine());

            }

        }
        for (int i = 0; i <a; i++)
        {
         for (int j = 0; j < l; j++)
         {
            System.Console.Write(nums[i,j] +" ");
         }   
         System.Console.WriteLine(" ");
        }

    }
}
