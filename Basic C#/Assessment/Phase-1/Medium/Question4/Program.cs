using System;

namespace Question4;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter tha end value");
        int end=int.Parse(Console.ReadLine());
        int temp;
        int count=0;
        int mul=1;
        int sum=0;
        int mod=0;
        for (int i = 1; i < end; i++)
        {
            temp=i;
            while(temp>0)
            {
                temp=temp/10;
                count++;
            }
            if(count==1)
            {
                mul=mul*i;
                if(i==mul)
                {
                    System.Console.WriteLine(i);
                }
            }
            else if(count==2)
            {
                int temp2=i;
                while(temp2>0)
                {
                    mod=temp2%10;
                    sum+=mod*mod;
                    temp2=temp2/10;
                }
                if(sum==i)
                {
                    System.Console.WriteLine(sum);
                }
            }
            else if(count==2)
            {
                   int temp3=i;
                    while(temp3>0)
                   { 
                    mod=temp3%10;

                    sum+=mod*mod*mod;
                    temp3/=10;
                   }
                   if(sum==i)
                 {
                    System.Console.WriteLine(sum);
                 }
            }
            count=0;  
        }
    }
}

