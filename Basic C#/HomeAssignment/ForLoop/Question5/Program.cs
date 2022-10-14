using System;

namespace Question5;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the number of terms");
        int number=int.Parse(Console.ReadLine());
        
    
    
         System.Console.Write("The odd numbers are:");  
        int sum=0;
        for (int i = 1; i<=number*2; i++)
        {
           if (i%2==1)
           {
            System.Console.WriteLine(i+" ");
            sum+=i;
           }
            
            
        }
        System.Console.WriteLine($"The sum of odd Natural numbers upto {number} is:{sum}");

    }
}
