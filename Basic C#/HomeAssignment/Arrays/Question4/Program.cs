using System;

namespace Question4;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enthe the size if the array");

    int n=int.Parse(Console.ReadLine());
    int[] nums=new int[n]; 
    

    for (int i = 0; i < n; i++)
    {
     System.Console.WriteLine("enter the number"); 
     nums[i]=int.Parse(Console.ReadLine());  
    }
int max=nums[n-1];
    int min=nums[0];
    for (int j = 0; j < n; j++)
    {
        if(nums[j]>max)
        {
            max=nums[j];
        }
           if (nums[j]<min)
        {
            min=nums[j];
        }
        
    }
    System.Console.WriteLine("Minimum Number="+min);
    System.Console.WriteLine("Maximum  number="+max);
    }
}