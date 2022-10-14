using System;

namespace Question8;

class Program
{
    public static void Main(string[] args)
    {
         System.Console.WriteLine("Enter the input");
        int input=int.Parse(Console.ReadLine());
        int k=1;

        for (int i = 0; i <input; i++)
        {
            
            for (int s = 0; s <input-i-1; s++)
            
                System.Console.Write(" ");
        
            for (int j = 0; j <i+1; j++)
            {
                if (k>0 && k<=9)
                {
                    System.Console.Write(k+++" ");
                }
                else
                {
                    System.Console.Write(k+++" ");
                }
            }
            System.Console.WriteLine();
        } 
    }
}
