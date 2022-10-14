using System;

namespace CovidVaccination;

class Program
{
    public static void Main(string[] args)
    {
        Files.Create();
      
        
       // Operation.defaultValue();
          Files.ReadFile();
        Operation.MainMenu();
        Files.WriteFile();
        

    }
}
