using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class HseDetails : StudentInfo
    {
        private static int s_marksheetNum=100000;

        public string MarkSheetNumber { get; set; }

        public int Physics { get; set; }

        public int Chemistry { get; set; }

        public int Maths { get; set; }

        public int Total { get; set; }

        public double Average  { get; set; }

        public HseDetails(string name,string fatherName,string mail,Gender gender,long phone,DateTime dob,string satndard,string branch,int acadamicYear,int physics,int chemistry,int maths,int total,double average):base( name, fatherName, mail, gender, phone, dob, satndard, branch, acadamicYear)
        {
           s_marksheetNum++;
           MarkSheetNumber="HSE"+s_marksheetNum;

           Physics=physics;
           Chemistry=chemistry;
           Maths=maths;
           Total=total;
           Average=average;

        }

        public void ShowHse()
        {
            System.Console.WriteLine($" MarkSheetNumber:{MarkSheetNumber}\n Physics\t:{Physics}\n Chemistry\t:{Chemistry}\n Maths\t\t:{Maths}\n Total\t\t:{Total}\n Average\t:{Average} ");
        }
        
        
        
        
        
        
        
        
        
        
        
        
    }
}