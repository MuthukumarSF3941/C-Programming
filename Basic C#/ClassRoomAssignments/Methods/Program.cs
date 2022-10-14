using System;

namespace Methods;

class Program
{
    public static void Main(string[] args)
    {
        int a=10,b=23;
        int val1=25,val2=5;
        int sum1=Addition(a,b);
        System.Console.WriteLine(sum1);
        Subtraction(21,10);
        int mul=Multiplication();
        System.Console.WriteLine("product is:"+mul);
        
        Division();
        int Addition(int a,int b)
        {
            int sum=a+b;
            return sum;

        }
        void Subtraction(int a,int b)
        {
            int sub=a-b;
            System.Console.WriteLine("sub="+sub);
        }
        int Multiplication()
        {
            int a=5;
            int b=8;
            int mul=a*b;
            return mul;
        }
        
        void Division()
        {
            int div=val1/val2;
            System.Console.WriteLine(div);
        }
    }
}
