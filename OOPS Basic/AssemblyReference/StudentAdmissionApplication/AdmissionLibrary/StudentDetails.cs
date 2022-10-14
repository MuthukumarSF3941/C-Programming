

namespace AdmissionLibrary
{
   public enum Gender{Default,Male,Female,transGender}
    public class StudentDetails
    {
        //fields

        private static int s_registerNumber=3000;

        public string RegisterNumber { get; }
        
        
        //private string _name;
        // public string Name { get{return _name;} set{_name=value;} }
         public string Name { get; set; }    //Auto property
         public string FatherName { get; set; }
         public DateTime DOB { get; set; }
         public Gender Gender { get; set; }
         public long Phone { get; set; }
         public string Mail { get; set; }
         public int Physics { get; set; }
         public int Chesmistry { get; set; }
         public int  Maths { get; set; }

         public StudentDetails()            //Default constructor
         {
            Name="Your name";
            FatherName="Your father name";

         }
         //parameterized constructor
         public StudentDetails(string  name,string fathername,DateTime dob,long phone,string mail,Gender gender,int physics,int chemistry,int maths)
         {
            s_registerNumber++;
            RegisterNumber="SF"+s_registerNumber;
            Name=name;
            FatherName=fathername;
            DOB=dob;
            Phone=phone;
            Mail=mail;
            Gender=gender;
            Physics=physics;
            Chesmistry=chemistry;
            Maths=maths;
         }

         public bool CheckEligibility(double cuttOff)
         {
            double average=(double)(Physics+Chesmistry+Maths)/3.0;
            if(average>=cuttOff)
            {
               return  true;
            }
            else
            {
               return false;
               
            }
         }
         //destructor
          ~StudentDetails()
         {
            
         }
        
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         

         
         
    }
}