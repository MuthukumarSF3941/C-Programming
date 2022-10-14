using System;

namespace BankingLibrary
{
  public enum Gender{Default,Male,Female,TransGender}
  public enum AccoutType{Default,SB,FD,RD}


    public class CustomerDetails
    {
        private static int s_customerId=1000;
        public string CustomerId { get; }
        
        
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }

        public DateTime DOB { get; set; }

        public AccoutType AccoutType { get; set; }

        public int Balance { get; set; }
        
        


      public CustomerDetails(string name, string fatherName,Gender gender,DateTime dob,AccoutType accoutType,int balance)
      {

        s_customerId++;
        CustomerId="SBI"+s_customerId;
        Name=name;
        FatherName=fatherName;
        Gender=gender;
        DOB=dob;
        AccoutType=accoutType;
        Balance=balance;
      }

      public void Deposit()
      {
        System.Console.WriteLine("Enter amount to deposit");
        int deposit=int.Parse(Console.ReadLine());
        Balance+=deposit;
        System.Console.WriteLine($"{deposit} amount is added to yor account");
      }

      public void Withdraw()
      {
       System.Console.WriteLine("Enter the amount to withdraw");
       int withdraw=int.Parse(Console.ReadLine());
       if(withdraw<=Balance)
       {
        Balance-=withdraw;
        System.Console.WriteLine($"you withderal {withdraw} ");
       }
       else
       {
        System.Console.WriteLine("Insufficient funds");
       }

    
      }
         public void ShowBalance()
       {
        System.Console.WriteLine($"Your Balance is {Balance}");
       }
        
        
        
       
        
        
    }
}