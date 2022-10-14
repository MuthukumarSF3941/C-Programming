using System;

namespace Question10;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the user name");
        string uName=Console.ReadLine();
         System.Console.WriteLine("Entetr the password");
         string uPass=Console.ReadLine();
         
         string user="muthu kumar";
         string pass="frank";

         if(uName.Equals(user) && pass.Equals(uPass))
         {
            System.Console.WriteLine("password entered successfully");
         }
         else
         {
            System.Console.WriteLine("user name or password is incorrct :try again");
         }

    }
}