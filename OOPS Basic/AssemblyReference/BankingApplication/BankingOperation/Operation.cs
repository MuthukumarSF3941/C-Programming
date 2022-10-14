using System;
using System.Collections.Generic;
using BankingLibrary;


namespace BankingOperation;

public class Operation
{
    public static void MainMenu()
    {
        List<CustomerDetails> customers=new List<CustomerDetails>();
        int balance=0;

        System.Console.WriteLine("Do you want to create an Account Yes/no");
        string chose=Console.ReadLine().ToLower();
         while (chose=="yes")
         {
            System.Console.WriteLine("Enter your name:");
            string name=Console.ReadLine().ToUpper();
            
            System.Console.WriteLine("Enter your Father Name:");
            string fatherName=Console.ReadLine().ToUpper();

            System.Console.WriteLine("Enter your gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            
            
            System.Console.WriteLine("Enter date of birth in dd/mm/yyyy");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

            System.Console.WriteLine("Select account type savings/current");
            AccoutType accoutType=Enum.Parse<AccoutType>(Console.ReadLine(),true);
            
            CustomerDetails customer=new CustomerDetails(name,fatherName,gender,dob,accoutType,balance);
            customers.Add(customer);
         

            System.Console.WriteLine("Do you want to create account yes/no");
            chose=Console.ReadLine().ToLower();
         }

         foreach (CustomerDetails person in customers)
         {
            System.Console.WriteLine($" Customer ID:{person.CustomerId}\n Customer name:{person.Name}\n Father's Name:{person.FatherName}\n Date of birth:{person.DOB.ToShortDateString()}\n Gender:{person.Gender}\n Account Type:{person.AccoutType}\n balance:{person.Balance}");
                person.Deposit();
                person.Withdraw();
                person.ShowBalance();
            
         }
        
    }
}