using System;

namespace BubbleSort;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr={18,19,1,5,7,3,20};
        int temp=0;

        //sorting 
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if(arr[j]>arr[i])
                {
                    temp=arr[j];
                    arr[j]=arr[i];
                    arr[i]=temp;
                }
            }

        }
        foreach(int nums in arr)
        {
            System.Console.Write(nums+" ");
        }
    }
}
