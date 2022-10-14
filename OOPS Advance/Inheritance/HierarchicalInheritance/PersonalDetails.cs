using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public  enum Gender{Default,Male,Female}
    public class PersonalDetails
    {
        private static int s_aId=1000;

        public string AId { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public long Phone { get; set; }

        public Gender Gender { get; set; }
        
        

        public PersonalDetails(string name,string fatherName,long phone, Gender gender)
        {
            s_aId++;
             AId="AID"+s_aId;
             Name=name;
             FatherName=fatherName;
             Phone=phone;
             Gender=gender;

        }

        public PersonalDetails(string aId,string name,string fatherName,long phone, Gender gender)
        {
            
             AId=aId;
             Name=name;
             FatherName=fatherName;
             Phone=phone;
             Gender=gender;

        }

       

        
        public void showDetails()
        {
            System.Console.WriteLine($" Name\t\t:{Name}\n Father Name\t:{FatherName}\n Phone\t\t:{Phone}\n Gender\t\t:{Gender}\n Aadhar Id\t:{AId}");
        }

        
        
        
        
    }
}