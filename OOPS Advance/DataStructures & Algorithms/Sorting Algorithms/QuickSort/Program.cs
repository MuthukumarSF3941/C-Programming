using System;

namespace QuickSort;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array=new int[] {18,19,1,5,7,3,20};

        SortArray(array);

        for (int i = 0; i < array.Length; i++)
        {
            if(i==0)
            {
                System.Console.Write(array[i]);
            }
            else
            {
                System.Console.Write(","+array[i]);
            }
        }

        
         static void SortArray(int[] array)
        {
             Quick(array,0,array.Length-1);
        }

        static void Quick(int[] array,int first,int last)
        {
             int i=first;
             int j=last;
             int pivot=(array[first]+array[last])/2;

             while(i<=j)
             {
                while(array[i]<pivot)
                {
                    i++;
                }

                while(array[j]>pivot)
                {
                    j--;
                }

                if (i<=j)
                {
                    int temp=array[i];
                    array[i]=array[j];
                    array[j]=temp;

                    i++;
                    j++;

                }
             }

             if(first<j)
             {
                Quick(array,first,j);
             }
             if(i<last)
             {
                Quick(array,i,last);
             }
        }
    }
}