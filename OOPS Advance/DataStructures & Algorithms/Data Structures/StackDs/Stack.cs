

namespace StackDs
{
    public partial class Stack<Type>
    {

      private  int _count;

       private int _capacity;
        public Type[] Array {get; set;}

        public int Count { get{return _count;} }

        public int Capacity { get{return _capacity;} }
        
        
        
        public Stack()
        {
            _count=0;
            _capacity=4;
            Type[] Array=new Type[_capacity];
        }

        public Stack(int size)
        {
             _capacity=size;
             _count=0;
               Type[] Array=new Type[_capacity];
        }


        public void Push(Type a)
        {
           if(_count==_capacity)
           {
               Grow();
           }
           Array[_count]=a;
           _count++;
        }

        public void Grow()
        {
            _capacity*=2;
            Type[] Array2=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                Array2[i]=Array[i];
            }
            Array=Array2;
        }

       public Type Pop()
        {

            Type value=default(Type);

            if(_count<0)
            {
                System.Console.WriteLine("Empty stack");
            }
            else if(_count>=0)
            {
                 value=Array[_count];
                 _count--;
            }
            return value;
             
        }

        public bool Contains(Type data)
        {
          bool  value=true;
            for(int i=0;i<_count;i++)
            {
                if(Array[i].Equals(value))
                {
                   
                   value=true;
                }
                else
                {
                     value=false;
                }
              
            }
              return value;
        }

        public  Type Peak()
        {
            
            Type value=default(Type);

            if(_count<0)
            {
                System.Console.WriteLine("Empty stack");
            }
            else if(_count>=0)
            {
                 value=Array[_count];
                 
            }
          return value;
        }



        
        
        
    }
}