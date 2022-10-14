using System;
 namespace Question3;

 class Program
 {
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string to be reversed");
        string str=Console.ReadLine();
        int n=str.Length;
         char[] words=str.ToCharArray();
         System.Console.WriteLine("the reveres characters of a string are");
         for (int i = n-1; i>=0; i--)
         {
            System.Console.Write(words[i]+ " ");
         }

    }
 }