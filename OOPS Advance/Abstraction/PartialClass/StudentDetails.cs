using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{

    public  enum Dept{Default,EEE,CSE,ECE};
    public enum Gender{Male,Female};
    public partial class StudentDetails
    {

        //properties
        private static int s_studentId=1000;
        
        public string StudentId { get; set; }

        public Dept Department { get; set; }

        public string Year { get; set; }

        
       
    }
}