using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData
{
    public static class StudentInfo
    {
        public static int s_registerNumber;
       /* public static int RegisterNumber 
        {
          get
          {
             return s_registerNumber;
          }
          set
          {
            value=s_registerNumber;
          }

         }*/
         public static string Name { get; set; }
         
         

        static StudentInfo()
        {
           s_registerNumber=3941;
           Name="Franklin";
        }
        
        public static void Display()
        {
            System.Console.WriteLine($"Name is:{Name}");
            System.Console.WriteLine($"register Number is:{s_registerNumber}");
        }


        
        
        
        
    }
}