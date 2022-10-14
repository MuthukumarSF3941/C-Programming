using System;

namespace Enumerated;

public enum Gender{Default,Male,Female,transGender}

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter gender Male/Female/TransGender");
        Gender gender=Gender.Default;
        bool temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
        System.Console.WriteLine(gender);

        while(!temp || !((int)gender>0 && (int)gender<4))
        {
            System.Console.WriteLine("Invalid input\nEnter again");
            temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
           
        }
         System.Console.WriteLine(gender);
    }
}
