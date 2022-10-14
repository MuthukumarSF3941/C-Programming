using System;
using EmployeeDetailsLibrary;
using System.Collections.Generic;

namespace PayrollOperation;

public class Operation
{
    public static void MainMenu()
    {

    
        System.Console.WriteLine("do you want to calculate yes/no");
        string choice=Console.ReadLine().ToLower();
        List<EmployeeDetails> EmployeeList=new List<EmployeeDetails>();

        while (choice=="yes")
        {
            System.Console.WriteLine("Enter Employee Name");
            string name=Console.ReadLine();
            

            System.Console.WriteLine("Enter Employee ID");
            string employeeId=Console.ReadLine();
            
            System.Console.WriteLine("Enter employee role");
            string role=Console.ReadLine();

            System.Console.WriteLine("Enter the worklocation");
            WorkLocation workLocation=Enum.Parse<WorkLocation>(Console.ReadLine(),true);

            System.Console.WriteLine("Enter Gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

            System.Console.WriteLine("Enter Team Name");
            string teamName=Console.ReadLine();

            System.Console.WriteLine("Enter Date of joining");
            DateTime dateOfJoining=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

            System.Console.WriteLine("Enter number of working days in month");
            int totalWorkingDays=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter Number of Leaves Taken");
            int leave=int.Parse(Console.ReadLine());

           EmployeeDetails employee=new EmployeeDetails(name,employeeId,role,workLocation,teamName,gender,leave,totalWorkingDays,dateOfJoining);
           EmployeeList.Add(employee);
         
          
            System.Console.WriteLine("do you want to calculate yes/no");
             choice=Console.ReadLine().ToLower();

        }
         
            foreach (EmployeeDetails person in EmployeeList)
            {
                System.Console.WriteLine("Employee details:");
            System.Console.WriteLine($" Employee Name:{person.Name}\n Employee Id{person.EmployeeId}\n Employee Role{person.Role}\n Gender:{person.Gender}\n Date Of Joining:{person.DateOfJoining.ToShortDateString()}\n Team Name:{person.TeamName}\n WorkLocation:{person.WorkLocation}\n Toatal Working Days:{person.TotalWorkingDays}\n Leaves Taken:{person.Leave} ");
            int salary=person.CalculateSalary(person.TotalWorkingDays,person.Leave);
            System.Console.WriteLine($" salary:{salary}");
           }


    }
}