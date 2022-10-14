using System;

namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string");
        string word=Console.ReadLine();
        System.Console.WriteLine("Enter the initial value");
        int start=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the end value");
        int j=int.Parse(Console.ReadLine());
        int end=start+j;
        char[] words=word.ToCharArray();
        for (int i = start; i <end; i++)
        {
            System.Console.Write(words[i]);
        }
        
    }
}
