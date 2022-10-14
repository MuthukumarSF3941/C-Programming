using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGrocery
{
    public class CustomerDetails : PersonalDetails,IBalance
    {
        private static int s_customerI=1000;
         
         public string CustomerId { get; set; }

        
       public double WalletBalance { get; set; }

        public CustomerDetails(string name,string fatheName,Gender gender,long mobile,DateTime dob,string mail,double walletBalance):base( name, fatheName, gender, mobile, dob, mail)
        {
            s_customerI++;
            CustomerId="CID"+s_customerI;
         
        }
        public CustomerDetails(string data)
        {

            string[] value=data.Split(',');
            s_customerI=int.Parse(value[0].Remove(0,3));
            CustomerId=value[0];
            Name=value[1];
            FatherName=value[2];
            Gender=Enum.Parse<Gender>(value[3],true);
            MobileNumber=long.Parse(value[4]);
            DOB=DateTime.ParseExact(value[5],"dd/MM/yyyy",null);
            MailId=value[6];
            WalletBalance=double.Parse(value[7]);
         
        }

        public void WalletRecharge()
        {
           System.Console.WriteLine("Enter amount to recharge");
           double amount=double.Parse(Console.ReadLine());
           WalletBalance+=amount;
           System.Console.WriteLine("balance is:"+WalletBalance);
        }

        public void ShowCustomerDetails()
        {
         System.Console.WriteLine($"Customer Id:{CustomerId} Name:{Name} FatherName:{FatherName} Gender:{Gender} Mobile:{MobileNumber} DOB:{DOB.ToShortDateString()} EMail:{MailId} ");
        }
    }
}