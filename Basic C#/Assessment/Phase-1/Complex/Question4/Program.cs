using System;

namespace Question4;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string");
        string word=Console.ReadLine().ToLower();
        char[] words=word.ToCharArray();
        string str="";
        for (int i = 0; i < words.Length; i++)
        {
            if(!str.Contains(words[i]))
            {
               str+=words[i]; 
            }
           
        }
        System.Console.WriteLine(str);
    }
}