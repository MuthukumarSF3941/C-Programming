using System;

namespace StringQuestion;

class Program
{
    public static void Main(string[] args)
    {
       System.Console.WriteLine("Enter the string"); 
       string str=Console.ReadLine();
       
       System.Console.WriteLine("Enter the string to search");
       string search=Console.ReadLine();
       int count=0;
       string id="a";

       string str1=str.Replace(search,id);
       char[] n=str1.ToCharArray();
       for (int i = 0; i < str1.Length; i++)
       {
          if(n[i]=='a')
          {
            count++;
          }
       }
       System.Console.WriteLine((count));
      // str.Split(search);
 
       
    }
}
