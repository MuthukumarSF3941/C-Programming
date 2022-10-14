using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public class StudentDetails
    {
        //fields
        //private string _name;
        // public string Name { get{return _name;} set{_name=value;} }
         public string Name { get; set; }    //Auto property
         public string FatherName { get; set; }
         public DateTime DOB { get; set; }
         public string Gender { get; set; }
         public long Phone { get; set; }
         public string Mail { get; set; }
         public int Physics { get; set; }
         public int Chesmistry { get; set; }
         public int  Maths { get; set; }

         public StudentDetails()            //Default constructor
         {
            Name="Your name";
            FatherName="Your father name";

         }
         //parameterized constructor
         public StudentDetails(string  name,string fathername,DateTime dob,long phone,string mail,string gender,int physics,int chemistry,int maths)
         {
            Name=name;
            FatherName=fathername;
            DOB=dob;
            Phone=phone;
            mail=Mail;
            Gender=gender;
            Physics=physics;
            Chesmistry=chemistry;
            Maths=maths;
         }
        
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         

         
         
    }
}