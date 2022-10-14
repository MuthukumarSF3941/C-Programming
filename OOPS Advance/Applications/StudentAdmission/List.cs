


namespace StudentAdmission

{
    public partial  class List<Type>
    {
        private Type[] Array { get; set; }

        private int _count;

        private int _capacity;

        public int Count { get{return _count;} }

        public int Capacity { get{return _capacity;} }


        // set the count and capacity changes only by program itself not by user
       public Type this[int i]
        {
            get{return Array[i];}
            set{Array[i]=value;}
        }

        public List()
        {


            //default list properties
            _count=0;
            _capacity=4;
            Array=new Type[_capacity];

        }

        public List(int size)
        {
            //list properties according to user input
            _count=0;
            _capacity=size;
            Array=new Type[_capacity];
        }

        public void Add(Type a )
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
          Type[]  Array1=new Type[Capacity*2];
          for(int i=0;i<_count;i++)
          {
            Array1[i]=Array[i];
          }
          Array=Array1;
        }
        
        
        
        
        
        
    }
}