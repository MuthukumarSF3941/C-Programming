using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public enum Dept{Default,ECE,EEE,CSE}
    public class StudentDetails : PersonalDetails,IMarkDetails
    {
    public int  Physics { get; set; }

    public int Chemistry { get; set; }

     public int Maths { get; set; }

      public int Total { get; set; }

      public Double Average { get; set; }
        private static int s_studentId=1000;
        
        public string StudentId { get; set; }

        public Dept Department { get; set; }

        public string Year { get; set; }

        public StudentDetails(string aId,string name,string fatherName,long phone, Gender gender,Dept department,string year):base( aId, name, fatherName, phone,  gender)
        {
            s_studentId++;
            StudentId="SID"+s_studentId;
            Department=department;
            Year=year;

        }
        
        public void showStudent()
        {
            System.Console.WriteLine($" Student ID\t:{StudentId}");
            showDetails();
            System.Console.WriteLine($" Department\t:{Department}\n Year\t\t:{Year}");
        }

        public void getMarks(int physics,int chemistry,int maths)
        {
            Physics=physics;

            Chemistry=chemistry;
            Maths=maths;


        }

        public void  calculate()
        {
              Total=Physics+Chemistry+Maths;
              Average=Math.Round((double)Total/3,2);

        }

        public void showMark()
        {
           System.Console.WriteLine($" Physics\t:{Physics}\n Chemistry\t:{Chemistry}\n Maths\t\t:{Maths}\n Total\t\t:{Total}\n Average\t:{Average}");
        }
        
        
        
        
        
    }
}