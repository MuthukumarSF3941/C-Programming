using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class AccountInfo : PersonalInfo
    {
        private static int s_accountNumber=100000;

        public string AccountNumber { get; set; }

        public string IFSCCode { get; set; }
        
        public double Balance { get; set; }

        public AccountInfo(string name,string fatherName,string mail,Gender gender,long phone,DateTime dob,string ifscCode, double balance):base( name, fatherName, mail, gender, phone, dob)
        {
            s_accountNumber++;

            AccountNumber="SBI"+s_accountNumber;
            IFSCCode=ifscCode;
            Balance=balance;


        }

        public void show()
        {
            System.Console.WriteLine($"IFSC Code;{IFSCCode}\n Balance:{Balance}");
            
        }
        
        
        
        
        
        
    }
}