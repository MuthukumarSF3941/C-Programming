using System;

namespace Question9;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter The Number");
        int Number=int.Parse(Console.ReadLine());
        int n=Number.ToString().Length;
        int temp=Number;
        int value=0;
        for (int i = 0; i < n; i++)
        {
            int a=temp%10;
            temp=temp/10;
             value+=a*a*a;
             
            
        }
        if (value==Number)
        {
            System.Console.WriteLine($"{Number} is an Amstrong number");
        }
        else
        {
          System.Console.WriteLine($"{Number} is not an Amstrong number");   
        }
    }
}
