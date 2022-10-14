using System;

namespace MethodAssignment;

class Program
{
    public static void Main(string[] args)
    {
        string option;
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
        do
        {
            System.Console.WriteLine("Enter the operation\n 1.Addition\n 2.Subtraction\n 3.Multiplication\n 4.Division");
            int choice=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter first number");
            int number1=int.Parse(Console.ReadLine());
            System.Console.WriteLine(("Enter second number"));
            int number2=int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                int sum=Addition(number1,number2);
                System.Console.WriteLine("The sum of two numbers is:"+sum);
                    break;
                case 2:
                  int sub=Subtraction(number1,number2);
                System.Console.WriteLine("the difference of two numbers:"+sub);
                    break;
                case 3:
                 int product=Multiplication(number1,number2);
                System.Console.WriteLine("the product of two numbers:"+product);
                    break;
                  
                case 4:
                    float div=Division(number1,number2);
                  System.Console.WriteLine("the quoient of two numbers:"+div);
                    break;
                default:
                    break;
            }
    
            System.Console.WriteLine("Do you want to continue Yes/No");
            option=Console.ReadLine().ToLower();
            
        } while (option=="yes");
    }
}
