using System;

namespace SingleInheritance;

class Program
{
    public static void Main(string[] args)
    {
        PersonalDetails personal=new PersonalDetails("Muthu kumar","Franklin",9566503260,Gender.Male);
        personal.showDetails();

        StudentDetails student=new StudentDetails("AID1001","Joseph","Franklin",9342951832,Gender.Male,Dept.CSE,"Final");
        System.Console.WriteLine(" "+" ");
        student.showStudent();


    }
}
