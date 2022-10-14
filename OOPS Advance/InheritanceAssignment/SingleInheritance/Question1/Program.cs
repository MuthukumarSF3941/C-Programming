using System;

namespace Question1;

class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("Franklin","Joseph","muthuempire20012gmail.com",Gender.Male,98865544,new DateTime(2001,01,17),"first","cse",2018);
        student.Show();
    }
}
