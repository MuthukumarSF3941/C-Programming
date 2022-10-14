using System;

namespace Question3;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first number");
        int number1=int.Parse(Console.ReadLine());

        System.Console.WriteLine("enter the second number");
        int number2=int.Parse(Console.ReadLine());

        swap(number1,number2);


        void swap(int a,int b)
        {
           int temp=a;
           a=b;
           b=temp;
           System.Console.WriteLine($"The first number is:{a} and the second number is {b}");
        }
    }
}
