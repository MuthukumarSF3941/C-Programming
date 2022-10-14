using System;

namespace Question3;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the input");
        int input=int.Parse(Console.ReadLine());
        
        int a=-1;
        int b=1;
        int i=1;
        while(i<=input)
        {
            int c=a+b;
            
            a=b;
            b=c;
            System.Console.Write(c+" ");
            i++;
        }
    }
}
