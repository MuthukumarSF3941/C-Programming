using System;

namespace Question5;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the array size");
        int n=int.Parse(Console.ReadLine());
        int a=0;        //even length
        int b=0;         //odd length
        int c=0,d=0;

        int[] nums=new int[n];

        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine($"Enter the {i+1} value");
            nums[i]=int.Parse(Console.ReadLine());
             if (nums[i]%2==0)
             {
                a++;
             }
             else
             {
                b++;
             }

        }
    int[] even=new int[a];
    int[] odd=new int[b];
    for (int i = 0; i < n; i++)
    {
          if (nums[i]%2==0)
             {
                even[c]=nums[i];
                c++;
             }
             else
             {
                odd[d]=nums[i];
                d++;
             }
    }
    System.Console.WriteLine("Even numbers are");
    for (int i = 0; i <a; i++)
    {
        System.Console.Write(even[i]+" ");
    }
    System.Console.WriteLine("");
     System.Console.WriteLine("odd numbers are");
    for (int i = 0; i <b; i++)
    {
        System.Console.Write(+odd[i]+" ");
    }


    }
}
