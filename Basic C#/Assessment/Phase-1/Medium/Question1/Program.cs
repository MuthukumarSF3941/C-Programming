using System;

namespace Question1;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the salary");
        double sal=double.Parse(Console.ReadLine());

        double da,hra,tax=6,insurance=1;

        double deduction=tax+insurance;
        if(sal<=10000)
        {
            hra=sal*0.20;
            da=sal*0.80;
            double salary=sal+hra+da;
            double annualSal=(salary*12)-(salary*deduction/100);
            double inHand=annualSal/12;

            System.Console.WriteLine($"Annual salary={(int)annualSal}\n inHand salary={(int)inHand}");
        }
        else if(sal<=20000)
        {
            hra=sal*0.25;
            da=sal*0.90;
            double salary=sal+hra+da;
             double annualSal=(salary*12)-(salary*deduction/100);
            double inHand=annualSal/12;

            System.Console.WriteLine($"Annual salary={(int)annualSal}\n inHand salary={(int)inHand}");
        }
        else if(sal>20000)
        {
            hra=sal*0.30;
            da=sal*0.95;
            double salary=sal+hra+da;
             double annualSal=(salary*12)-(salary*deduction/100);
            double inHand=annualSal/12;

            System.Console.WriteLine($"Annual salary={(int)annualSal}\n inHand salary={(int)inHand}");
        }
        else{
            System.Console.WriteLine("Invalid input");
        }

    }
}