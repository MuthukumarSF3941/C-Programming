using System;
 namespace Question7;

 class Program
 {
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input");
        int input=int.Parse(Console.ReadLine());

        for (int i = 0; i <input; i++)
        {
            
            for (int s = 0; s <input-i-1; s++)
            
                System.Console.Write(" ");
        
            for (int j = 0; j <i+1; j++)
            {
                System.Console.Write("* ");
            }
            System.Console.WriteLine();
        } 
    }
 }
