
using System;

namespace ArrayListDs;

class Program
{
    public static void Main(string[] args)
    {
        ArrayList Lists=new ArrayList();
        Lists.Add(300);
        Lists.Add("Franklin");
        Lists.Add('s');
        Lists.Insert(2,123456789000);
        Lists.Add(5456.098765);

        for (int i = 0; i < Lists.Count; i++)
        {
            System.Console.WriteLine(Lists[i]);
        }

        foreach(dynamic hii in Lists)
        {
            System.Console.WriteLine(hii);
        }
    }
    
}