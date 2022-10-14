using System;

namespace Question3;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the limit");
        int n=int.Parse(Console.ReadLine());
        int[]  nums=new int[n];
        int sum=0;

        for (int i = 0; i < n; i++)
        {
            nums[i]=int.Parse(Console.ReadLine());

        }
        for (int i = 0; i < n; i++)
        {
            sum+=nums[i];
        }
        System.Console.WriteLine($"The sum of all elements in the Array is={sum} ");
    }
}
