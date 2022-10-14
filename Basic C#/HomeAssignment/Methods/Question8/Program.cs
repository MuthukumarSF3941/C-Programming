using System;

namespace Question8;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first number");
        int mark1=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the second mark");
        int mark2=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the third mark");
        int mark3=int.Parse(Console.ReadLine());
        int sum=0;
        int percentage;
        marks(mark1,mark2,mark3);


        void marks(int a,int b,int c)
        {
          int total=a+b+c;
          percentage=100*total/300;
           System.Console.WriteLine($"mark1:{mark1}\n mark2={mark2}\n mark3={mark3}\n percentage={percentage}%");
        }
    }
}
