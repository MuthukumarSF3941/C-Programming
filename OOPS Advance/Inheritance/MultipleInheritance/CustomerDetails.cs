using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public class CustomerDetails : PersonalDetails
    {
        private static int s_customerId=1000;

        public string CustomerId { get; set; }

        public double Balance { get; set; }

        public CustomerDetails(string aId,string name,string fatherName,long phone, Gender gender):base( aId, name, fatherName, phone,  gender)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
        }

        public void recharge()
        {
                System.Console.WriteLine("Enter the amount to recharge");
                Balance+=double.Parse(Console.ReadLine());
        }

        public void showCustomer()
        {
            System.Console.WriteLine(" Customer Id\t:"+CustomerId);
            showDetails();
            System.Console.WriteLine(" Balance\t:"+Balance);
        }
        
        
        
        
    }
}