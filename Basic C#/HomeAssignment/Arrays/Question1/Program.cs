using System;

namespace Question1;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter length of array");
        int l=int.Parse(Console.ReadLine());

        int[] nums=new int[l];
        for (int i = 0; i < l; i++)
        {
            nums[i]=int.Parse(Console.ReadLine());
        }
        foreach (int num in nums)
        {
            System.Console.Write(num+" ");
        }

    }
}
