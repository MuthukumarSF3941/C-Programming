using System;

namespace Question;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your Password");
        string passWord=Console.ReadLine();
        
        if(passWord=="HiTeam")
        {
            System.Console.WriteLine("Right PassWord");
        }
        else
        {
            System.Console.WriteLine("Wrong Password");
        }
    }
}