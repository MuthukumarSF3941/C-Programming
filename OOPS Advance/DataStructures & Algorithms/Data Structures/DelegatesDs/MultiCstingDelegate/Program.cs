using System;

namespace MultiCstingDelegate;

public delegate int NumberChanger(int n);

public class MyClass
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

        //multicasting deligate instances
        NumberChanger n;
        NumberChanger n1=new NumberChanger(AddNum);

        NumberChanger n2=new NumberChanger(MulNum);

        n=n1;
        n+=n2;

        //calling Multicasting
        n(5);System.Console.WriteLine("Value of number:"+Getnum());

        //calling the methods using delegate objects
        n1(30);
        System.Console.WriteLine("Addition:"+Getnum());
        n2(45);
        System.Console.WriteLine("Multiplication:"+Getnum());

       
     }
}
