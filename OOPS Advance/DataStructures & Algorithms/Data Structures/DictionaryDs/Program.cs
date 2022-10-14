using System;

namespace DictionaryDs;

class Program
{
public static void Main(string[] args)
{
    Dictionary<int,string> dict=new Dictionary<int, string>();

    dict.Add(10,"franklin");
    dict.Add(37,"Antony");
    dict.Add(101,"joseph");
    dict.Add(100,"ANtonio");
    dict.Add(500,"Jose");
    dict.Add(117,"Enjoy");
    dict.Remove(500);
   System.Console.WriteLine( dict.ContainsKey(101));
    System.Console.WriteLine(dict.ContainValue("Franklin"));
   System.Console.WriteLine( dict.ElemntAt(4));

   foreach (KeyValue<int,string> item in dict)
   {
       System.Console.WriteLine($"{item.Key}:{item.Value}");
   }
  
    
   
}
}