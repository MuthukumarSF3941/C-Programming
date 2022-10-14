using System;

namespace Question2;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the array limit");
        int n=int.Parse(Console.ReadLine());
        int[] numbers=new int[n];
        System.Console.WriteLine("Enter values");
         for (int i = 0; i < n; i++)
         {
            numbers[i]=int.Parse(Console.ReadLine());

         }    
         System.Console.WriteLine("The revered string is");
         for (int i = n-1; i>=0; i--)
         {
            System.Console.Write(numbers[i]+" ");
            
         }    
    }
}
