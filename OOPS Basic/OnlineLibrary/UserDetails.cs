using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public enum Gender{Male,Female};

    public enum Department{ECE,EEE,CSE};
    public class UserDetails
    {
        static int s_userId=3000;

        public string UserId { get; set; }

        public string Name { get; set; }

        public Gender Gender { get; set; }
        
        

        public Department Department { get; set; }

        public string  Mail { get; set; }

        public long Mobile  { get; set; }

        public int WalletAmount { get; set; }
        
        

        public UserDetails(string name,Gender gender,Department dept,long mobile,string mail,int walletAmount)
        {

            s_userId++;
            UserId="SF"+s_userId;
            Name=name;
            Gender=gender;
            Department=dept;
            Mail=mail;
            Mobile=mobile;
            WalletAmount=walletAmount;
    

        }
        
        
        
        
        
        
        
        
        
        
        
        
    }
}