using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outside;

namespace Inside
{  
    public class First:Third
    {
        public int publicNumber=10;
        private int privateNumber=20;
        public int privateOutput { get{return privateNumber;}}
        internal int InternalNumber=30;
        protected int protectedNumber=40;

        public int ProtectedInternalOutput{get{return ProtectedInternalNumber;}}
        
        
    }
}