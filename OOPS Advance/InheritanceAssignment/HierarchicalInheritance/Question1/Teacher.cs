using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Teacher :PersonalInfo
    {
      private static int s_teacherId=100;

      public string TeacherId { get; set; }

      public string SubTeaching { get; set; }

      public string Dept { get; set; }

      public string Qualification { get; set; }

      public int Experience { get; set; }

      public DateTime DateofJoing { get; set; }

      public Teacher(string name,string fatherName,string mail,Gender gender,long phone,DateTime dob,string sub,string dept,string qualification,int experience,DateTime doj):base( name, fatherName, mail, gender, phone, dob)
      {
          s_teacherId++;
          TeacherId="T"+s_teacherId;
          Dept=dept;
          Qualification=qualification;
          Experience=experience;
          DateofJoing=doj;

      }

      public void showTeacher()
      {
        System.Console.WriteLine($"Teacher Id:{TeacherId}\n Dept;{Dept}\n Qualification:{Qualification}\n Experience:{Experience}\n DateofJoing:{DateofJoing} ");
      }


      
      
      
      
      
      
      
      
      
      
      
      
        
    }
}