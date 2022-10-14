using System;


namespace FoodDelivery
{
    public class CustomerRegistration : PersonalDetails,IBalance
    {
        private static int s_customerId=1000;

        public string CustomerId { get; set; }

        public int WalletAmount { get; set; }
        string IBalance.WalletAmount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public CustomerRegistration(int walletAmount,string name,string fathername,Gender gender,long mobile,DateTime dob,string mail,string location):base( name, fathername, gender, mobile,dob, mail, location)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;

            WalletAmount=walletAmount;
            
            
        }

        public CustomerRegistration(string data)
         {
            string[] value=data.Split(',');
            s_customerId=int.Parse(value[0].Remove(0,3));
            CustomerId=value[0];
            Name=value[1];
            FatherName=value[2];
            Gender=Enum.Parse<Gender>(value[3]);
            Mobile=long.Parse(value[4]);
            DOB=DateTime.ParseExact(value[5],"dd/MM/yyyy",null);
            MailId=value[6];
            Location=value[7];
            WalletAmount=int.Parse(value[8]);

            
            
        }

        public void WalletRecarge()
        {
            System.Console.WriteLine("Enter amount to Recharge");
            int amount=int.Parse(Console.ReadLine());
            WalletAmount+=amount;
        }
    }
}