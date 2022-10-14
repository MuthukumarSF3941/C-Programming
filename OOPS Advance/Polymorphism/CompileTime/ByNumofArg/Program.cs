using System;

namespace ByNumofArgs;

class Program
{

    static void Display(int num)
    {
        System.Console.WriteLine("Arguments"+num);
    }

    static void Display(int num1,int num2)
    {
        System.Console.WriteLine("Arguments"+num1+"and"+num2);
    }
    public static void Main(string[] args)
    {
        Display(100);
        Display(100,200);
    }
}
