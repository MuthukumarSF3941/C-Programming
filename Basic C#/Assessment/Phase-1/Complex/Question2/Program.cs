using System;

namespace Question2;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input");
        int input=int.Parse(Console.ReadLine());
        int j=0;
        int mul=1,fact=1;
        double sum=1+2;
        while (j<=input)
        { 
          if(j>=2)
          {

            for (int i =1; i <=j ; i++)
            {
                mul*=2;
                fact*=i;
                
            }
          sum+=(double)mul/fact;
          mul=1;
          fact=1;
           }
           j++;
        }
        System.Console.WriteLine(sum);
    }
}