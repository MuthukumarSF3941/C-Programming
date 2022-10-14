using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApplication
{
    public static class Operation
    {
         static List<CustomerDetails> customers=new List<CustomerDetails>();
          static CustomerDetails exist=new CustomerDetails();
          static int choice;
         
        static int balance=0;
       
        public static void MainMenu()
        {

         

        do
        {
            System.Console.WriteLine("Enter your choice\n  1.Registration\n 2.Login\n 3.Exit");
             choice=int.Parse(Console.ReadLine());

             switch (choice)
             {
                case 1:
                System.Console.WriteLine("Registration");
                Registration();
                
               

                    break;
                case 2:
                System.Console.WriteLine("Login");
                Login();

                    break;
                case 3:
                System.Console.WriteLine("Exit");

                    break;
                default:
                    break;
             }
        } while (choice!=3);

        }
        public static void Registration()
        {
           System.Console.WriteLine("Enter your name:");
            string name=Console.ReadLine().ToUpper();
            
            System.Console.WriteLine("Enter your Father Name:");
            string fatherName=Console.ReadLine().ToUpper();

            System.Console.WriteLine("Enter your gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            
            
            System.Console.WriteLine("Enter date of birth in dd/mm/yyyy");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

            System.Console.WriteLine("Select account type SB/FD/RD");
            AccoutType accoutType=Enum.Parse<AccoutType>(Console.ReadLine(),true);
            
            CustomerDetails customer=new CustomerDetails(name,fatherName,gender,dob,accoutType,balance);
            customers.Add(customer);
            System.Console.WriteLine($"Customer ID={customer.CustomerId}");
      
          
        }
        
         

         public static void Login()
         {
            System.Console.WriteLine("Enter customer ID");
            string cId=Console.ReadLine().ToUpper();
            foreach (CustomerDetails person in customers)
         {
            if(cId==person.CustomerId)
            {
               System.Console.WriteLine("Log in successfull");
               exist=person;
               subMenu();

            }
            else{
                System.Console.WriteLine("Enter again");
            }
         }
        }
         
         public static void subMenu()
              {
                int option=0;
               do{
                   System.Console.WriteLine("Enter choice: 1.Show Details\n 2.Withdraw\n 3.Deposit\n 4.Show Balance 5.Exit  ");
                     option=int.Parse(Console.ReadLine());

               switch (option)
               {
                case 1:
                System.Console.WriteLine("Show details");
                exist.ShowDetails();
                    break;

                case 2:
                System.Console.WriteLine("Withdrwl");
                exist.Withdraw();
                break;

                case 3:
                System.Console.WriteLine("Deposit");
                exist.Deposit();
                break;

                case 4:
                exist.ShowBalance();
                
                break;

                case 5:
                System.Console.WriteLine(" sub menu Exit");
                 break;


                default:
                    break;
               }
               }while(option!=5);
         }
   
    }       
    
}