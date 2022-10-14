using System;

namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string");
        string word=Console.ReadLine();
        char[] words=word.ToCharArray();
        int vowel=0,consonent=0;
        for (int i = 0; i < words.Length; i++)
        {
        if((words[i]>=65 && words[i]<=90)|| (words[i]>=97 && words[i]<=122))
        {
            if(words[i]=='a' || words[i]=='e' || words[i]=='i' || words[i]=='o' || words[i]=='u' || words[i]=='A' || words[i]=='E' || words[i]=='I' || words[i]=='O'|| words[i]=='U')
            {
                vowel++;
            }
            else
            {
                consonent++;
            }
        }
        }
        System.Console.WriteLine($"The number of vowels:{vowel}\n the number of consonent:{consonent}");
    }
}
