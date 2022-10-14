using  System;

namespace Question5;

public class MyClass
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the value");
        int year=int.Parse(Console.ReadLine());
        for (int i = 1; i <= year; i++)
        {
            if((i%4==0 && i%100!=0) ||(i%400==0))
            {
                System.Console.WriteLine(i+" ");
            }
        }
    }
}