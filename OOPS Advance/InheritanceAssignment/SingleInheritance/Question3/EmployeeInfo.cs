using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public enum Gender{Male,Female};
    public class EmployeeInfo
    {
         
      private static int s_employeeId;

      public string EmployeeId { get; set; }
      
      
        public string Name { get; set; }

        public string FatherName { get; set; }

        public string Mail { get; set; }

        public long Phone { get; set; }

        public Gender Gender { get; set; }

        public DateTime DOB { get; set; }

        public EmployeeInfo(string name,string fatherName,string mail,Gender gender,long phone,DateTime dob)
        {
          s_employeeId++;
          EmployeeId="EID"+s_employeeId;
          Name=name;
          FatherName=fatherName;
          Mail=mail;
          Gender=gender;
          Phone=phone;
          DOB=dob;
        
        }
}
}