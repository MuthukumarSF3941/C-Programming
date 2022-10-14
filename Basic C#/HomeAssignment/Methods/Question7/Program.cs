using System;

namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the word");
        string str=Console.ReadLine();
        string s="";
        palindrom(str);

        void palindrom(string a)
        {
            char[] test=a.ToCharArray();
            for (int i =test.Length-1; i>=0; i--)
            {
                s=s+test[i];
            }
            if (str==s)
            {
                System.Console.WriteLine("it is a palindrom");
            }
            else
            {
                System.Console.WriteLine("not palindrom");
            }

        }
        
        
    }
}
