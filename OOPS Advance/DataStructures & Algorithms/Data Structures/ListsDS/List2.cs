using System;
using System.Collections;

namespace ListsDS
{
    public partial class List<Type> : IEnumerable, IEnumerator
    {
       


        private int Position;
         public object Current
        {
            get
            {
                return Array[Position];
            }
        }

        /*

         public IEnumerator GetEnumerator()
         {
             Position=-1;
             return(IEnumerator)this;
         }

         public bool MoveNext()
         {
             if(Position<_count-1)
             {
                 ++Position;
                 return true;
             }
             Reset();     //reset position value if no element in list
             return false;
         }

         public void Reset()
         {
           Position=-1;
         }
         public object Current
         {
             get
             {
                 return Array[Position];
             }
         }*/
        public IEnumerator GetEnumerator()
        {
            Position=-1;
           return(IEnumerator)this;

        }

        public bool MoveNext()
        {
           if(Position<_count-1)
           {
            ++Position;
            return true;
           }
           Reset();
           return false;
           
        }

        public void Reset()
        {
            Position=-1;
        }
    }
}