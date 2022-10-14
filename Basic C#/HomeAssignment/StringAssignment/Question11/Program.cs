using System;
namespace Question11;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string");
        string input=Console.ReadLine();
        string final="";
        for (int i = 0; i <input.Length; i++)
        {
            if(!final.Contains(input[i]))
            {
                final+=input[i];

            }
        }
        System.Console.WriteLine($"After removing duplicates from the given string:{final}");
    }
}