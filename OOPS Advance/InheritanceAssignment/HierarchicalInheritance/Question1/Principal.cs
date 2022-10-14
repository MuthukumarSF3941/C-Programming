using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Principal : PersonalInfo
    {
        private static int s_principleId=100;

        public string PrincipalId { get; set; }

        public string Qualification { get; set; }

        public int  YearofExperience { get; set; }

        public DateTime DateofJoining { get; set; }

        public Principal(string name,string fatherName,string mail,Gender gender,long phone,DateTime dob,string principleId,string qualification,int yearofExperience,DateTime dateofJoing):base( name, fatherName, mail, gender, phone, dob)
        {
           
          s_principleId++;
          PrincipalId="P"+s_principleId;
          Qualification=qualification;
          YearofExperience=yearofExperience;
          DateofJoining=dateofJoing;


        }

        public void showPrincipal()
        {
            System.Console.WriteLine($"PrincipalId:{PrincipalId}\n Qualification:{Qualification}\n YearofExperience:{YearofExperience} ");
        }
        
        
        
        
        
        
        
        
        
    }
}