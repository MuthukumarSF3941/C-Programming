using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentDetails
    {
       //Constructors

        public StudentDetails(string aId,string name,string fatherName,long phone, Gender gender,Dept department,string year)
        {
            s_studentId++;
            StudentId="SID"+s_studentId;
            Department=department;
            Year=year;

        }
        
    }
}