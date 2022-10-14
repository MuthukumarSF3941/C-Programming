using System;

namespace Question6;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the password");
        string password=Console.ReadLine();
        string def="s3cr3t!P@sswOrd";

        if(password==def)
        {
            System.Console.WriteLine("welcome");
        }
        else
        {
            System.Console.WriteLine("wrong password");
        }
    }
}
