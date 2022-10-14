using System;

namespace Question9;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter first matrix row and column");
        int m1r=int.Parse(Console.ReadLine());
        int m1c=int.Parse(Console.ReadLine());
        int[,] array1=new int[m1r,m1c];

        System.Console.WriteLine("enter second matric row and column");
        int m2r=int.Parse(Console.ReadLine());
        int m2c=int.Parse(Console.ReadLine());
        int[,] array2=new int[m2r,m2c];
        
        int[,] final=new int[100,100];
        if (m1c==m2r)
        {
            System.Console.WriteLine("Enter first matrix");
            for (int i = 0; i < m1r; i++)
            {
                for (int j = 0; j < m1c; j++)
                {
                    array1[i,j]=int.Parse(Console.ReadLine());
                }
            }
            System.Console.WriteLine("Enter second matrix");
            for (int i = 0; i < m2r; i++)
            {
                for (int j = 0; j < m2c; j++)
                {
                    array2[i,j]=int.Parse(Console.ReadLine());
                }
            }
            System.Console.WriteLine("Multiplication");
            for (int i = 0; i < m1r; i++)
            {
                for (int j = 0; j < m1c; j++)
                {
                    final[i,j]=0;
                    for (int k = 0; k < m2r; k++)
                    {
                        final[i,j]=(array1[i,k]*array2[k,j]+final[i,j]);

                    }
                    System.Console.Write(final[i,j]+" ");
                }
                System.Console.WriteLine();
            }
        }
    }
}