using System;

namespace Question10;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter rows and columns of the matrix");
        int mr=int.Parse(Console.ReadLine());
        int mc=int.Parse(Console.ReadLine());
        int[,] matrix=new int[mr,mc];

        System.Console.WriteLine("Enter the matrix values");
        for (int i = 0; i <mr; i++)
        {
            for (int j = 0; j < mc; j++)
            {
                matrix[i,j]=int.Parse(Console.ReadLine());            
            }       
        }
        System.Console.WriteLine("before Transpose");
        for (int i = 0; i <mr; i++)
        {
            for (int j = 0; j < mc; j++)
            {
                System.Console.Write(matrix[i,j]+" ");           
            }  
            System.Console.WriteLine();     
        }
        System.Console.WriteLine("after transpose");
        for (int i = 0; i < mr; i++)
        {
            for (int j = 0; j < mc; j++)
            {
                System.Console.Write(matrix[j,i]+" " );
            }
            System.Console.WriteLine();
        }
    }
}