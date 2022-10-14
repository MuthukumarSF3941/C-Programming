using System;

namespace OnlineMedical;

public class MyClass
{
    public static void Main(string[] args)
    {
        Files.Create();
       Files.ReadFiles();
        Operation.MainMenu();
        Files.WiteFiles();
    }
}