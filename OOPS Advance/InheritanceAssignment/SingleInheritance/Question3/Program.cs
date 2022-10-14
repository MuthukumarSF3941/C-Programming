using System;

namespace Question3;

public class Program
{
    public static void Main(string[] args)
    {
        SalaryInfo salary=new SalaryInfo("Franklin","Joseph","muthuempire20012gmail.com",Gender.Male,98865,new DateTime(2001,01,17),20,new DateTime(2020,10,11),"April",50000);
        salary.show();
    }
}
