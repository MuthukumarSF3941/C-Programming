using System;

namespace Question4;

class Program
{
    public static void Main(string[] args)
    {
        bool temp;
        int number;
        do
        {
          System.Console.WriteLine("Enter the number");
          temp=int.TryParse(Console.ReadLine(),out number);
        if(number>0 && number<=10)
        {
            
        }
        else
        {
            temp=false;
        }

        } while (!temp);
        System.Console.WriteLine($"output={number}");
    }
}
