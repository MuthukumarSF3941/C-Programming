using System;
//using System.Collections.Generic;


namespace CollegeAdmission1
{
    public static class Operations
    {
       
        //static List<StudentDetails> studentList=new List<StudentDetails>();
         static StudentDetails CurrentStudent=new StudentDetails();
         static Dictionary<string,StudentDetails> ten=new Dictionary<string, StudentDetails>();

      public static void MainMenu()

      {
        string choice="yes";
        do{
         System.Console.WriteLine("Select Option 1.Registratio 2.LogIn 3.exit");
         int option=int.Parse(Console.ReadLine());
         switch (option)
         {
            case 1:
            {
                System.Console.WriteLine("Registration");
                Registration();
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
                choice="no";
                break;
            }     
            default:
                break;

        }
        
      
         
       } while(choice=="yes"); 
     }
       
      public static void Registration()
      {
          System.Console.WriteLine("Enter name");
        string name=Console.ReadLine();
    
        System.Console.WriteLine("Enter fathername");
        string fatherName=Console.ReadLine();
    
        System.Console.WriteLine("Enter DOB in dd/mm/yyyy format");
       DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        System.Console.WriteLine("Enter gender Male/Female/Transgender");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

        System.Console.WriteLine("enter phone number");
        long phone=long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Email");
        string mail=Console.ReadLine();

        System.Console.WriteLine("Enter physics marks");
        int physics=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter chemistry marks");
       int chemistry=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter maths marks");
        int maths=int.Parse(Console.ReadLine());

        StudentDetails student1=new StudentDetails(name,fatherName,dob,phone,mail,gender,physics,chemistry,maths);        //object creation
        ten.Add(student1.RegisterNumber,student1);

        System.Console.WriteLine("Admitted");
        System.Console.WriteLine("Register Number"+student1.RegisterNumber);

      }

      public static void Login()
      {
        System.Console.WriteLine("Enter register number");
        string reg=Console.ReadLine().ToUpper();
         
       
         
            if(ten.ContainsKey(reg))
            {
                System.Console.WriteLine("login Sucessfull");

                
                //KoCurrentStudent=ten.Array;
                SubMenu();
                
            }
            else{
              System.Console.WriteLine("try again");
            }
         
      }
    
      public static void SubMenu()
      {
        int choice;
        do
        {
            System.Console.WriteLine("Choose option 1.check eligibility 2.show Details 3.Exit");
             choice=int.Parse(Console.ReadLine());
             switch (choice)
             {
                case 1:
                   System.Console.WriteLine("Check eligibility");
                    bool eligible=CurrentStudent.CheckEligibility(75.0);
           if (eligible)
           {
            System.Console.WriteLine("You are eligible");
           }
           else{
            System.Console.WriteLine("You are not eligible");
           }
                    break;
                 case 2:
                 System.Console.WriteLine("Show details");
                   CurrentStudent.Show();
                    break;
                 case 3:
                 System.Console.WriteLine(" SubMenu Exit");
                    break;
                default:
                    break;
             }
            
        } while (choice!=3);

      }
    
    }
      
    
    
}