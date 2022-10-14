using System;

namespace Question3;

public class Program
{
    public static void Main(string[] args)
    {
        string[] arr={"sf3941","sf3942","sf3943","sf3944","sf3945","sf3946","sf3947","sf3948","sf3949","sf3950"};

        System.Console.WriteLine("Enter the string to be found");
        string str=Console.ReadLine().ToLower();
        
        int beginning=0;
        int end=arr.Length-1;
        int middle;

        for (int i = beginning; i < end; i++)
        {
            middle=(beginning+end)/2;
            int returnval=str.CompareTo(arr[middle]);

            if(arr[middle]==str)
            {
                System.Console.WriteLine("Value found");
                break;
            }
            else
            {
                if(returnval==-1)
                {
                   end=middle-1;
                }
                else if(returnval==1)
                {
                  beginning=middle+1;
                }
            }
        }

    }
}
