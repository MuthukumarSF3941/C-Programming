using System;

namespace MultipleInheritance;

class Program
{
    public static void Main(string[] args)
    {
        PersonalDetails personal=new PersonalDetails("Muthu kumar","Franklin",9566503260,Gender.Male);
        personal.showDetails();

        StudentDetails student=new StudentDetails("AID1002","Joseph","Franklin",9342951832,Gender.Male,Dept.CSE,"Final");
        System.Console.WriteLine("---------Stdent Details--------");
        student.showStudent();
        student.getMarks(90,98,78);
         student.calculate();
        student.showMark();
       

        CustomerDetails customer=new CustomerDetails("AID1003","Joseph franklin","John bosco",6789054345,Gender.Male);
        customer.recharge();
        System.Console.WriteLine("------------Customer Details-------------");
        customer.showCustomer();




    }
}
