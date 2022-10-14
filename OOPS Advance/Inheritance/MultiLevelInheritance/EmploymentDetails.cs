using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class EmploymentDetails : StudentDetails
    {
        private static int s_employmentId=1000;

        public string EmploymentId { get; set; }

        public DateTime RegistrationDate { get; set; }

        public EmploymentDetails(string studentId,string aId,string name,string fatherName,long phone, Gender gender,Dept department,DateTime registrationDate):base( studentId, aId, name, fatherName, phone,  gender, department)
        {
            s_employmentId++;
            EmploymentId="EID"+s_employmentId;
           RegistrationDate=DateTime.Now;
           StudentId=studentId;

        }

        public void showEmployment()
        {
            showStudent();
            System.Console.WriteLine($" Employee id\t:{EmploymentId}\n Registeration Date\t:{RegistrationDate}");
        }
        
        
        
        
    }
}