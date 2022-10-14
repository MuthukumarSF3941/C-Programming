using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryDs
{
    public partial class Dictionary<TKey, TValue> : IEnumerable, IEnumerator
    {
        private int position;

        public object Current
        {
            get
            {
                return Array[position];
            }
        }

        public IEnumerator GetEnumerator()
        {
            position=-1;
            return(IEnumerator)this;
            
        }

        public bool MoveNext()
        {
            if(position<count-1)
            {
                ++position;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            position=-1;
        }
    }
}