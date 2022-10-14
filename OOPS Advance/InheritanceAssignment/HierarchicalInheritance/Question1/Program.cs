using System;

namespace Question1;

public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("------Student Details------");
        Student student=new Student("Franklin","Joseph","Muthu kumar@23",Gender.Male,2345678,DateTime.Now,"CSE",8,"B.e");
        student.show();
        student.showStudent();


        System.Console.WriteLine("------Teacher Details------");
        Teacher teacher=new Teacher("Franklin","Joseph","Muthu kumar@23",Gender.Male,2345678,DateTime.Now,"Maths","Cse","M.ed",6,DateTime.Now);
         student.show();
         teacher.showTeacher();


        System.Console.WriteLine("------Princial Details------");
        Principal principal=new Principal("Franklin","Joseph","Muthu kumar@23",Gender.Male,2345678,DateTime.Now,"P101","BE",8,DateTime.Now);
        student.show();
        principal.showPrincipal();



    }
}
