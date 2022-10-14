using System;

namespace Question2;

public class MyClass
{
    public static void Main(string[] args)
    {
        char[] arr={'q','e','t','y','o','k'};

        System.Console.WriteLine("Enter the character to search from the array");
        char search=char.Parse(Console.ReadLine());
        int count=0;

        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i]==search)
            {
                System.Console.WriteLine($"Element is found at index {i}");
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
