using System;
namespace FunctionDelegate;

class Program
{

    static double sum(int a,int b)
    {
        return a+b;
    }

    static double sub(int a,int b)
    {
        return a-b;
    }

    static double Multiply(int a,int b)
    {
        return a*b;
    }
    static double calculator(Func<int,int,double> operation,int x,int y)
    {
        return operation(x,y);
    }
    public static void Main(string[] args)
    {
        System.Console.WriteLine(calculator(sum,10,20));
        System.Console.WriteLine(calculator(sub,40,5));
        System.Console.WriteLine(calculator(Multiply,28,10));
    }
}
