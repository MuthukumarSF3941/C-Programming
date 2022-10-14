using System;

namespace StudentAdmission;

class Program
{
    public static void Main(string[] args)
    {
        Files.Create();
        //Operation.DefaultMenu();
         Files.ReadFile();
         Operation.MainMenu();
        Files.WriteToFiles();
        
        

    }
}