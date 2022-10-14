using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueueDs
{
    public class Queue<Type>
    {
        public Type[] Array { get; set; }

        private int _countHead;

        private int _countTail;

        private int _capacity;

        private int _count;

        public int  Count { get; set; }

        
        
        

        public Queue()
        {
            _countHead=0;
            _countTail=0;
            _count=0;
            _capacity=4;

            Type[] Array=new Type[_capacity];

        }

          public Queue(int size)
        {
            _countHead=0;
            _countTail=0;
            _count=0;
            _capacity=size;

            Type[] Array=new Type[_capacity];

        }


        public void EnQueue(Type a)
        {
           if(_capacity==_count)
           {
            Grow();
           }

           Array[_countTail]=a;
           _countTail++;
           _count++;
        }

        public void Grow()
        {
            _capacity*=2;
          Type[]  Array1=new Type[_capacity];
          for(int i=0;i<_countTail;i++)
          {
            Array1[i]=Array[i];
          }
          Array=Array1;
        }


        public Type DEQueue()
        {
              Type value=default(Type);

              if(_countHead>_countTail)
              {
                 System.Console.WriteLine("Queue is empty");
              }
              else{
                value=Array[_countHead];
                _countHead++;
                _count--;
              }
              return value;
        }

        public Type Peak()
        {

              Type value=default(Type);
            if(_countHead>_countTail)
              {
                 System.Console.WriteLine("Queue is empty");
              }
              else{
                value=Array[_countHead];
               
              }
              return value;
        }

        public bool Contains(Type value)
        {
            bool temp=false;

            for (int i = _countHead; i <=_countTail; i++)
            {
                if(Array[i].Equals(value))
                {
                    temp=true;
                }
                else
                {
                   temp=false;
                }

            }
            return temp;
        }


        
        
        
        
    }
}