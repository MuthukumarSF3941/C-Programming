using System;

namespace Question5;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string");
        string word=Console.ReadLine().ToLower();
        char[] words=word.ToCharArray();
        string str="";
        for (int i =words.Length-1; i>=0; i--)
        {
            str+=words[i];
        }
        if(str.Equals(word))
        {
            System.Console.WriteLine($"{word} is palindrom");
        }
        else
        {
            System.Console.WriteLine($"{word} is not palindrom");
        }
        
    }
}