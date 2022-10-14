using System;

namespace Question1;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr={4,10,6,11,8,10};
        System.Console.WriteLine("Enter the number to search from the array");
        int search=int.Parse(Console.ReadLine());
        int count=0;
        

        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i]==search)
            {
                System.Console.WriteLine($"the element is found and the index is:{i}");
              
            }
            else
            {
                
                count++;
                if(count==arr.Length)
                {
                   
                   System.Console.WriteLine("Not found");
                }
            }
           
        }
    }
}
