using System;

namespace Question8;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string");
        string word=Console.ReadLine();
        char[] words=word.ToCharArray();
       string d="";
      
        for (int i = 0; i < words.Length; i++)
        {
            if(words[i]>=48 && words[i]<=57)
            {
             d=d+words[i]; 
            }

        }
        int num=int.Parse(d);
       if(num%2==0)
       {
        System.Console.WriteLine($"{num} is Even number");
       }
       else
       {
        System.Console.WriteLine($"{num} is odd number");
       }

    }
}