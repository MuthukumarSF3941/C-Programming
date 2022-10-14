using System;

namespace Question10;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first value");
        int value1=int.Parse(Console.ReadLine());

        System.Console.WriteLine("enter the second value");
        int value2=int.Parse(Console.ReadLine());
         
         System.Console.WriteLine(value1 > value2);
         System.Console.WriteLine(value1<value2);
         System.Console.WriteLine(value1>=value2);
         System.Console.WriteLine(value1==value2);
         System.Console.WriteLine(value1!=value2);
         System.Console.WriteLine(value1<=value2);
         System.Console.WriteLine(value1>=10 && value2>=10);
         System.Console.WriteLine(value1>=10 || value2>=30);
         System.Console.WriteLine(!(value1>20));
         string value= value1==15? "true":"false";
         System.Console.WriteLine(value);
         System.Console.WriteLine(value1++);
         System.Console.WriteLine(value1--);


       	   

    }
}
