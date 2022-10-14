using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll
{

    public enum WorkLocation{Default,Madura,Eymard}
    public enum Gender{Default,Male,Female,TransGender}
    public class EmployeeDetails
    {
        
       static int  s_employeeId=1000;
       
       

        public string EmployeeId {get; set; }

        public string Name { get; set; }

        public string Role { get; set; }

        public WorkLocation WorkLocation { get; set; }

        public string TeamName { get; set; }

        public DateTime DateOfJoining { get; set; }

        public int TotalWorkingDays { get; set; }
        
        

        public int Leave { get; set; }

        
        
        public Gender Gender { get; set; }

        
        public EmployeeDetails()
        {

        }
        public EmployeeDetails(string name,string role,WorkLocation workLocation,string teamName,Gender gender,int totalWorkingDays,DateTime dateOfJoining)
        {

            s_employeeId++;
            
           Name=name;
           EmployeeId="SF"+s_employeeId;
           Role=role;
           Gender=gender;
           WorkLocation=workLocation;
           TeamName=teamName;
           TotalWorkingDays=totalWorkingDays;
           DateOfJoining=dateOfJoining;

        }

           public void CalculateSalary(int TotalWorkingDays,int Leave)
           {
               int salary=(TotalWorkingDays-Leave)*500;
                     System.Console.WriteLine("Total Salary="+salary);
           }
        public void ShowDetails()
        {
         System.Console.WriteLine($" Employee Name:{Name}\n Employee Id{EmployeeId}\n Employee Role{Role}\n Gender:{Gender}\n Date Of Joining:{DateOfJoining.ToShortDateString()}\n Team Name:{TeamName}\n WorkLocation:{WorkLocation}\n Toatal Working Days:{TotalWorkingDays} ");
        }
        
        public void LeavesTaken()
        {
            System.Console.WriteLine("Enter leaves taken");
            int Leaves=int.Parse(Console.ReadLine());

            
        }
        
        
        
        
        
        
        
        
        
        
    }
}