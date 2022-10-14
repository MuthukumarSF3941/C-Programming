using System;

namespace Question3;

class Program
{
    public static void Main(string[] args)
    {
     System.Console.WriteLine("Enter the number");  
     int number=int.Parse(Console.ReadLine()); 
    
     int temp=number;
     int rem=0;
     int result=0;
     
     while(temp>0)
     {
        rem=temp%10;
        result=rem+(result*10);
        temp=temp/10;
     }
     if(result==number)
     {
        System.Console.WriteLine("It is palindrom");
     }
     else
     {
        System.Console.WriteLine("It is not palindrom");
     }
  
    }
}
