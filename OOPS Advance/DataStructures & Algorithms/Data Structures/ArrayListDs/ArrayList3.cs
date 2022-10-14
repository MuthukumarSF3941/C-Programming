using System.Collections;

namespace ArrayListDs
{
    public partial class ArrayList : IEnumerator, IEnumerable
    {

        private int Position;
        public object Current 
        {
            get
            {
                return Array[Position];
            }
        }

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