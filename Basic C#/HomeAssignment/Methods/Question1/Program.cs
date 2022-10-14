using System;

namespace Methods;

class Program
{
    public static void Main(string[] args)
    {
             

            System.Console.WriteLine("Enter first number");
            int number1=int.Parse(Console.ReadLine());
            System.Console.WriteLine(("Enter second number"));
            int number2=int.Parse(Console.ReadLine());

            int sum=Addition(number1,number2);
             System.Console.WriteLine("The sum of two numbers is:"+sum);
            int sub=Subtraction(number1,number2);
            System.Console.WriteLine("the difference of two numbers:"+sub);

            int product=Multiplication(number1,number2);
            System.Console.WriteLine("the product of two numbers:"+product);

            float div=Division(number1,number2);
            System.Console.WriteLine("the quoient of two numbers:"+div);

           
         int Addition(int a,int b)
            {
              int sum=a+b;
              return sum;
            }
            int Subtraction(int a,int b)
            {
              int sub=a-b;
              return sub;
            }
            int Multiplication(int a,int b)
            {
              int product=a*b;
              return product;
            }
            float Division(float a,float b)
            {
              float div=a/b;
              return div;
            }
    }
}
