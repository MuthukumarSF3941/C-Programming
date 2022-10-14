using System;

namespace PartialClass;

public class MyClass
{
    public static void Main(string[] args)
    {
        StudentDetails student =new StudentDetails("4567","Franklin","Antony",23456789,Gender.Male,Dept.CSE,"frst");
        student.showStudent();
    }
}
