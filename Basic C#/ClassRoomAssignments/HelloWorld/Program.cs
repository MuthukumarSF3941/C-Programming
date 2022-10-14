using System;
namespace HelloWorld{
   class Program
    {
      public static void Main(string[] args)
      {
        
        Console.WriteLine("enter your name");
        string name=Console.ReadLine();

         Console.WriteLine("enter your other name");
        
        Console.WriteLine("your name is :{0} and your another name is : {1}",name,Myname);

        Console.WriteLine($"my name is: {name} my another name is :{Myname}");
        

        Console.ReadLine();
      }  
    }
}


