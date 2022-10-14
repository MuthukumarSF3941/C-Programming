using System;

namespace Question10;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a number");
        int input=int.Parse(Console.ReadLine());
        int count=0;
        for (int i = 1; i <=input; i++)
        {
          
            if (input%i==0 && !(input==1))
            {
              count++;
            }  
        }
          if (count==2)
            {
                System.Console.WriteLine($"the number {input} is a prime number");
            }
            else
            {
                System.Console.WriteLine("Not a prime number");
            }
            count=0;
        
        
       
    }
}
