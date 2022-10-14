using System;

namespace Question10;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a character");
        char input=char.Parse(Console.ReadLine().ToLower());

        if(input=='a' || input=='e' || input=='i' || input=='o' || input=='u')
        {
            System.Console.WriteLine("It is a vowel");
        }
        else
        {
            System.Console.WriteLine("It is not vowel");
        }
    }
}