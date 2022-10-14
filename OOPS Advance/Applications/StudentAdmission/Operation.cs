using System;


namespace StudentAdmission
{
    public static class Operation
    {
        public static List<StudentDetails> studentList = new List<StudentDetails>();
        public static List<DepartmentDetails> departList=new List<DepartmentDetails>();

       public static List<AdmissionDetails> add=new List<AdmissionDetails>();

       
         

        
     static StudentDetails currentStudent=null; 
    

        
        public static void MainMenu()
        {
            int choice;
            do
            {
                System.Console.WriteLine("Enter your option 1.Student Registeration  2.Student Login  3.Check Department wise Seat availability  4.Exit");
                choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Student Registeration");
                        Registeration();
                        break;
                    }
                      case 2:
                    {
                        System.Console.WriteLine("Student Login");
                        Login();
                        
                        break;
                    }
                      case 3:
                    {
                        System.Console.WriteLine("department wise Seats availability");
                        showAvailability();
                        break;
                    }
                      case 4:
                    {
                        System.Console.WriteLine("Exit");
                        break;
                    }
                    default:
                        break;
                }
                

            
            } while (choice!=4);
        }
        
        public static void Registeration()
        {
            System.Console.WriteLine("Enter student Name");
            string studentName=Console.ReadLine();
            
            System.Console.WriteLine("Enter your FatherName");
            string fatherName=Console.ReadLine();

            System.Console.WriteLine("Enter date of birth");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

            System.Console.WriteLine("Enter Gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

            System.Console.WriteLine("Enter physics Marks");
            int physics=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter chemistry Marks");
            int chemistry=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter Maths Marks");
            int maths=int.Parse(Console.ReadLine());

            StudentDetails student=new StudentDetails(studentName,fatherName,gender,dob,physics,chemistry,maths);
            studentList.Add(student);

            System.Console.WriteLine($"your student Id is {student.StudentId}");

            
        }
        
        public static void Login()

        {
            System.Console.WriteLine("Enter your StudentID");
            string studentId=Console.ReadLine().ToUpper();
            
            
            foreach (StudentDetails student3 in studentList)
            {
                if(studentId==student3.StudentId)
                {
                    System.Console.WriteLine("Login Sucessfully");
                    currentStudent=student3;
                    
                    
                    subMenu();

                }
               
            } System.Console.WriteLine("Wrong student Id");
        }
        
        public static void subMenu()
        {
            int choice;
            do
            {
                System.Console.WriteLine("Enter your choice 1.Check Eligibility 2.Show Details 3.Take Admission 4.cancel Admission 5.Show AdmissionDetails 6.Exit");
                choice=int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("check eligibility");
                        bool temp=currentStudent.CheckEligibility(75);
                        if(temp){
                            System.Console.WriteLine("You are eligible");
                        }
                        else{
                            System.Console.WriteLine("You are not eligible");
                        }
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("show Details");
                        currentStudent.ShowDetails();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("take admission");
                        show();
                        takeAdmission();

                        break;
                    }
                    case 4:
                    {
                        CancelAdmission();
                        System.Console.WriteLine("cancel Admission");
                        break;
                    }
                    case 5:
                    {
                        AdmissionHistory();
                        System.Console.WriteLine("show Admission Details");
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("Exit sub Menu");
                        break;
                    }
                    default:
                        break;
                }
                
                
            } while (choice!=6);
        }
   
    

           public static  void DefaultMenu()
         {

            StudentDetails studentDefault1=new StudentDetails("ravichandran","Ettapparajan",Gender.Male,new DateTime(1999,11,11),95,95,95);
         studentList.Add(studentDefault1);
         StudentDetails studentDefault2=new StudentDetails("Baskaran","Sethurajan",Gender.Male,new DateTime(1999,11,11),95,95,95);
         studentList.Add(studentDefault2);
            DepartmentDetails dept1=new DepartmentDetails("EEE",29);
            departList.Add(dept1);
              DepartmentDetails dept2=new DepartmentDetails("CSE",29);
            departList.Add(dept2);
              DepartmentDetails dept3=new DepartmentDetails("MECH",30);
            departList.Add(dept3);
              DepartmentDetails dept4=new DepartmentDetails("ECE",30);
            departList.Add(dept4);

            AdmissionDetails Admission1=new AdmissionDetails(studentDefault1.StudentId,dept1.DeptId,Status.Admitted,DateTime.Now);
            dept1.SeatsAvailable--;
            add.Add(Admission1);
            AdmissionDetails Admission2=new AdmissionDetails(studentDefault2.StudentId,dept2.DeptId,Status.Admitted,DateTime.Now);
            dept2.SeatsAvailable--;
            add.Add(Admission2);


         }
           public static void show()
         {
            foreach(DepartmentDetails student in departList)
            System.Console.WriteLine($"Department:{student.DepartmentName} Department ID:{student.DeptId}");
         }
          public static void showAvailability()
         {
            foreach(DepartmentDetails student in departList)
            System.Console.WriteLine($"Department:{student.DepartmentName} Department ID:{student.DeptId}, Seats Available:{student.SeatsAvailable}");
         }

         public static void takeAdmission()
         {
            System.Console.WriteLine("Enter Department Id");
            string deptId=Console.ReadLine().ToUpper();
    

            foreach (DepartmentDetails dept in departList)
            {
                if(deptId==dept.DeptId)
                {
                    if (dept.SeatsAvailable>1)
                    {
                        System.Console.WriteLine("Seats are available at this department");
                        
                        bool eligibility=currentStudent.CheckEligibility(75);
                        if (eligibility)
                        {
                             bool canAdmit=true;
                            System.Console.WriteLine("Yor are eligible to admit");

                            foreach (AdmissionDetails status in add)
                            {
                       
                               if(status.StudentId==currentStudent.StudentId)
                               {
                                 if(status.AdmisisonStatus==Status.Admitted)
                                {
                                    System.Console.WriteLine("Already abmitted");
                                    canAdmit=false;
                                }
                              
                               }

                            }
                                 if(canAdmit==true)
                        {  
                                       foreach (DepartmentDetails tempdept in departList)
                                       {
                                        if(deptId==tempdept.DeptId)
                                        {
                                            tempdept.SeatsAvailable--;
                                            AdmissionDetails admission3=new AdmissionDetails(currentStudent.StudentId,tempdept.DeptId,Status.Admitted,DateTime.Now);
                                            add.Add(admission3);
                                             System.Console.WriteLine("You are admitted");
                                       System.Console.WriteLine($"Your admission id is:{admission3.AdmissionId}");
                                        }
                                       }
                                
                        }


                        }
                   
                    }
                    else
                    {
                        System.Console.WriteLine("No seats available");
                    }
                }
            }            
         }

         public static void DpetSeatsavailable()
         {
            System.Console.WriteLine("Enter department Id");
            string deptid=Console.ReadLine().ToUpper();
            
            
         }

         public static void CancelAdmission()
         {
                    System.Console.WriteLine("Enter AdmissionID");
                    string addId=Console.ReadLine().ToUpper();
                    
              
                    foreach (AdmissionDetails status in add)
                    {
                    if(currentStudent.StudentId==status.StudentId){
                       if(status.AdmisisonStatus==Status.Admitted)
                        {
                           status.AdmisisonStatus=Status.Cancelled;
                           System.Console.WriteLine("Admission cancelled");
                           foreach (DepartmentDetails dept in departList)
                           {
                              if(status.DeptId==dept.DeptId)
                              {
                              dept.SeatsAvailable++;
                              }
                           }
                        }

                    }  
                    }
                }
         

         public static void AdmissionHistory()
         {
            foreach (AdmissionDetails History in add)
            {
                if(currentStudent.StudentId==History.StudentId)
                {
                    System.Console.WriteLine($"    Admission ID :{History.AdmissionId}\n  student ID:{History.StudentId}\t Department Id:{History.DeptId}\t Date Booked:{History.DateBooked}, Admission status:{History.AdmisisonStatus}");
                }
            }
         }
   
   
   
   
    }
            
}
   
   
   
   
   
   
    



