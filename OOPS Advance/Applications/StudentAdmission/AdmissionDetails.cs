using System;


namespace StudentAdmission
{
  public enum Status{Admitted,Cancelled};
    public  class AdmissionDetails
    {
      public  static int s_admissionId=1000;
      static StudentDetails studentA=null;
  
      
        public  string AdmissionId { get; set; }

        public  Status AdmisisonStatus { get; set; }

        public DateTime DateBooked { get; set; }

        public  string StudentId { get; set; }

        public string DeptId { get; set; }
        
        
        
        
        
        
        
        

         public  AdmissionDetails(string studentId,string deptId,Status admissionstatus,DateTime dateBooked)
        {
           s_admissionId++;
           AdmissionId="AID"+s_admissionId;
           StudentId=studentId;
           AdmisisonStatus=admissionstatus;
           DateBooked=dateBooked;
           DeptId=deptId;
           
        }

         public  AdmissionDetails(string data)
        {
          string[] value=data.Split(',');
          
           AdmissionId=value[0];
            s_admissionId=int.Parse(value[0].Remove(0,3));
           StudentId=value[1];
           AdmisisonStatus=Enum.Parse<Status>(value[2]);
           DateBooked=DateTime.Parse(value[3]);
           DeptId=value[4];
           
        }

       


        
        
        
    }
}