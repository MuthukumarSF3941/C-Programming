using System;
using System.Collections.Generic;
using CustomerDetailsLibrary;

namespace EbCalculation;

public class Operation
{
    public static void MainMenu()
    {
        System.Console.WriteLine("Do you want to calculate EB bill amount Yes/no");
        string choice=Console.ReadLine().ToLower();
        List<CustomerDetails> list=new List<CustomerDetails>();

        while(choice=="yes")
        {
          System.Console.WriteLine("Enter customer Name");
          string name=Console.ReadLine();

          System.Console.WriteLine("Enter Meter Id");
          string meterId=Console.ReadLine();
          
          System.Console.WriteLine("Enter phone number");
          long phone=long.Parse(Console.ReadLine());

          System.Console.WriteLine("Enter Mail Id");
          string email=Console.ReadLine();
          
          System.Console.WriteLine("Enter units used");
          int units=int.Parse(Console.ReadLine());

          CustomerDetails customer=new CustomerDetails(name,meterId,email,phone,units);
          list.Add(customer);

          System.Console.WriteLine("Do you want to calculate EB bill amount Yes/no");
         choice=Console.ReadLine().ToLower();

        }
        foreach (CustomerDetails customers in list)
        {
            System.Console.WriteLine($" Customer Name:{customers.Name}\n Meter Id:{customers.MeterId}\n E-Mail;{customers.Email}\n Phone Number:{customers.Phone}\n Units Used:{customers.Units}");
            int billAmount=customers.BillAmount(customers.Units);
            System.Console.WriteLine($"Bill Amount need to pay is:{billAmount} Rupees");
        }
        
    }
}
