using System;

namespace Question1;

class Program
{
    public static void Main(string[] args)
    {
        string choice="";
        do
        {
            System.Console.WriteLine("Enter the number");
            int input=int.Parse(Console.ReadLine());

            if (input%2==0)
            {
                System.Console.WriteLine("The number is Even Number");
            }
            else
            {
                System.Console.WriteLine(("The number is ODD Number"));
            }
            
            System.Console.WriteLine("Do You want to continue Yes/no");
            choice=Console.ReadLine().ToLower();
            
            
        } while (choice=="yes");
        
    }
}
