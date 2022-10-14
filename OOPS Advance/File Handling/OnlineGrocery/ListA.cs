using System;
using System.Collections;


namespace OnlineGrocery
{
    public partial class List<Type> : IEnumerator, IEnumerable
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
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            if(position<Count-1)
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