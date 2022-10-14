using System;

namespace InsertionSort;

public class MyClass
{
    public static void Main(string[] args)
    {
        int[] arr={18,19,1,5,7,3,20};
        int temp,k,j=0;

        for (int i = 1; i < arr.Length; i++)
        {
            k=arr[i];
             j=i-1;
             while(j>=0 && k<arr[j])
             {
                temp=arr[j];
                arr[j]=arr[j+1];
                arr[j+1]=temp;
                j--;
             }
        }
        foreach (int nums in arr)
        {
            System.Console.Write(nums+" ");
        }
    }
}