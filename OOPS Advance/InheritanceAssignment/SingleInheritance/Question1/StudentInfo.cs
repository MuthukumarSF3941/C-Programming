using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_registerNumber=1000;

        public string RegisterNumber { get; set; }

        public string Standard { get; set; }

        public string Branch { get; set; }

        public int AcadamicYear { get; set; }

        public StudentInfo(string name,string fatherName,string mail,Gender gender,long phone,DateTime dob,string satndard,string branch,int acadamicYear):base( name, fatherName, mail, gender, phone, dob)
        {
            s_registerNumber++;
            RegisterNumber="SID"+s_registerNumber;
            Standard=satndard;
            Branch=branch;
            AcadamicYear=acadamicYear;
            
        }       

         public void Show()
        {
            System.Console.WriteLine($" Name\t:{Name}\n Father Name\t:{FatherName}\n RegisterNumber\t:{RegisterNumber}\n Mail\t\t:{Mail}\n Gender\t\t:{Gender}\n Phone:{Phone}\n DateOf birth:{DOB}\n Standard:{Standard}\n Branch\t:{Branch}\n Acadamic Year:{AcadamicYear} ");
        } 
        
        
        
        
        
        
        
    }
}