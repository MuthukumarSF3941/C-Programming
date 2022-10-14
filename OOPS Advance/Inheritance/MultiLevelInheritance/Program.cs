using System;

namespace MultiLevelInheritance;

class Program
{
    public static void Main(string[] args)
    {
        PersonalDetails personal=new PersonalDetails("Muthu kumar","Franklin",9566503260,Gender.Male);
        personal.showDetails();

        StudentDetails student=new StudentDetails("AID1001","Joseph","Franklin",9342951832,Gender.Male,Dept.CSE,"Final");
        System.Console.WriteLine("---------Stdent Details--------");
        student.showStudent();
        

        CustomerDetails customer=new CustomerDetails("AID1001","Joseph franklin","John bosco",6789054345,Gender.Male);
        customer.recharge();
        System.Console.WriteLine("------------Customer Details-------------");
        customer.showCustomer();

        EmploymentDetails employment=new EmploymentDetails("SID1001","AID1001","Joseph","Franklin",9342951832,Gender.Male,Dept.CSE,DateTime.Now);
        System.Console.WriteLine("---------Employment Details Details--------");
        employment.showEmployment();




    }
}
