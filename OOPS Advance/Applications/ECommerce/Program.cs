using System;

namespace ECommerce;

public class MyClass
{
    public static void Main(string[] args)
    {
        Files.Create();
       //Operation.defaultValues();
        Files.ReadData();
        
        Operation.MainMenu();
        Files.WriteData();
    }
}
