using System;

namespace Question2;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the word");
        string str=Console.ReadLine();
        
        char[] space=str.ToCharArray();
      System.Console.WriteLine(" the characters in the string are");
        foreach (char item in space)
        {
            System.Console.Write(item+" ");
        } 
    }
}