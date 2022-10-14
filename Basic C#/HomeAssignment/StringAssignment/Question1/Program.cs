using System;

namespace Question1;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the word");
        string name=Console.ReadLine();
        int c=0;
        
        char[] one=name.ToCharArray();
        foreach (char item in one)
        {
            c++;
        }
        System.Console.WriteLine($"The length of the array is:{c}");
    }
}
