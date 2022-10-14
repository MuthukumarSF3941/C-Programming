using System;
using System.Collections.Generic;


namespace EbBillCalculator
{
    public static class Operation
    {
       static List<CustomerDetails> list=new List<CustomerDetails>();
       static CustomerDetails Existingcustomer=new CustomerDetails();

       public static void MainMenu()
       {
        int choice;
        do
        {
            System.Console.WriteLine("Enter youer choice  1.Registration 2.Login 3.Exit");
            choice=int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    System.Console.WriteLine("Registration");
                    Registration();
                    break;
                }
                 case 2:
                {
                    System.Console.WriteLine("LogIn");
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
       
       public static void Registration()
       {
        System.Console.WriteLine("Enter customer Name");
          string name=Console.ReadLine();
          
          System.Console.WriteLine("Enter phone number");
          long phone=long.Parse(Console.ReadLine());

          System.Console.WriteLine("Enter Mail Id");
          string email=Console.ReadLine();
          
         

          CustomerDetails customer=new CustomerDetails(name,email,phone);
          list.Add(customer);
          System.Console.WriteLine("Meter ID is"+customer.MeterId);
       }
    
       public static void Login()
       {
        System.Console.WriteLine("Enter your Meter id");
        string meterId=Console.ReadLine().ToUpper();
        foreach (CustomerDetails customers in list)
        {
            if(meterId==customers.MeterId)
            {
              System.Console.WriteLine("Log in sucessfull");
              Existingcustomer=customers;
              SubMenu();

            }
            else
            {
                System.Console.WriteLine("Try again");
            }
        }
        
       }
    
       public static void SubMenu()
       {
        int choice;
        do
        {
            System.Console.WriteLine("Enter your choice 1.Show Details  2.Enter Units  3.BillCalculate 4.Exit ");
            choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                {
                    System.Console.WriteLine("Get Details");
                    Existingcustomer.ShowDetails();
                     break;
                }
                 case 2:
                {
                    System.Console.WriteLine("Enter Units");
                    Existingcustomer.EnterUnits();
                     break;
                }
                 case 3:
                {
                    System.Console.WriteLine("Bill Calculation");
                    Existingcustomer.BillAmount(Existingcustomer.Units);
                     break;
                }
                 case 4:
                {
                    System.Console.WriteLine("Exit Sub menu");
                     break;
                }
                   
                default:
                    break;
            }
            
            
        } while (choice!=4);
       }
    
    }
}