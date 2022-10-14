using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{

    public enum Gender{Male,Female}
    public class PersonalInfo
    {
        public string Name { get; set; }

        public string FatherName { get; set; }

        public string Mail { get; set; }

        public long Phone { get; set; }

        public Gender Gender { get; set; }

        public DateTime DOB { get; set; }

        public PersonalInfo(string name,string fatherName,string mail,Gender gender,long phone,DateTime dob)
        {
          Name=name;
          FatherName=fatherName;
          Mail=mail;
          Gender=gender;
          Phone=phone;
          DOB=dob;


        }

       
        public void show()
        {
          System.Console.WriteLine($"Name;{Name}\n FatherName;{FatherName}\n Mail:{Mail}\n Gender:{Gender}\n Phone:{Phone}\n DOB:{DOB}");
        }
        

        
        
        
        
        
        
        
        
        
        
    }
}