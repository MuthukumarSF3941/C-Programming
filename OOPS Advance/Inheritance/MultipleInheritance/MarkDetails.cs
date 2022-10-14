using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public interface IMarkDetails 
    {
        
    int  Physics { get; set; }

    int Chemistry { get; set; }

     int Maths { get; set; }

      int Total { get; set; }

      Double Average { get; set; }

      void calculate();      //method declertation and property  only allowed for interface
      
     
     //no constructor and object
    
    


   
   
   
   
        
    }
}