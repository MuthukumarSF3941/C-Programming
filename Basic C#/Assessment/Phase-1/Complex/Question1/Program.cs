using System;

namespace Question1;

class Program
{
    public static void Main(string[] args)
    {
        int[,] a1=new int[2,3];
        int[,] a2=new int[3,2];
        int[,] final=new int[2,2];
       
        
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                System.Console.WriteLine($"Enter the a1[{i},{j}] value");
                a1[i,j]=int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                System.Console.WriteLine($"Enter the a2[{i},{j}] value");
                a2[i,j]=int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
               for (int k = 0; k < 3; k++)
               {
                int temp=0;
                final[i,j]+=a1[i,k]*a2[k,j];
                
               }
            }
        }
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
               System.Console.Write(final[i,j]+" ");
            }
            System.Console.WriteLine();
        }

    }
}
