using System;

namespace Question7;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the starting number");
        int start=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the difference");
        int diff=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the number of elements");
        int element=int.Parse(Console.ReadLine());
        int sum=0;

        System.Console.WriteLine("Output series:");

        for (int i = 0; i < element; i++)
        {
         if(i==0)
         {
            start=start;
           
         }
         else
         {
             start+=diff;
         }
         sum=sum+start;
         System.Console.Write(start+" ");
        

        }
         System.Console.WriteLine($"\n Sum of series is:{sum}");
        
    }
}