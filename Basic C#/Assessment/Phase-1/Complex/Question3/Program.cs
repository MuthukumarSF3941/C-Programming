using  System;

namespace Question3;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first string");
        string nameOne=Console.ReadLine().ToLower();
         System.Console.WriteLine("Enter the second string");
        string nameTwo=Console.ReadLine().ToLower();
       
        char[] a1=nameOne.ToCharArray();
        char[] b1=nameTwo.ToCharArray();
        int count=0;
        if(a1.Length==b1.Length)
        {
            for (int i = 0; i < a1.Length; i++)
            {
                
                    if(!nameOne.Contains(b1[i]))
                    {
                        count++;
                    }
                
            }
            if (count==0)
            {
               System.Console.WriteLine("name one and two are Anagrams"); 
            }
            else
            {
                System.Console.WriteLine("name one and two are not Anagrams");
            }
        }
        else
            {
                System.Console.WriteLine("name one and two are not Anagrams");
            }
    }
}