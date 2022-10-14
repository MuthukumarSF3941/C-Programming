using System;

using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmission
{
    public  class DepartmentDetails
    {

        
        static int s_departmentID=100;
         public  string DepartmentName { get; set; }

         public  string DeptId  { get; set; }

         public  int SeatsAvailable { get; set; }

         public  DepartmentDetails(string deptname,int seatsAvailable)
         {
             s_departmentID++;
             DeptId="DID"+s_departmentID;
             DepartmentName=deptname;
             SeatsAvailable=seatsAvailable;

         }

         public  DepartmentDetails(string data)
         {

            string[] value=data.Split(',');
             s_departmentID=int.Parse(value[0].Remove(0,3));
             DeptId=value[0];
             DepartmentName=value[1];
             SeatsAvailable=int.Parse(value[2]);

         }

       
          
       
         
         
        
        

     
        
    }
}