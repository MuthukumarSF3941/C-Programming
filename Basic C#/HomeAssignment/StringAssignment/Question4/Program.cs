using System;

namespace Question4;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string");
        string word=Console.ReadLine();
         int c=1;
         char[] one=word.ToCharArray();

         for (int i = 0; i <one.Length; i++)
         {
            if(one[i]==32)
            {
                c++;
            }
         }
         System.Console.WriteLine($"Total number of words in this string:{c}");
    }
}