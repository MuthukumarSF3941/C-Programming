using System;
using System.Collections.Generic;

namespace CollegeAdmission;

class Program
{
    public static void Main(string[] args)
    {
        List<StudentDetails> studentList=new List<StudentDetails>();
        System.Console.WriteLine("Are you willing to join this college Yes/no");
        string willing=Console.ReadLine().ToLower();

         { 
        System.Console.WriteLine("Read data");      //using parameterized constructors

        System.Console.WriteLine("Enter name");
        string name=Console.ReadLine();
    
        System.Console.WriteLine("Enter fathername");
        string fatherName=Console.ReadLine();
    
        System.Console.WriteLine("Enter DOB in dd/mm/yyyy format");
       DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        System.Console.WriteLine("Enter gender");
        string gender=Console.ReadLine();

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

     while(willing=="yes")
     {                                                        //using Default constructor
        System.Console.WriteLine("Read data");

        StudentDetails student1=new StudentDetails();        //object creation

        System.Console.WriteLine("Enter name");
        student1.Name=Console.ReadLine();
    
        System.Console.WriteLine("Enter fathername");
        student1.FatherName=Console.ReadLine();
    
        System.Console.WriteLine("Enter DOB in dd/mm/yyyy format");
        student1.DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        System.Console.WriteLine("Enter gender");
        student1.Gender=Console.ReadLine();

        System.Console.WriteLine("enter phone number");
        student1.Phone=long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Email");
        student1.Mail=Console.ReadLine();

        System.Console.WriteLine("Enter physics marks");
        student1.Physics=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter chemistry marks");
        student1.Chesmistry=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter maths marks");
        student1.Maths=int.Parse(Console.ReadLine());

        studentList.Add(student1);

        System.Console.WriteLine("Admitted");

        System.Console.WriteLine("Are you willing to join this college Yes/no");
         willing=Console.ReadLine().ToLower();
     }

     //destructor

     
        foreach (StudentDetails student in studentList)
        {
            System.Console.WriteLine("Student details are");
     System.Console.WriteLine($" Name:{student.Name}\n Fathe Name:{student.FatherName}\n DOB:{student.DOB.ToShortDateString()}\n Gender:{student.Gender}\n Phone:{student.Phone}\n E-Mail:{student.Mail}\n Physics Marks:{student.Physics}\n Chemistry Marks:{student.Chesmistry}\n Maths Marks:{student.Maths}\n");
      
        }
    }
}
