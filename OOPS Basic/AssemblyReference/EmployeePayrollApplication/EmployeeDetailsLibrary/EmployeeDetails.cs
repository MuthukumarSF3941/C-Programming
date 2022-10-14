

namespace EmployeeDetailsLibrary
{

    public enum WorkLocation{Default,Madura,Eymard}
    public enum Gender{Default,Male,Female,TransGender}
    public class EmployeeDetails
    {
        
       
       
       

        public string EmployeeId {get; set; }

        public string Name { get; set; }

        public string Role { get; set; }

        public WorkLocation WorkLocation { get; set; }

        public string TeamName { get; set; }

        public DateTime DateOfJoining { get; set; }

        public int TotalWorkingDays { get; set; }
        
        

        public int Leave { get; set; }

        
        
        public Gender Gender { get; set; }

        
        
        public EmployeeDetails(string name,string employeeId,string role,WorkLocation workLocation,string teamName,Gender gender,int leave,int totalWorkingDays,DateTime dateOfJoining)
        {
           Name=name;
           EmployeeId=employeeId;
           Role=role;
           Gender=gender;
           WorkLocation=workLocation;
           TeamName=teamName;
           Leave=leave;
           TotalWorkingDays=totalWorkingDays;
           DateOfJoining=dateOfJoining;

        }

           public int CalculateSalary(int TotalWorkingDays,int Leave)
           {
               int salary=(TotalWorkingDays-Leave)*500;
                      return salary;
           }
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}