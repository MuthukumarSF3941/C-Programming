using System;

namespace  WhileLoop;

class Program
{
 public static void Main(string[] args)
 {

    //Excercise 1
    int i=0;
    while (i<=25)
    {
        
        if (i>0 && i%2==0)
        {
            System.Console.WriteLine(i);
        }
        i++;
    }

    //Excercise 2

    int number;

    System.Console.WriteLine("Enter the number");
    bool temp=int.TryParse(Console.ReadLine(),out number);

    while (temp==false)
    {

    System.Console.WriteLine("Invalid input format. Please enter the input in number format");
    bool validate=int.TryParse(Console.ReadLine(),out number);
       if(validate==true)
       {
        temp=true;
       }
       else{
        temp=false;
       }
    }
    if(temp==true)
    {
        System.Console.WriteLine($"{number} is valid number");
    }
 }   

}
