using System;

namespace Question2;

class Program
{
    public static void Main(string[] args)
    {
        char[] arr={'a','b','c','d','e','f','g','h','j'};

        System.Console.WriteLine("Enter the character to be found");
        char search=char.Parse(Console.ReadLine());

        int beginnig=0;
        int end=arr.Length-1;
        int middle;
        for (int i = beginnig; i <= end; i++)
        {
            middle=(beginnig+end)/2;
            if(arr[middle]==search)
            {
                System.Console.WriteLine("Value found");
                System.Console.WriteLine($"index is {arr[middle]}");
                break;
            }
            else
            {
                if((int)search-96<(int)arr[middle]-96)
                {
                    end=middle-1;
                }
                else
                {
                   beginnig=middle+1;
                }
                
                
            }
        }
    }
}
