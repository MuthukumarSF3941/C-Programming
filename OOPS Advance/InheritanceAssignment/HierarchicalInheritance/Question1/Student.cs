using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Student : PersonalInfo
    {
        private static int s_studentId=100;

        public string StudentId { get; set; }

        public string Department { get; set; }

        public int Semester { get; set; }

        public string Degree { get; set; }

        public Student(string name,string fatherName,string mail,Gender gender,long phone,DateTime dob,string dept,int semester,string degree):base( name, fatherName, mail, gender, phone, dob)
        {
            s_studentId++;
            StudentId="SID"+s_studentId;
            Department=dept;
            Degree=degree;
            Semester=semester;
        }
        
        public void showStudent()
        {
           
            
            System.Console.WriteLine($"StudentId:{StudentId}\n Department;{Department}\n Semester:{Semester} ");
        }
        
        
        
        
        
        
    }
}