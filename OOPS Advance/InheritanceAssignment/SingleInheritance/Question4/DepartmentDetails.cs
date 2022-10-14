using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public class DepartmentDetails
    {
        public string DepartmentName { get; set; }

        public string Degree { get; set; }
        
        public DepartmentDetails(string dept,string degree)
        {
            DepartmentName=dept;
            Degree=degree;
            
            
        }
        
        
    }
}