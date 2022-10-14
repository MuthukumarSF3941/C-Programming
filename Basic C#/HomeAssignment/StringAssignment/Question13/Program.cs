using System;
namespace Question13;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter a string");
        string word=Console.ReadLine();
        char[] words=word.ToCharArray();
        int sum=0;
        for (int i = 0; i <words.Length; i++)
        {
            if (words[i]>=48 && words[i]<=57)
            {
                sum+=(int)words[i]-48;
            }
        }
        System.Console.WriteLine("sum of numbers="+sum);
    }
}
