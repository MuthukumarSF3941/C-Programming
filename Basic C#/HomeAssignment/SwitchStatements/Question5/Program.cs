using System;

namespace Question5;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter cricket teams\n India\n Pakistan\n bangladesh");
        string team=Console.ReadLine();
        
        switch (team)
        {
            case "India":
            System.Console.WriteLine("1:Virat kohli\n 2:Dohni\n 3:Raina");
                break;
            case "Pakistan":
            System.Console.WriteLine("1:Abdhulla\n 2:Rahman\n 3:Aniruth");
                break;
            case "Bangladesh":
            System.Console.WriteLine("1:Root\n 2:ben stocks\n 3:ben cutting");
                break;
               
            default:
             System.Console.WriteLine("Invalid team");
                break;
        }
        
    }
}
