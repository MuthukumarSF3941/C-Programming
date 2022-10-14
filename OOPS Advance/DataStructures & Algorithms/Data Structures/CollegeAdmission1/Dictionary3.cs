

namespace CollegeAdmission1
{
    public partial class Dictionary<TKey,TValue>
    {
        public KeyValue<TKey,TValue> ElemntAt(int index)
        {
            KeyValue<TKey,TValue> output=null;
            if(index>-1 && index<count)
            {
                output=Array[index];
            }
            else
            {
                System.Console.WriteLine("tried to access outer the bound");
            }
            return output;
        }
    }
}