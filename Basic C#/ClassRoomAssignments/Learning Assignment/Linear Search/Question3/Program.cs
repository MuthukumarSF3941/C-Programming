using System;

namespace Question3;

class Program
{
    public static void Main(string[] args)
    {
        string[] arr={"muthu","kumar","john","franklin","jose"};

        System.Console.WriteLine("Enter the string to search");
        string search=Console.ReadLine().ToLower();
        int count=0;

        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i]==search)
            {
                System.Console.WriteLine($"Element found at index of {i}");
            }
            else{
                count++;
                if(count==arr.Length)
                {
                    System.Console.WriteLine("Not found");
                }
            }
        }
        

    
    }
}
