using System;

namespace Question6;

class Program
{
    public static void Main(string[] args)
    {
        int i=1;
        int j=1;
        int k=0;
        int count=0;

        System.Console.WriteLine("Odd numbers are:");
        while(i<=100)
        {
            
            if (i%2==1)
            {
                System.Console.Write(i+" ");
            }
            i++;
        }

        System.Console.WriteLine("\nthe Even numbers are");
       
        while (j<=100)
        {
            if (j%2==0)
            {
                System.Console.Write(j+" ");
                
            }
            j++;
        }

        System.Console.WriteLine("\nthe prime numbers are");
        while (k<=100)
        {
            for (int l = 1; l <=k; l++)
            {
                if (k%l==0 && !(k==1))
                {
                    count++;
                }
            }
            if (count==2)
            {
                System.Console.Write(k+" ");
            }
            k++;
            count=0;
        }
    }
}
