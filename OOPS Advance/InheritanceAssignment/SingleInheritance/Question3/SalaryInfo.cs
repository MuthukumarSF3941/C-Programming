using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class SalaryInfo: Attendance
    {
        
        public int SalaryofMonth { get; set; }

        public string Month { get; set; }

        public SalaryInfo(string name,string fatherName,string mail,Gender gender,long phone,DateTime dob,int hours,DateTime date,string month,int salary):base( name, fatherName, mail, gender, phone, dob, hours, date)
        {
            SalaryofMonth=salary;
            Month=month;
            
        }

        public void show()
        {
            System.Console.WriteLine($"Name:{Name}\n FatherName;{FatherName}\n Mail:{Mail}\n Gender:{Gender}\n Phone:{Phone}\n date of birth:{DOB}\n Hours worked:{HoursWorked}\n Date;{Date}\n Month;{Month} \n Salary:{SalaryofMonth} ");
        }
    }
}