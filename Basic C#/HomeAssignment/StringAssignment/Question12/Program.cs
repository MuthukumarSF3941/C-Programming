using System;

namespace Question12;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Entetr the number of string with space");
        string num=Console.ReadLine();
        
        char[] nums=num.ToCharArray();
        int min=nums[0];
        int max=nums[nums.Length-1];

        for (int i = 0; i < nums.Length; i++)
        {
         if(nums[i]>=48 && nums[i]<=57)
           {
            if(nums[i]<min)
            {
                min=nums[i];
            }
            else if (nums[i]>max)
            {
                max=nums[i];
            }
           }
        }
        System.Console.WriteLine($"minimun number:{(int)min-48}");
        System.Console.WriteLine($"maximum number is :{(int)max-48}");
    }
}