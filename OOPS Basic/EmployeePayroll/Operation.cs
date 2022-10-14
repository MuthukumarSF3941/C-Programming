using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public static class Operation
    {

        static List<EmployeeDetails> EmployeeList=new List<EmployeeDetails>();
        static EmployeeDetails one=new EmployeeDetails();
        public static void MainMenu()
        {
            int choice;
            do
            {
                System.Console.WriteLine("Enter your choice 1.Registeration 2.Login 3.Exit");
                 choice=int.Parse(Console.ReadLine());

                 switch (choice)
                 {
                    case 1:
                    {
                        System.Console.WriteLine("Registeration");
                        Registeration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Login");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit");
                        break;
                    }
                        
                    default:
                        break;
                 }
                 
            } while (choice!=3);
            

        }

        public static void Registeration()
        {
            System.Console.WriteLine("Enter Employee Name");
            string name=Console.ReadLine();
            

          
            
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

           EmployeeDetails employee=new EmployeeDetails(name,role,workLocation,teamName,gender,totalWorkingDays,dateOfJoining);
           EmployeeList.Add(employee);

           System.Console.WriteLine("Employee ID is:"+employee.EmployeeId);

        }

        public static void Login()
        {
          System.Console.WriteLine("Enter employee Id");
          string employeeId=Console.ReadLine().ToUpper();
           foreach (EmployeeDetails person in EmployeeList)
            {
              if(employeeId==person.EmployeeId)
              {
                System.Console.WriteLine("login successfull");
                one=person;
                SubMenu();
              }
            }
          
        }

        public static void SubMenu()
        {
          int choice;
          do
          {
            System.Console.WriteLine("Enter your choice 1.Employee details 2.Enter Leaves Taken 3.ShowSalary 4.Exit");
            choice=int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                 {
                    System.Console.WriteLine("show Details");
                    one.ShowDetails();
                       break;
                 }
                 case 2:
                 {
                    System.Console.WriteLine("Leaves Taken");
                    one.LeavesTaken();
                       break;
                 }
                 case 3:
                 {
                    one.CalculateSalary(one.TotalWorkingDays,one.Leave);
                  
                       break;
                 }
                 case 4:
                 {
                    System.Console.WriteLine("Exit sub menu");
                       break;
                 }
                default:
                    break;
            }
            
          } while (choice!=4);
        }
    }
}