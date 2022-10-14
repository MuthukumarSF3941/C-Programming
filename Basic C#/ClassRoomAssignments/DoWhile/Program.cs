using System;

namespace DoWhile;

class Program
{
    public static void Main(string[] args)
    {
        int number;
        string condition="";
        bool temp=true;
        while(temp==true)
        {
         do
         {
            System.Console.WriteLine("Enter the number");
            number=int.Parse(Console.ReadLine());

            if(number%2==0)
            {
                System.Console.WriteLine($"The num is even");
            }
            else
            {
                System.Console.WriteLine("The number is odd");
            }
            System.Console.WriteLine("do u want to continue Yes/no");
            condition=Console.ReadLine().ToLower();
            
            
         } while (condition=="yes");
         if(condition!="yes" && condition!="no")
         {
           System.Console.WriteLine("provoided input is wrong");
           temp=true;
         }
         else if (condition=="no")
         {
            temp=false;
         }
        }
    }
}