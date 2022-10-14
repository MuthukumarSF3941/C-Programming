using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class Attendance : EmployeeInfo
    {
        
        
        public int HoursWorked { get; set; }

        public DateTime Date { get; set; }

        public Attendance(string name,string fatherName,string mail,Gender gender,long phone,DateTime dob,int hours,DateTime date):base( name, fatherName, mail, gender, phone, dob)
        {
           HoursWorked=hours;
           Date=date;
           
        }
        
        
        
        
        
    }
}