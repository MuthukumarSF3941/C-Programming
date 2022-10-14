using System;

namespace ArrayQuestion;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Array length");
        int l=int.Parse(Console.ReadLine());
        string[] names=new string[l];
        int count=0;
       
        
        for (int i = 0; i <l; i++)
         {
            System.Console.WriteLine($"Enter the {i} value: ");
            names[i]=Console.ReadLine().ToLower();
            
         }
        System.Console.WriteLine("Names:");
        foreach (var nNames in names)
         {
            System.Console.WriteLine(nNames);
         }
    System.Console.WriteLine("input name to search from array using for loop");
    string search=Console.ReadLine();

        for (int j = 0; j < l; j++)
         {
            if(names[j]==search)
            {
                System.Console.WriteLine($"the given name is presented in the array with the index:{j}");
                count++;
            }
    
         }
         if (count==0)
         {
            System.Console.WriteLine("Name not prsented in the array");
         }
         count=0;
    System.Console.WriteLine("enter the value to search in the array using foreach loop");
    string search1=Console.ReadLine().ToLower();     
         foreach (string values in names)
         {
            if (values==search1)
            {
                System.Console.WriteLine("Name presented in the array");
                count++;
            }
         }
         if(count==0)
         {
            System.Console.WriteLine("Name not presented in the array"); 
      
         }
       
    }
}
