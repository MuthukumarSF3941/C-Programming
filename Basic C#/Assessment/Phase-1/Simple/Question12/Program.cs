using System;

namespace Question12;

class Program
{
    
    public static void Main(string[] args)
    {
        int result=0;
        for (int i = 0; i <= 99; i++)
        {
            if(i%2==1)
            {
              result+=i*i;
            }
        }
        System.Console.WriteLine($"The value of squares of odd numbers between 1-99 is:{result}");
    }
}