using System;
namespace Question1;
class Program

{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter your name:");
        string name=Console.ReadLine();

        Console.WriteLine("Hello:"+name);
        Console.WriteLine("Hello:{0}",name);

        Console.WriteLine($"Hello:{name}");

        Console.ReadLine();
        

    }
    
}