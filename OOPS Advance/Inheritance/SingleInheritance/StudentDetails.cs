using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public enum Dept{Default,ECE,EEE,CSE}
    public class StudentDetails : PersonalDetails
    {
        private static int s_studentId=1000;
        
        public string StudentId { get; set; }

        public Dept Department { get; set; }

        public string Year { get; set; }

        public StudentDetails(string aId,string name,string fatherName,long phone, Gender gender,Dept department,string year):base( aId, name, fatherName, phone,  gender)
        {
            s_studentId++;
            StudentId="SID"+s_studentId;
            Department=department;
            Year=year;

        }
        
        public void showStudent()
        {
            System.Console.WriteLine($" Student ID\t:{StudentId}");
            showDetails();
            System.Console.WriteLine($" Department\t:{Department}\n Year\t\t:{Year}");
        }
        
        
        
        
        
    }
}