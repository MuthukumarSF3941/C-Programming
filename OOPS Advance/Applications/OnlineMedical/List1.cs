using System;

namespace OnlineMedical

{
    public partial class List<Type>
    {
       
       public void Insert(int index,Type data) 
     {

         _capacity+=1;
        Type[] array2=new Type[_capacity];


        for(int i=0; i< array2.Length;i++)
        {
            if(i<index)
            {
                array2[i]=Array[i];
               
            }
            else if(i==index)
            {
                array2[index]=data;
            }
            else
            {
               array2[i]=Array[i-1];
            }
        }
        Array=array2;
        _count++;
      }
      public void RemoveAt(int index)
      {
        for (int i = 0; i < _count; i++)
        {
           if(i>=index)
            {
                 Array[i]=Array[i+1];
            }
           
        }
        _count--;
         
      }

      public void Remove(Type value)
      {
         int count=0;
        for(int i=0;i<_count;i++)
        {
           
        
            if(Array[i].Equals(value))
            {   
                if(count==0)
                { Array[i]=Array[i+1];
                count=1;
                }
            }
            else if(count==1)
            {
                Array[i]=Array[i+1];
            }
           
        }
        _count--;
      }

       
    }
}