using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayListDs
{


    public partial class ArrayList
    {

        private dynamic[] Array { get; set; }

        private int _count;

        private int _capacity;

        public int Count { get{return _count;} }

        public int Capacity { get{return _capacity;} }


        // set the count and capacity changes only by program itself not by user
       public dynamic this[int i]
        {
            get{return Array[i];}
            set{Array[i]=value;}
        }

        public ArrayList()
        {


            //default list properties
            _count=0;
            _capacity=4;
            Array=new dynamic[_capacity];

        }

      

    }
}