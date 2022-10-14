using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayListDs
{
    public partial class ArrayList
    {
          public ArrayList(int size)
        {
            //list properties according to user input
            _count=0;
            _capacity=size;
            Array=new object[_capacity];
        }

        public void Add(object a )
        {

            if(_count==_capacity)
            {
                GrowSize();
            }
           //add element into a list
            Array[_count]=a;
            _count++;
        }

        public void GrowSize()
        {
            _capacity*=2;
          object[]  Array1=new object[Capacity];
          for(int i=0;i<_count;i++)
          {
            Array1[i]=Array[i];
          }
          Array=Array1;
        }
         
    }
}