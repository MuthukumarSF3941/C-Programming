using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmission
{
    public  enum Gender{Male,Female}
    public class StudentDetails
    {
        public static int s_studentId=1000;

        public string StudentId { get; set; }
        
        
        public string StudentName { get; set; }
        
        public string FatherName { get; set; }

        public DateTime DOB { get; set; }

        public Gender Gender { get; set; }

        public int Physics { get; set; }

        public int Chemistry  { get; set; }

        public int Maths { get; set; }

        public StudentDetails()
        {
            s_studentId++;
            StudentId="SF"+s_studentId;
            
            
        }

        public void ShowDetails()
        {
            System.Console.WriteLine($"Student Name:{StudentName}\n FatherName:{FatherName} Gender:{Gender}\n Date Of Birth:{DOB.ToShortDateString()}\n Physics:{Physics}\n Chemistry:{Chemistry}\n Maths{Maths}");
        }
        public bool CheckEligibility(double cuttOff)
        {
            double average=(Physics+Chemistry+Maths)/3.0;
            if(average>cuttOff)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public StudentDetails(string name,string fatherName,Gender gender,DateTime dob,int physics,int chemistry,int maths)
        {
            s_studentId++;
            StudentId="SF"+s_studentId;
            
            StudentName=name;
            FatherName=fatherName;
            Gender=gender;
            DOB=dob;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;


        }
        public StudentDetails(string data)
        {
          string[] values=data.Split(',');

            StudentId=values[0];
            s_studentId=int.Parse(values[0].Remove(0,2));
            StudentName=values[1];
            FatherName=values[2];
            Gender=Enum.Parse<Gender>(values[3]);
            DOB=DateTime.Parse(values[4]);
            Physics=int.Parse(values[5]);
            Chemistry=int.Parse(values[6]);
            Maths=int.Parse(values[7]);   
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}