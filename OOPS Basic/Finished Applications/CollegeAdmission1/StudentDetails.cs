using System;
/// <summary>
/// used to process the college admission process using this application
/// </summary>


namespace CollegeAdmission1
{
   /// <summary>
   /// used to specify the gender 
   /// </summary>
   public enum Gender{Default,Male,Female,transGender}

/// <summary>
/// class of<see cref="StudentDetails"/>used to create multiple properties to store details of the student
/// </summary>
    public class StudentDetails
    {
        //fields

        private static int s_registerNumber=3000;
          /// <summary>
          /// used to Generate the regist2r number
          /// </summary>
          /// <value></value>
        public string RegisterNumber { get; }
        
        
        //private string _name;
        // public string Name { get{return _name;} set{_name=value;} }
        /// <summary>
        /// used to store the Name  of the student
        /// </summary>
        /// <value></value>
         public string Name { get; set; }    //Auto property

         /// <summary>
        /// used to store the Father Name  of the student
        /// </summary>
        /// <value></value>
         public string FatherName { get; set; }

          /// <summary>
        /// used to store the Date of Birth of the student in DD/MM/YYYY 
        /// </summary>
        /// <value>dd/mm/yyyy</value>
         public DateTime DOB { get; set; }

          /// <summary>
        /// used to store the Gender  of the student
        /// </summary>
        /// <value>Male Female Transgender</value>
         public Gender Gender { get; set; }

          /// <summary>
        /// used to store the phone number of the  of the student Data Type:Long
        /// </summary>
        /// <value></value>
         public long Phone { get; set; }
          /// <summary>
        /// used to store the E-mail address  of the student
        /// </summary>
        /// <value></value>
         public string Mail { get; set; }

          /// <summary>
        /// used to store the physics mark  of the student
        /// </summary>
        /// <value>0-100</value>
         public int Physics { get; set; }
          /// <summary>
        /// used to store the chemistry marks  of the student
        /// </summary>
        /// <value>0-100</value>
         public int Chesmistry { get; set; }
          /// <summary>
        /// used to store the maths marks  of the student
        /// </summary>
        /// <value>0-100</value>
         public int  Maths { get; set; }

         public StudentDetails()            //Default constructor
         {
            Name="Your name";
            FatherName="Your father name";

         }
         
         //parameterized constructor
         /// <summary>
         /// constructor of <see cref="StudentDetails"/> constructor used with parsing the values
         /// </summary>
         /// <param name="name">used to assign the value to the Name property</param>
         /// <param name="fathername">used to assign the value to the FatherName property</param>
         /// <param name="dob">used to assign the value to the DOB property</param>
         /// <param name="phone">used to assign the value to the Phone property</param>
         /// <param name="mail">used to assign the value to the Mail property</param>
         /// <param name="gender">used to assign the value to the Gender property</param>
         /// <param name="physics">used to assign the value to the Physics property</param>
         /// <param name="chemistry">used to assign the value to the Chemistry property</param>
         /// <param name="maths">used to assign the value to the Maths property</param>
         public StudentDetails(string  name,string fathername,DateTime dob,long phone,string mail,Gender gender,int physics,int chemistry,int maths)
         {

            s_registerNumber++;
            RegisterNumber="SF"+s_registerNumber;
            Name=name;
            FatherName=fathername;
            DOB=dob;
            Phone=phone;
            mail=Mail;
            Gender=gender;
            Physics=physics;
            Chesmistry=chemistry;
            Maths=maths;
         }

             /// <summary>
            /// Method of<see cref="StudentDetails" />used to check the eligibility of the student
            /// </summary>\
            /// <param name="cuttOff" >used to find the cuttoff value</param>
            /// <returns>true/false</returns>
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
             /// <summary>
            /// method of<see cref="StudentDetails"/>used to show the details of the student
            /// </summary>
            /// <returns></returns>
         public  void Show()
      {
         
        System.Console.WriteLine($"Register Number:{RegisterNumber}\n Name:{Name}\n Fathe Name:{FatherName}\n DOB:{DOB.ToShortDateString()}\n Gender:{Gender}\n Phone:{Phone}\n E-Mail:{Mail}\n Physics Marks:{Physics}\n Chemistry Marks:{Chesmistry}\n Maths Marks:{Maths}\n");
      }
         //destructor
          ~StudentDetails()
         {
            
         }
        
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         

         
         
    }
}