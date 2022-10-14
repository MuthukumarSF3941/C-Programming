using System;

namespace ByType;

public class MyClass
{

    static void Display(int num)
    {
      System.Console.WriteLine("Int type\t:"+num);
    }

    static void Display(string name)
    {
        System.Console.WriteLine("string Type\t:"+name);
    }
    public static void Main(string[] args)
    {
        Display(199);
        Display("Franklin");
    }
}
