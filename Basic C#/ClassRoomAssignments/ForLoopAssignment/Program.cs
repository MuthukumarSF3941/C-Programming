using System;

namespace ForLoopAssignment;

class Program
{
    public static void Main(string[] args)
    {

        //Excercise 1
        for (int i = 0; i < 25; i++)
        {
            if(i>1 && i%2==0)
            {
                System.Console.WriteLine(i);
            }
        }

        //Excercise 2

        System.Console.WriteLine("Enter initial value");
        int initial=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the final value");
        int final=int.Parse(Console.ReadLine());
         
         int total=0;
        for (int j = initial; j <= final; j++)
        {
            total+=(j*j);
        }
        System.Console.WriteLine($"sum of squares={total}");
    }
}
