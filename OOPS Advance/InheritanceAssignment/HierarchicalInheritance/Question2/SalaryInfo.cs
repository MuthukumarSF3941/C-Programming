using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class SalaryInfo
    {
        public string Month { get; set; }

        public int BasicSalary { get; set; }

        public SalaryInfo(string month,int basic)
        {
            BasicSalary=basic;
            Month=month;
            
        }
        
        
        
        
    }
}