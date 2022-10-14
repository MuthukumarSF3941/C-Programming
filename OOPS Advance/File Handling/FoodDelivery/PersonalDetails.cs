using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{

    public enum Gender{Male,Female}
    public class PersonalDetails
    {
        public string Name { get; set; }

        public string FatherName { get; set; }

        public Gender Gender { get; set; }

        public long Mobile { get; set; }

        public string MailId { get; set; }

        public string Location { get; set; }

        public DateTime DOB { get; set; }
        
        

        public PersonalDetails(string name,string fathername,Gender gender,long mobile,DateTime dob,string mail,string location)
        {
          Name=name;
          FatherName=fathername;
          Gender=gender;
          Mobile=mobile;
          MailId=mail;
          Location=location;
        }
        public PersonalDetails()
        {

        }
       


        
        
        
        
        
        
        
        


        
        
        
        
    }
}