using System;

namespace IfStatment;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your marks");
        int mark=int.Parse(Console.ReadLine());

        if(mark>0 && mark<=100)
        {
           if(mark>80)
           {
            System.Console.WriteLine("Grade A");
           }
           else if(mark>60 && mark<=80)
           {
                       System.Console.WriteLine("Grade B");
           }
           else if(mark>35 && mark<=60)
           {
            System.Console.WriteLine("Grade c");
           }
           else
           {
            System.Console.WriteLine("Grade D");
           }
        }
        else
        {
           System.Console.WriteLine("Invalid input");
        }
    }
}
