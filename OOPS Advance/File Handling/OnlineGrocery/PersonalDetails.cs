using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocery
{

    public enum Gender{Default,Male,Female,TransGender}
    public class PersonalDetails
    {
        public string Name { get; set; }

        public string FatherName { get; set; }

        public Gender Gender { get; set; }

        public long  MobileNumber { get; set; }

        public DateTime DOB { get; set; }

        public string MailId { get; set; }

        public PersonalDetails()
        {

        }

        public PersonalDetails(string name,string fatheName,Gender gender,long mobile,DateTime dob,string mail)
        {
            Name=name;
            FatherName=fatheName;
            Gender=gender;
            MobileNumber=mobile;
            DOB=dob;
            MailId=mail;

        }

        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}