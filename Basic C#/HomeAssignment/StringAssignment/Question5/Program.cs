using System;

namespace Qusetion5;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first input");
        string word1=Console.ReadLine();
        char[] word1s=word1.ToCharArray();
        System.Console.WriteLine("Enter the second input");
        string word2=Console.ReadLine();
        char[] word2s= word2.ToCharArray();
        int c=0,d=0,e=0;

        foreach (char item in word1s)
        {
            c++;
        }
         foreach (char item in word2s)
        {
            d++;
        }
        if(c==d)
        {
            for (int i = 0; i <c; i++)
            {
                if(word1s[i]==word2s[i])
                {
                    e++;
                }
            }
        }
        else
        {
            System.Console.WriteLine("both strings are not eual");
        }
        if (c==e)
        {
            System.Console.WriteLine("The length of both strings are equal and also, both strings are equal"); 
        }
        else
        {
            System.Console.WriteLine("both strings are not equal");
        }
    }
}