using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{

  public enum Status{Married,Single}

    public enum Gender{Male,Female}
    public class PersonalInfo : IShowData
    {
        public string Name { get; set; }

        public Status MaritialStatus { get; set; }
        
        

        public string FatherName { get; set; }

        public string Mail { get; set; }

        public long Phone { get; set; }

        public Gender Gender { get; set; }

        public DateTime DOB { get; set; }

        public PersonalInfo(string name,string fatherName,string mail,Gender gender,long phone,DateTime dob,Status martial)
        {
          Name=name;
          FatherName=fatherName;
          Mail=mail;
          Gender=gender;
          Phone=phone;
          DOB=dob;
          MaritialStatus=martial;


        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"Name:{Name}\n Father Nmae:{FatherName}\n Mail\t\t:{Mail}\n Gender:{Gender}\n Phone:{DOB}\n Phone:{Phone}\n Maritial Status:{MaritialStatus}");
        }
    }
}