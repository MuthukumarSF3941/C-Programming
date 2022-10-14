

namespace DictionaryDs
{
    public partial class Dictionary<TKey,TValue>
    {
        public void Add(TKey key,TValue value)
        {
            if(_capacity==_count)
            {
               Expand();

            }
            
        
            bool temp=LinerSearch(key,out int index);
            if(temp==true)
            {
            
                System.Console.WriteLine("duplicate key");
            }
            if(temp==false)
            {
              
            KeyValue<TKey,TValue> entry=new KeyValue<TKey, TValue>();
            entry.Key=key;
            entry.Value=value;
            Array[_count]=entry;
            _count++;
            }
            

        }

        public void Expand()
        {
              _capacity*=2;
              KeyValue<TKey,TValue>[] Temp=new KeyValue<TKey, TValue>[_capacity];
              for (int i = 0; i < count; i++)
              {
                Temp[i]=Array[i];
              }
              Array=Temp;
        }

        public bool LinerSearch(TKey key,out int index)
        {
            bool temp=false;
            index=0;
            for (int i = 0; i < count; i++)
            {
                if(Array[i].Key.Equals(key))
                {
                    index=i;
                    temp=true;
                    break;
                }
                
            }
            return temp;
        }

       public bool ContainsKey(TKey key)
       {
        int position=0;
        bool contain=LinerSearch(key,out position);
        return contain;
       }

       public bool ContainValue(TValue value)
       {
            bool temp=false;
            for(int i=0;i<count;i++)
            {
                if(Array[i].Value.Equals(value))
                {
                  temp=true;
                  break;
                }
                
            }

            return temp;
       }

       public void Remove(TKey key)
       {
        int temp=0;
           for (int i = 0; i < _count; i++)
           {
             if(Array[i].Key.Equals(key))
             {
                Array[i]=Array[i+1];
                temp=1;
                
               
             }
             if(temp==1)
             {
                Array[i]=Array[i+1];
             }
            
           }
           _count--;
       } 

        public void Display()
        {
            
        }
    }
}