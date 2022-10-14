using System;

namespace SingleCastingDelegate;

public delegate int calculator(int n);

public class Program
{
     static int value=10;
     public static int AddNum(int number)
     {
        value+=number;
        return value;

     }

     public static int MulNum(int number) 
     {
        value*=number;
        return value;
     }

     public static int Getnum()
     {
        return value;
     }
    public static void Main(string[] args)
    {

        //create delegate instance
        calculator n1=new calculator(AddNum);

        calculator n2=new calculator(MulNum);

        //calling the methods using delegate objects
        n1(30);
        System.Console.WriteLine("Addition:"+Getnum());
        n2(45);
        System.Console.WriteLine("Multiplication:"+Getnum());

       
     }
    
}
