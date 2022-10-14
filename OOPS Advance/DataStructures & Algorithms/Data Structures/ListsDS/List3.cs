using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListsDS
{
    public partial class List<Type>
    {
        public void AddRange(List<Type> data)
        {
            Type[] array3=new Type[Capacity+data.Count];

            for (int i = 0; i < Count; i++)
            {
                array3[i]=Array[i];
            }

            for (int i = 0; i < data.Count; i++)
            {
                array3[Count+i]=data[i];
                
            }
            _count+=data.Count;
            Array=array3;
        }
    }
}