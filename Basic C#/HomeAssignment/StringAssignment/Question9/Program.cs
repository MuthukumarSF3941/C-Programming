using System;

namespace Question9;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string");
        string word=Console.ReadLine();
        System.Console.WriteLine("Enter string to search");
        string search=Console.ReadLine();
        if(word.Contains(search))
        {
            System.Console.WriteLine("the substring exists in the string");
        }
        else
        {
            System.Console.WriteLine("it is not exists");
        }
       

        
    }
}