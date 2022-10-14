using System;

namespace Question4;

class Program
{
 public static void Main(string[] args)
 {
   System.Console.WriteLine("Enter the first Number"); 
   int firstNum=int.Parse(Console.ReadLine());

   System.Console.WriteLine("Enter the second numbner");
   int secondNum=int.Parse(Console.ReadLine());

   System.Console.WriteLine("Enter the third num");
   int thirdNum=int.Parse(Console.ReadLine());

   if(firstNum>secondNum && firstNum>thirdNum)
   {
    System.Console.WriteLine("The first number is greatest among three");

   }
     else if(firstNum<secondNum && secondNum>thirdNum)
   {
    System.Console.WriteLine("The second number is greatest among three");
    
   }
   else
   {
      System.Console.WriteLine("The third number is greatest among three");
   }
   Console.ReadLine();
   
 }   
}
