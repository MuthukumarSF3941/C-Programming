

namespace DictionaryDs
{
    public partial  class Dictionary<TKey,TValue>
    {
        private int _count=0;

        private int _capacity=0;

        public int count { get{return _count;} }

        public int Capacity { get{return _capacity;} }
        
        
        
        

        public KeyValue<TKey,TValue>[] Array {get; set;}


        public Dictionary()
        {
            _count=0;
            _capacity=4;
            Array=new KeyValue<TKey,TValue>[_capacity];
        }

        public Dictionary(int size)
        {
            
                _count=0;
                _capacity=size;
                Array=new KeyValue<TKey,TValue>[_capacity];
             
        }
       

        public TValue this[TKey key]
        {

            
            get
            {
                TValue output=default(TValue);
                int index=0;
                bool temp=LinerSearch(key,out index);
                if(temp)
                {
                    output=Array[index].Value;
                }
                else
                {
                       System.Console.WriteLine("invalid key");
                }
                return output;
                
            }
            set
            {
                int position=0;
                bool temp=LinerSearch(key,out position);
                if(temp)
                {
                    Array[position].Value=value;

                }
                else
                {
                    System.Console.WriteLine("Invalid key");
                    
                }
            }
        }


    }
}