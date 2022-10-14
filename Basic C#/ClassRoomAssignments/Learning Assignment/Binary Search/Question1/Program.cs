using System;

namespace Question1;

public class MyClass
{
    public static void Main(string[] args)
    {
        int[] arr={1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
        int biginning,middle,end,value;
        System.Console.WriteLine("Enter the number to find");
        value=int.Parse(Console.ReadLine());
        biginning=0;
        end=arr.Length-1;
        
      

        for (int i = biginning; i < end; i++)
        {
              middle=(biginning+end)/2;
            if(arr[middle]==value)
            {
                System.Console.WriteLine($"Value found and index is :{middle}");
                break;
            }
            else
            {
               

                if(value<arr[middle])
                {
                  end=middle-1;
               
                }
              
                else
                {
                    biginning=middle+1;
                }
            }
        }

        
    }
}