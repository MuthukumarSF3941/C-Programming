using System;

namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string");
        string word=Console.ReadLine();
        char[] words=word.ToCharArray();
        int num=0,alpha=0,special=0;

        for (int i = 0; i < words.Length; i++)
        {
           if(words[i]>=48 && words[i]<=57) 
           {
              num++;
           }
           else if((words[i]>=65 && words[i]<=90)|| (words[i]>=97 && words[i]<=122))
           {
            alpha++;
           }
           else
           {
            special++;
           }
        }
        System.Console.WriteLine($"Number of alphabets in this string:{alpha}\n Number of digits in the string:{num}\n Number of special character in this string:{special}");
    }
}
