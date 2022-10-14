using System;

namespace  Question6;
 class Program
 {
   public static void Main(string[] args)
   {
    System.Console.WriteLine("Enter the length of the array");
    int n=int.Parse(Console.ReadLine());
    int[] nums=new int[n];

    for (int i = 0; i <n; i++)
    {
        System.Console.WriteLine($"Enter the {i+1} number");
        nums[i]=int.Parse(Console.ReadLine());
    }
    System.Console.WriteLine("the sorted array in ascending orer is:");
    for (int j = 0; j <n; j++)
    {
        for (int k =j; k <n; k++)
        {
            if(nums[j]>nums[k])
            {
              int temp=nums[j];
              nums[j]=nums[k];
              nums[k]=temp;
            }
        }
        
    }
    foreach (int items in nums)
        {
            System.Console.Write(items+" ");
        }
   }    
 }
