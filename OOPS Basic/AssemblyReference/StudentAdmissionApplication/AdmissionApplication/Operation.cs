using System;
using AdmissionLibrary;
using System.Collections.Generic;

namespace AdmissionApplication;

public class Operations
{
    public static void MainMenu()
    {
        List<StudentDetails> studentList=new List<StudentDetails>();
        System.Console.WriteLine("Are you willing to join this college Yes/no");
        string willing=Console.ReadLine().ToLower();

         while(willing=="yes")
         { 
        System.Console.WriteLine("Read data");      //using parameterized constructors

        System.Console.WriteLine("Enter name");
        string name=Console.ReadLine();
    
        System.Console.WriteLine("Enter fathername");
        string fatherName=Console.ReadLine();
    
        System.Console.WriteLine("Enter DOB in dd/mm/yyyy format");
       DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        System.Console.WriteLine("Enter gender Male/Female/Transgender");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

        System.Console.WriteLine("enter phone number");
        long phone=long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Email");
        string mail=Console.ReadLine();

        System.Console.WriteLine("Enter physics marks");
        int physics=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter chemistry marks");
       int chemistry=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter maths marks");
        int maths=int.Parse(Console.ReadLine());

        StudentDetails student1=new StudentDetails(name,fatherName,dob,phone,mail,gender,physics,chemistry,maths);        //object creation
        studentList.Add(student1);

        System.Console.WriteLine("Admitted");

        System.Console.WriteLine("Are you willing to join this college Yes/no");
         willing=Console.ReadLine().ToLower();
         }
        

        foreach (StudentDetails student in studentList)
        {
            System.Console.WriteLine("Student details are");
     System.Console.WriteLine($"Register Number:{student.RegisterNumber}\n Name:{student.Name}\n Fathe Name:{student.FatherName}\n DOB:{student.DOB.ToShortDateString()}\n Gender:{student.Gender}\n Phone:{student.Phone}\n E-Mail:{student.Mail}\n Physics Marks:{student.Physics}\n Chemistry Marks:{student.Chesmistry}\n Maths Marks:{student.Maths}\n");
           bool eligible=student.CheckEligibility(75.0);
           if (eligible)
           {
            System.Console.WriteLine("You are eligible for joining");
           }
           else{
            System.Console.WriteLine("You are not eligible");
           }
        }
    }
}
