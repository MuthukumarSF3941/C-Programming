using System;

namespace StudentAdmission

{
    public partial class List<Type>
    {
       
       public void Insert(int index,Type data) 
     {

         _count+=1;
        Type[] array2=new Type[_count+1];


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