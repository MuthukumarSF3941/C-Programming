using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Draw : IRectangle
    {
        public int Area { get; set; }

         public int Length { get; set; }

         public int Breadth { get; set; }

         public void caluculateArea()
         {
            Area=Length*Breadth;
            System.Console.WriteLine($"Area:{Area}");
         }
        

        
        
        
    }
}